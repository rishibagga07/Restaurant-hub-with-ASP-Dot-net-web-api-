using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.Customer
{
    public class GetAllCustomerOrder : IRequest<IEnumerable<CustomerOrder>>
    {
        public int UserID { get; set; }
    }
}
