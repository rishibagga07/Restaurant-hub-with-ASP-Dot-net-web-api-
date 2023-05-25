using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class UserApprovedByAdminHandler : IRequestHandler<UserApprovedByAdmin, IEnumerable<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserApprovedByAdminHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<User>> Handle(UserApprovedByAdmin request, CancellationToken cancellationToken)
        {
            var approval = _unitOfWork.UserRepo.FirstOrDefault(a => a.UserID == request.UserID);
            approval.ApprovalID = request.ApprovalID;
            _unitOfWork.UserRepo.update(approval);
            _unitOfWork.Save();

            return Task.FromResult(Enumerable.Repeat(approval, 1)); 
        }
        
    }
}
