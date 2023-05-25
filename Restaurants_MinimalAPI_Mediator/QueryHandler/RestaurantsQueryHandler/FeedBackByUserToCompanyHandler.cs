using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.IRepository.Repository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;
using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.RestaurantsQueryHandler
{
    public class FeedBackByUserToCompanyHandler : IRequestHandler<FeedBackByUserToCompany, IEnumerable<RestaurantsRegi>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public FeedBackByUserToCompanyHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<RestaurantsRegi>> Handle(FeedBackByUserToCompany request, CancellationToken cancellationToken)
        {
            var feedback = _unitOfWork.RestaurantRepo.FirstOrDefault(f => f.RestID == request.CompanyId);
            feedback.FeedBack = feedback.FeedBack + request.FeedBack;
            _unitOfWork.RestaurantRepo.update(feedback);
            _unitOfWork.Save();
            return Task.FromResult(Enumerable.Repeat(feedback, 1));
        }
    }
}
