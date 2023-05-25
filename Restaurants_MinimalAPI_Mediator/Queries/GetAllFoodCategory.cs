using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries
{
    public class GetAllFoodCategory : IRequest<IEnumerable<FoodCategory>>
    {
        public FoodCategory Category { get; set; }
    }
}
