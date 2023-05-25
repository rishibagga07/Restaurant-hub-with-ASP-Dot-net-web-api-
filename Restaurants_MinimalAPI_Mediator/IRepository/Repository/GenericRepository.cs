using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> _dbset;
       // private readonly AppSettings _appSettings;

        public GenericRepository(ApplicationDbContext context )
        {
            _context = context;
            _dbset = _context.Set<T>();
          //  _appSettings = appSettings.Value;
        }



        //public AuthenticateResponse Authenticate(Login model)
        //{
        //   // var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

        //    var user =  _context.Userrss.SingleOrDefault(x => x.UserEmail == model.Email && x.UserPassword == model.password);
        //    // return null if user not found
        //    if (user == null) return null;

        //    // authentication successful so generate jwt token
        //    var token = generateJwtToken(user);

        //    return new AuthenticateResponse(user, token);
        //}

        //private string generateJwtToken(User user)
        //{
        //    // generate token that is valid for 7 days
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new[] { new Claim("id", user.UserID.ToString()) }),
        //        Expires = DateTime.UtcNow.AddDays(7),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };
        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    return tokenHandler.WriteToken(token);
        //}

        public void Add(T Entity)
        {
            _dbset.Add(Entity);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> filter = null, string IncludeProperties = null)
        {
            IQueryable<T> Query = _dbset;
            if (filter != null)
            {
                Query = Query.Where(filter);
            }
            if (IncludeProperties != null)
            {
                foreach (var includeprop in IncludeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    Query = Query.Include(includeprop);
                }

            }

            return Query.FirstOrDefault();
        }

        public T Get(int id)
        {
            return _dbset.Find(id);
        }



        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {
            IQueryable<T> query = _dbset.AsQueryable();
            if (filter != null)
                query = query.Where(filter);
            if (includeProperties != null)
            {
                foreach (var includeprop in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeprop);
                }
            }
            if (orderby != null)
            {
                return orderby(query).ToList();
            }
            return query.ToList();
        }

        public IEnumerable<T> GetAllCountry()
        {
            var CountryList = _dbset.ToList();
            return CountryList;
        }

        public void Remove(T Entity)
        {
            _dbset.Remove(Entity);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> Entity)
        {
            throw new NotImplementedException();
        }

        public void update(T Entity)
        {
            _dbset.Update(Entity);
        }

    }
}
