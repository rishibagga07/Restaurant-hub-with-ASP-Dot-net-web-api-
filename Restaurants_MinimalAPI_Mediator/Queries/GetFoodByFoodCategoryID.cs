using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries
{
    public class GetFoodByFoodCategoryID : IRequest<IEnumerable<Food>>
    {
        public int ID { get; set; }
    }
}
