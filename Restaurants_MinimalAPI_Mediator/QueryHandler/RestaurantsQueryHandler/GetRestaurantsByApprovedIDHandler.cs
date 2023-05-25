using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.RestaurantsQueryHandler
{
    public class GetRestaurantsByApprovedIDHandler : IRequestHandler<GetRestaurantsByApprovedID, IEnumerable<RestaurantsRegi>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetRestaurantsByApprovedIDHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<RestaurantsRegi>> Handle(GetRestaurantsByApprovedID request, CancellationToken cancellationToken)
        {
            if (request.ApprovalID == 0) return null;

            if (request.ApprovalID == 1)
            {
                var Approved = _unitOfWork.RestaurantRepo.GetAll().Where(r => r.ApprovalID == request.ApprovalID);

                return Approved;
            }
            else if (request.ApprovalID == 2)
            {
                var Disapproved =  _unitOfWork.RestaurantRepo.GetAll().Where(r => r.ApprovalID == request.ApprovalID);
                return Disapproved;

            }
            else
            {
                var Blocked = _unitOfWork.RestaurantRepo.GetAll().Where(r => r.ApprovalID == request.ApprovalID);
                return Blocked;
            }
        }
    }
}
