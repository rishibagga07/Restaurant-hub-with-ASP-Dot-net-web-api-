using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class CustomerOrderRepository : GenericRepository<CustomerOrder>, ICustomerOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerOrderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
