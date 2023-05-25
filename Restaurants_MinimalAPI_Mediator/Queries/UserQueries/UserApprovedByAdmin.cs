using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class UserApprovedByAdmin : IRequest<IEnumerable<User>>
    {
        public int UserID { get; set; }

        public int ApprovalID { get; set; }
    }
}
