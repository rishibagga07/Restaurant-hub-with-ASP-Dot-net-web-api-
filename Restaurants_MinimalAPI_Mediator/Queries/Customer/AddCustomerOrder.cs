using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.Customer
{
    public class AddCustomerOrder : IRequest<IEnumerable<CustomerOrder>>
    {
        public int CustomerOrderID { get; set; }

        public string CustomerOrderProductName { get; set; }
        public int CustomerOrderQuantity { get; set; }
        public int CustomerOrderPrice { get; set; }
        public string CustomerOrderFoodImage { get; set; }
        public int CustomerOrderTotal { get; set; }

      //  public string CustomerOrderGrandTotal { get; set; }

     //  public int? TableID { get; set; }

        public int UserID { get; set; }

       
        public int RestID { get; set; }
    }                                                                               
}
