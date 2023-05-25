using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery
{
    public class GetAllRestaurants : IRequest<IEnumerable<RestaurantsRegi>>
    {
    }
}
