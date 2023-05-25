using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery
{
    public class GetRestaurantsByApprovedID : IRequest<IEnumerable<RestaurantsRegi>>
    {
        public int ApprovalID { get; set; }
    }
}
