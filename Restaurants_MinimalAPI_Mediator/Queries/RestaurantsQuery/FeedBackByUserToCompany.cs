using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery
{
    public class FeedBackByUserToCompany : IRequest<IEnumerable<RestaurantsRegi>>
    {
        public int CompanyId { get; set; }
        public int FeedBack { get; set; }
    }
}
