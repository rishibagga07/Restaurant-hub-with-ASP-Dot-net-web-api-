using MediatR;
using Restaurants_MinimalAPI_Mediator.Queries;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler
{

 
    public class GetAllFoodHandler : IRequestHandler<GetAllFood, IEnumerable<Food>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllFoodHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public async Task<IEnumerable<Food>> Handle(GetAllFood request, CancellationToken cancellationToken)
        {
           
            var foods = _unitOfWork.FoodRepo.GetAll(includeProperties: "FoodCategory");

            var foodDTOs = foods.Select(f => new 
            {f.FoodID,
               f.FoodName,
                f.FoodImage,
                f.FoodPrice,
              //  FoodCategory = new FoodCategory { FoodCategoryName = f.FoodCategory.FoodCategoryName }
              f.FoodCategoryID,
            });

            return foods;
        }


    }
}   

