using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class RestaurantRepository : GenericRepository<RestaurantsRegi>, IRestaurantRepository
    {
        private readonly ApplicationDbContext _context;
        public RestaurantRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
    }
