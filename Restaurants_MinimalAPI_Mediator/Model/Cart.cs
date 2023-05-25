using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public int CartQauntity { get; set; }
        public DateTime CartDate { get; set; }
        public double CartAmount { get; set; }

        public int FoodID { get; set; }

        public Food Food { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public int TableID { get; set; }

        public TableBooking TableBooking { get; set; }

        public int RestID { get; set; }

        public RestaurantsRegi restaurantsRegi { get; set; }





    }

}
