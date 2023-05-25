using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class RoleRepository : GenericRepository<Role> , IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context): base(context) 
        {
            _context = context;
        }
    }
}
