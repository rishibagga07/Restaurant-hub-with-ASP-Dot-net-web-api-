using Microsoft.EntityFrameworkCore;
using Restaurants_MinimalAPI_Mediator.Model;
using System.Data;
using System.Diagnostics.Metrics;

namespace Restaurants_MinimalAPI_Mediator.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<City> Citieess { get; set; }

        public DbSet<State> Stateess { get; set; }
        public DbSet<Country> Countrieess { get; set; }
        public DbSet<Role> Roleess { get; set; }
        public DbSet<User> Userrss { get; set; }
        public DbSet<Approval> approvallss { get; set; }

        public DbSet<RestaurantsRegi> restaurantsRegiiss { get; set; }
        public DbSet<Food> foodss { get; set; }
        public DbSet<FoodCategory> foodCategoriess { get; set; }

        public DbSet<TableBooking> TableBookingss { get; set; }

        public DbSet<Payment> Paymentss { get; set; }

        public DbSet<Cart> cartss { get; set; }

        public DbSet<CustomerOrder> customerOrders { get; set; }

}
}
