using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;
using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.RestaurantsQueryHandler
{
    public class CompanyRequestApprovedByAdminHandler : IRequestHandler<CompanyRequestApprovedByAdmin, IEnumerable<RestaurantsRegi>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyRequestApprovedByAdminHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<RestaurantsRegi>> Handle(CompanyRequestApprovedByAdmin request, CancellationToken cancellationToken)
        {
            var Approval = _unitOfWork.RestaurantRepo.FirstOrDefault(r => r.RestID == request.RestID);
            Approval.ApprovalID = Approval.ApprovalID = request.ApprovalID;
            _unitOfWork.RestaurantRepo.update(Approval);
            _unitOfWork.Save();
            return Task.FromResult(Enumerable.Repeat(Approval, 1));
        }
    }   
}
