using Microsoft.EntityFrameworkCore;
using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.IRepository.Repository;
using Restaurants_MinimalAPI_Mediator.IRepository;
using MediatR;
using Restaurants_MinimalAPI_Mediator.Queries;
using Restaurants_MinimalAPI_Mediator.DTOMapping;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Restaurants_MinimalAPI_Mediator.Model;
using Stripe;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Restaurants_MinimalAPI_Mediator.Model.FluentValidator;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



//stripe 
// set the Stripe API key
StripeConfiguration.ApiKey = "sk_test_51Ldpu3SGP2FLqt0lQ1r9QfHMTcQ9roxw0kqC7fPjDCMM2km8mZxzvhGw5ym9whwEWX1UuBqQbWtCUZ7aACKzHxuw00mIW2z2sB";


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// jwt
//builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

//jwt authentication code
//StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe")["SecretKey"];


// stripe 







var appsettingsection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appsettingsection);
var appsetting = appsettingsection.Get<AppSettings>();
var key = Encoding.ASCII.GetBytes(appsetting.Secret);
builder.Services.AddAuthentication(x =>
{
x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
x.RequireHttpsMetadata = true;
x.SaveToken = true;
x.TokenValidationParameters = new TokenValidationParameters()
{
ValidateIssuerSigningKey = true,
IssuerSigningKey = new SymmetricSecurityKey(key),
ValidateIssuer = false,
ValidateAudience = false
};
});




// add services to DI container
//{
//    var services = builder.Services;
//    services.AddControllers().
//}

// Add services to the container.

//builder.Services.AddControllers()
//                .AddFluentValidation(options =>
//                {
//                    // Validate child properties and root collection elements
//                    options.ImplicitlyValidateChildProperties = true;
//                    options.ImplicitlyValidateRootCollectionElements = true;

//                    // Automatic registration of validators in assembly
//                    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
//                });

// temp

//builder.Services.AddControllers().AddFluentValidation(f =>
//{
//    f.RegisterValidatorsFromAssemblyContaining<UserValidator>();
//});


//// Third way
//    services.AddControllersWithViews().AddFluentValidation(fv =>
//    {
//        fv.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
//    });




// Fluent Validation

builder.Services.AddControllers()
   .AddFluentValidation(s =>
   {
       s.RegisterValidatorsFromAssemblyContaining<Program>();
       /* s.RunDefaultMvcValidationAfterFluentValidationExecutes = false;*/
   });




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// ConnectionString 

string cs = builder.Configuration.GetConnectionString("dbconnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(cs));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IJWT , JWT>();
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddAutoMapper(typeof(MappingProfile));
//builder.Services.AddScoped<IValidator<User>, UserValidator>();
//builder.Services.AddValidatorsFromAssemblyContaining<UserValidator>();




builder.Services.AddCors(Options =>
{
    Options.AddPolicy(name: "MyPolicy",
        builder =>
        {
            builder.WithOrigins("https://localhost:7089/")
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();

        });
});







var app = builder.Build();



// Configure routing and endpoints
app.MapGet("/foods", async (IMediator mediator) =>
{
    var result = await mediator.Send(new GetAllFood());
    return Results.Ok(result);
});





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyPolicy");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();



app.Run();
