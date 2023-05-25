using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.RestaurantsQueryHandler
{
    public class GetAllRestaurantsHandler : IRequestHandler<GetAllRestaurants, IEnumerable<RestaurantsRegi>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllRestaurantsHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<RestaurantsRegi>> Handle(GetAllRestaurants request, CancellationToken cancellationToken)
        {
            var RestaurantList = _unitOfWork.RestaurantRepo.GetAll(includeProperties: "City.State.Country").Select(r => new RestaurantsRegi
            {
             RestID =   r.RestID,
                RestName =   r.RestName,
                RestImage =  r.RestImage,
                RestAddress= r.RestAddress,
                RestEmail = r.RestEmail,
                ApprovalID = r.ApprovalID,
                CityID =   r.CityID,
                City = new City 
                { CityName = r.City.CityName , 
                StateID = r.City.StateID,
                State = new State
                {
                    StateName = r.City.State.StateName,
                    CountryID = r.City.State.CountryID,
                    Country = new Country
                    {
                        CountryName = r.City.State.Country.CountryName
                    }
                }
                },

                //  r.City.CityName,
                //  r.City.State.StateName,
                //  r.City.State.Country.CountryName,
                //  r.ApprovalID,
                RoleID =  r.RoleID,
                FeedBack = r.FeedBack
            });

            return Task.FromResult(RestaurantList);
        }
    }
}
