using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class GetAllCity : IRequest<IEnumerable<City>>
    {
    }
}
