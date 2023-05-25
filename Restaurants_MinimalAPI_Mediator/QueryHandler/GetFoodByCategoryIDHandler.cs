using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler
{
    public class GetFoodByCategoryIDHandler : IRequestHandler<GetFoodByFoodCategoryID, IEnumerable<Food>>
    {
       
        private readonly IUnitOfWork _unitOfWork;

        public GetFoodByCategoryIDHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IEnumerable<Food>> Handle(GetFoodByFoodCategoryID request, CancellationToken cancellationToken)
        {
            var FoodCategoryID = _unitOfWork.FoodRepo.GetAll(includeProperties: "FoodCategory").Where(f => f.FoodCategoryID == request.ID);
            var result = FoodCategoryID.Select(f => new Food
            {
                FoodID = f.FoodID,
                FoodName= f.FoodName,
                FoodPrice= f.FoodPrice,
                FoodImage= f.FoodImage,
                FoodCategoryID= f.FoodCategoryID,
                FoodCategory = null
                
            });
            return result;
        }

    }
}
