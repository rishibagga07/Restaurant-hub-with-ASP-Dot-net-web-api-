using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class RemoveUser : IRequest<IEnumerable<User>>
    {
        public int UserID { get; set; }
    }
}
