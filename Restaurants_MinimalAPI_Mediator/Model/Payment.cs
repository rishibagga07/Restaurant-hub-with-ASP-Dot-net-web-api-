using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        public bool PaymentStatus { get; set; }

        public DateTime PaymentDate  { get; set; }
        public int CustomerOrderID { get; set; }

        public CustomerOrder CustomerOrder { get; set; }
        
    }
}
