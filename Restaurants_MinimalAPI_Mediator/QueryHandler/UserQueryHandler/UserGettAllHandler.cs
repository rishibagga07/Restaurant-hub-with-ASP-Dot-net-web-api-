using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class UserGettAllHandler : IRequestHandler<UserGettAll, IEnumerable<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserGettAllHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> Handle(UserGettAll request, CancellationToken cancellationToken)
        {

            var users = _unitOfWork.UserRepo.GetAll(includeProperties: "City.State.Country");
            var userlist = users.Select(u => new User
            {
                UserID = u.UserID,
                UserName = u.UserName,
                UserAge = u.UserAge,
                UserAddress = u.UserAddress,
                UserEmail = u.UserEmail,
                RoleID = u.RoleID,
                //Approval = u.Approval != null ? new Approval { ApprovalType = u.Approval.ApprovalType } : null,
                ApprovalID = u.ApprovalID,
                CityID = u.CityID,
                City = new City
                {
                    CityName = u.City.CityName,
                    StateID = u.City.StateID,
                    State = new State
                    {
                        StateName = u.City.State.StateName,
                        CountryID = u.City.State.CountryID,
                        Country = new Country
                        {
                            CountryName = u.City.State.Country.CountryName
                        }
                    }
                }
            });




            //var users =  _unitOfWork.UserRepo.GetAll(includeProperties: "City.State.Country");

            //var userlist = users.Select(u => new User
            //{
            //    UserID = u.UserID,
            //    UserName = u.UserName,
            //    UserAge = u.UserAge,
            //    UserAddress = u.UserAddress,
            //    UserEmail = u.UserEmail,
            //    RoleID = u.RoleID,
            //    Approval = new Approval
            //    {
            //        ApprovalType = u.Approval.ApprovalType
            //    },
            //    CityID = u.CityID,
            //    City = new City
            //    {
            //        CityName = u.City.CityName,
            //        StateID = u.City.StateID,
            //        State = new State
            //        {
            //            StateName = u.City.State.StateName,
            //            CountryID = u.City.State.CountryID,
            //            Country = new Country
            //            {
            //                CountryName = u.City.State.Country.CountryName
            //            }
            //        }
            //    },



            //}).ToList();

            return userlist;
        }
    }
}
