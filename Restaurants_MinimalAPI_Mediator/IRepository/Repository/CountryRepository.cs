using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {

        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    
    }
}
