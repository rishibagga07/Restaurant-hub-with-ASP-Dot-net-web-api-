using AutoMapper;
using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;

using Restaurants_MinimalAPI_Mediator.Model;

using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.RestaurantsQueryHandler
{
    public class AddRestaurantHandler : IRequestHandler<AddRestaurant, IEnumerable<RestaurantsRegi>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddRestaurantHandler(IUnitOfWork unitOfWork , IMapper mapper )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<IEnumerable<RestaurantsRegi>> Handle(AddRestaurant request, CancellationToken cancellationToken)
        {
            //var req = _mapper.Map<RestaurantsRegi>(request);
            RestaurantsRegi restaurantRegi = new RestaurantsRegi();
            restaurantRegi.RestName = request.RestName;
            restaurantRegi.RestImage = request.RestImage;
            restaurantRegi.RestAddress = request.RestAddress;
            restaurantRegi.RestEmail = request.RestEmail;
            restaurantRegi.RestPassword = request.RestPassword;
            restaurantRegi.CityID = request.CityID;
            // restaurantRegi.ApprovalID = request.ApprovalID;
            restaurantRegi.RoleID = 3;

            _unitOfWork.RestaurantRepo.Add(restaurantRegi);
            _unitOfWork.Save();

            return Task.FromResult(Enumerable.Repeat(restaurantRegi, 1));
        }


    }
}




//RestaurantsRegi restaurantRegi = new RestaurantsRegi();
//restaurantRegi.RestName = request.RestName;
//restaurantRegi.RestImage = request.RestImage;
//restaurantRegi.RestAddress = request.RestAddress;
//restaurantRegi.RestEmail = request.RestEmail;
//restaurantRegi.CityID = request.CityID;
//restaurantRegi.ApprovalID = request.ApprovalID;
//restaurantRegi.RoleID = request.RoleID;

//_unitOfWork.RestaurantRepo.Add(restaurantRegi);
//_unitOfWork.Save();

//return Task.FromResult(Enumerable.Repeat(restaurantRegi, 1));
