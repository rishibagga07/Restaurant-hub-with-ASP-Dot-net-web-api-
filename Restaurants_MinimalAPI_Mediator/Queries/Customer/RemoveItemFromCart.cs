using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.Customer
{
    public class RemoveItemFromCart : IRequest<IEnumerable<CustomerOrder>>
    {
        public int CustomerOrderID { get; set; }
    }
}
