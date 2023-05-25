using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class JWT : IJWT
    {

        private readonly AppSettings _appSettings;
        private readonly ApplicationDbContext _context;
        public JWT(IOptions<AppSettings> appSettings , ApplicationDbContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }


        public AuthenticateResponse Authenticate(Login model)
        {
            // var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

          //  var user = _context.Userrss.SingleOrDefault(x => x.UserEmail == model.Email && x.UserPassword == model.password );
            var user = _context.Userrss.FirstOrDefault(x => x.UserEmail == model.Email && x.UserPassword == model.password);

            if (user.ApprovalID != 1)
            {
                return null;
            }

            // return null if user not found
            if (user == null) return null;

            
            
                // authentication successful so generate jwt token
                var token = generateJwtToken(user);
            
            

            return new AuthenticateResponse(user, token);
        }


        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id",  user.UserID.ToString()), new Claim("name", user.UserName.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
