using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class GetCityByState : IRequest<IEnumerable<City>>
    {
        public int StateID { get; set; }
    }
}
