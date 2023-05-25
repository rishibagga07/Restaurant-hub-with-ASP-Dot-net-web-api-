using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;
using Restaurants_MinimalAPI_Mediator.Queries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler
{
    public class UpdateFoodHandler : IRequestHandler<UpdateFood, IEnumerable<Food>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateFoodHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Food>> Handle(UpdateFood request, CancellationToken cancellationToken)
        {
            Food foods = new Food();
            foods.FoodID = request.FoodID;
            foods.FoodName = request.FoodName;
            foods.FoodImage = request.FoodImage;
            foods.FoodPrice = request.FoodPrice;
            foods.FoodCategoryID = request.FoodCategoryID;


            _unitOfWork.FoodRepo.update(foods);
            _unitOfWork.Save();
            return Task.FromResult(Enumerable.Repeat(foods, 1));
        }
    }
}
