using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class SetCustomerOrderQuantityOnCart :  IRequest<IEnumerable<CustomerOrder>>
    {
        public int CustomerOrderID { get; set; }

        public int CustomerOrderQuantity { get; set; }
    }
}
