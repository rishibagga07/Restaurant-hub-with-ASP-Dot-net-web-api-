using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class TableBookingRepository : GenericRepository<TableBooking> , ITableBookingRepository
    {
        private readonly ApplicationDbContext context;

        public TableBookingRepository(ApplicationDbContext context): base(context) 
        {
            this.context = context;
        }
    }
}
