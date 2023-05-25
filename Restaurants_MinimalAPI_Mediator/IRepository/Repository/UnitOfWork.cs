using Restaurants_MinimalAPI_Mediator.Data;

namespace Restaurants_MinimalAPI_Mediator.IRepository.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            UserRepo = new UserRepo(_context);
            CountryRepo = new CountryRepository(_context);
            StateRepo = new StateRepository(_context);
            CityRepo = new CityRepository(_context);
            RestaurantRepo = new RestaurantRepository(_context);
            FoodCategoryRepo = new FoodCategoryRepository(_context);
            FoodRepo = new FoodRepository(_context);
            TableBookingRepo = new TableBookingRepository(_context);
            paymentRepo = new PaymentRepository(_context);
          
            roleRepo = new RoleRepository(_context);
            customerOrderRepo = new CustomerOrderRepository(_context);

        }

        public IUserRepo UserRepo { get; private set; }

        public ICountryRepository CountryRepo { get; private set; }

        public IStateRepository StateRepo { get; private set; }

        public ICityRepository CityRepo { get; private set; }

        public IRestaurantRepository RestaurantRepo { get; private set; }

        public IFoodCategoryRepository FoodCategoryRepo { get; private set; }

        public IFoodRepository FoodRepo { get; private set; }

        public ITableBookingRepository TableBookingRepo { get; private set; }

        public IPaymentRepository paymentRepo { get; private set; }

       

        public IRoleRepository roleRepo { get; private set; }

        public ICustomerOrderRepository customerOrderRepo { get; private set; }

        public void Save()
        {
            _context.SaveChanges();

        }
    
    }
}
