using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class GetUserByApprovedID : IRequest<IEnumerable<User>>
    {
        public int ApprovalID { get; set; }
    }
}
