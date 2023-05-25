using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries
{
    public class DeleteFood : IRequest<IEnumerable<Food>>
    {
        public int FoodID { get; set; }
    }
}
