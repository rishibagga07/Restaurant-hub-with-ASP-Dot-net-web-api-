using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.IRepository.Repository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class AddNewUserHandler : IRequestHandler<AddNewUser, IEnumerable<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddNewUserHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<User>> Handle(AddNewUser request, CancellationToken cancellationToken)
        {

            

            User user = new User();
            user.UserName = request.UserName;
            user.UserAge = request.UserAge;
            user.UserAddress = request.UserAddress;
            user.UserEmail = request.UserEmail;
            user.CityID = request.CityID;
            user.RoleID = 2;
            user.UserPassword = request.UserPassword;

            _unitOfWork.UserRepo.Add(user);
            _unitOfWork.Save();

            return Task.FromResult(Enumerable.Repeat(user, 1));

        }



    }
}
