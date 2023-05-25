using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class GetUserByApprovedIDHandler : IRequestHandler<GetUserByApprovedID , IEnumerable<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetUserByApprovedIDHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> Handle(GetUserByApprovedID request, CancellationToken cancellationToken)
        {
            if (request.ApprovalID == 0) return null;

            if (request.ApprovalID == 1)
            {
                var Approved =  _unitOfWork.UserRepo.GetAll().Where(r => r.ApprovalID == request.ApprovalID);

                return Approved;
            }
            else if (request.ApprovalID == 2)
            {
                var Disapproved =  _unitOfWork.UserRepo.GetAll().Where(r => r.ApprovalID == request.ApprovalID);
                return Disapproved;

            }
            else
            {
                var Blocked =  _unitOfWork.UserRepo.GetAll().Where(r => r.ApprovalID == request.ApprovalID);
                return Blocked;
            }
        }




    }
}

