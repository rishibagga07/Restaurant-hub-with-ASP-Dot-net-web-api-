using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler
{
    public class DeleteFoodHandler : IRequestHandler<DeleteFood, IEnumerable<Food>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteFoodHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Food>> Handle(DeleteFood request, CancellationToken cancellationToken)
        {
            var FoodFromDb = _unitOfWork.FoodRepo.Get(request.FoodID);
           
            _unitOfWork.FoodRepo.Remove(FoodFromDb);
            _unitOfWork.Save();
            return Task.FromResult(Enumerable.Repeat(FoodFromDb, 1));
        }
    }
}
