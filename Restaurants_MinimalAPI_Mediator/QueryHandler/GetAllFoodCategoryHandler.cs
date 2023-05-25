using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler
{
    public class GetAllFoodCategoryHandler : IRequestHandler<GetAllFoodCategory, IEnumerable<FoodCategory>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllFoodCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IEnumerable<FoodCategory>> Handle(GetAllFoodCategory request, CancellationToken cancellationToken)
        {

            

            var foodcategoryList = _unitOfWork.FoodCategoryRepo.GetAll();
            return Task.FromResult(foodcategoryList);
        }
    }
}
