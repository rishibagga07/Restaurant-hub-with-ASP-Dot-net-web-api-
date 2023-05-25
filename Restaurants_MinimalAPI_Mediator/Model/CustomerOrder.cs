namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class CustomerOrder
    {
        public int CustomerOrderID { get; set; }

        public string CustomerOrderProductName { get; set; }
        public int CustomerOrderQuantity { get; set;}
        public int CustomerOrderPrice { get; set;}

        public string CustomerOrderFoodImage { get; set; }

        public int CustomerOrderTotal { get; set;}

      //  public string CustomerOrderGrandTotal { get; set; }

      //  public int? TableID { get; set; }

        //public TableBooking TableBooking { get; set; }

        public int UserID { get; set; }
        public int RestID { get; set; }

        public bool IsDeleted { get; set; }
    }
}
