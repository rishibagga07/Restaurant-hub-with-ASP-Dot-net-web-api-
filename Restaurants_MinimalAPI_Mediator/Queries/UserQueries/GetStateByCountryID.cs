using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class GetStateByCountryID : IRequest<IEnumerable<State>>
    {
        public int CountryID { get; set; }
    }
}
