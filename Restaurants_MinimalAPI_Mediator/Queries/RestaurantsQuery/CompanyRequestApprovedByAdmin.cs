using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery
{
    public class CompanyRequestApprovedByAdmin : IRequest<IEnumerable<RestaurantsRegi>>
    {
        public int RestID { get; set; }
        public int ApprovalID { get; set; }
    }
}
