using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.FluentValidator;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class FoodCategoryRepository : GenericRepository<FoodCategory>, IFoodCategoryRepository //   FoodCategory
    {
        private readonly ApplicationDbContext _context;

        public FoodCategoryRepository(ApplicationDbContext context): base (context) 
        {
            _context= context;
        }
    }
}
