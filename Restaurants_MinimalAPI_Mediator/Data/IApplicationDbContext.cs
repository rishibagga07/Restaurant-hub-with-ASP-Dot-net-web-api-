using Microsoft.EntityFrameworkCore;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Approval> approvallss { get; set; }
        DbSet<City> Citieess { get; set; }
        DbSet<Country> Countrieess { get; set; }
        DbSet<FoodCategory> foodCategoriess { get; set; }
        DbSet<Food> foodss { get; set; }      
        DbSet<Payment> Paymentss { get; set; }
        DbSet<RestaurantsRegi> restaurantsRegiiss { get; set; }
        DbSet<Role> Roleess { get; set; }
        DbSet<State> Stateess { get; set; }
        DbSet<TableBooking> TableBookingss { get; set; }
        DbSet<User> Userrss { get; set; }
        DbSet<Cart> cartss { get; set; }
        DbSet<CustomerOrder> customerOrders { get; set; }
    }
}