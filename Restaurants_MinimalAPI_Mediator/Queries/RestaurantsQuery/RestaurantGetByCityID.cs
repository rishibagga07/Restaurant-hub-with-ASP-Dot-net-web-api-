using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery
{
    public class RestaurantGetByCityID : IRequest<IEnumerable<RestaurantsRegi>>
    {
        public int CityID { get; set; }
    }
}
