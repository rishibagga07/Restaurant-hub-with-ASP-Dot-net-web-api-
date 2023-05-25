using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class UpdateUserHandler : IRequestHandler<UpdateUser, IEnumerable<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateUserHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<User>> Handle(UpdateUser request, CancellationToken cancellationToken)
        {
            User user = new User();
            user.UserID = request.UserID;
            user.UserName = request.UserName;
            user.UserAge = request.UserAge;
            user.UserAddress = request.UserAddress;
            user.UserEmail = request.UserEmail;
            user.CityID = request.CityID;
            user.RoleID = request.RoleID;
            user.ApprovalID = request.ApprovalID;

            _unitOfWork.UserRepo.update(user);
            _unitOfWork.Save();

            return Task.FromResult(Enumerable.Repeat(user, 1));
        }
    }
}
