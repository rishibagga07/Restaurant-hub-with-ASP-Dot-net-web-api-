namespace Restaurants_MinimalAPI_Mediator.IRepository
{
    public interface IUnitOfWork
    {

        IUserRepo UserRepo { get; }
        ICountryRepository CountryRepo { get; }
        IStateRepository StateRepo { get; }
        ICityRepository CityRepo { get; }
        IRestaurantRepository RestaurantRepo { get; }
        IFoodCategoryRepository FoodCategoryRepo { get; }
        IFoodRepository FoodRepo { get; }

        ITableBookingRepository TableBookingRepo { get; }
        IPaymentRepository paymentRepo { get; }

       

        IRoleRepository roleRepo { get; }

        ICustomerOrderRepository customerOrderRepo { get; }

        void Save();

    }
}
