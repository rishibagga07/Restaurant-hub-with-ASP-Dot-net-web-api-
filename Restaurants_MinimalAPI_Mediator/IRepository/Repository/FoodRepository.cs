using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class FoodRepository : GenericRepository<Food> , IFoodRepository
    {
        private readonly ApplicationDbContext _context;

        public FoodRepository(ApplicationDbContext context): base(context)
        {
            _context = context;
        }
    }
}
