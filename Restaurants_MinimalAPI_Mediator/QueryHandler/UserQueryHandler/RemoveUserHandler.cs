using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class RemoveUserHandler : IRequestHandler<RemoveUser, IEnumerable<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveUserHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<User>> Handle(RemoveUser request, CancellationToken cancellationToken)
        {
            var RemoveUserFromDb = _unitOfWork.UserRepo.Get(request.UserID);
            
            _unitOfWork.UserRepo.Remove(RemoveUserFromDb);
            _unitOfWork.Save();
            return Task.FromResult(Enumerable.Repeat(RemoveUserFromDb, 1));
        }
    }
}
