using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.IRepository.Repository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;
using Restaurants_MinimalAPI_Mediator.Queries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler
{
    public class AddNewFoodHandler : IRequestHandler<AddNewFood, IEnumerable<Food>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddNewFoodHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public Task<IEnumerable<Food>> Handle(AddNewFood request, CancellationToken cancellationToken)
        {
            Food foods = new Food();

            foods.FoodName = request.FoodName;
            foods.FoodImage = request.FoodImage;
            foods.FoodPrice = request.FoodPrice;
            foods.FoodCategoryID = request.FoodCategoryID;

            _unitOfWork.FoodRepo.Add(foods);
            _unitOfWork.Save();

            return Task.FromResult(Enumerable.Repeat(foods, 1));
        }
    }
}
