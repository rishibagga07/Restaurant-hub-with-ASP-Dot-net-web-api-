using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class UserRepo : GenericRepository<User>, IUserRepo //  GenericRepository<User>
    {
        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    
    }
}
