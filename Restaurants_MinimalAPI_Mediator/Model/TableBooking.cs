using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class TableBooking
    {
        [Key]
        public int TableID { get; set; }

        public int TableNumber { get; set; }

    }
}
