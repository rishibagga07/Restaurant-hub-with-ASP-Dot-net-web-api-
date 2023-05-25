using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.RestaurantsQueryHandler
{
    public class UpdateRestaurantHandler : IRequestHandler<UpdateRestaurant, IEnumerable<RestaurantsRegi>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRestaurantHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<RestaurantsRegi>> Handle(UpdateRestaurant request, CancellationToken cancellationToken)
        {
            RestaurantsRegi restaurantRegi = new RestaurantsRegi();
            restaurantRegi.RestID = request.RestID;
            restaurantRegi.RestName = request.RestName;
            restaurantRegi.RestImage = request.RestImage;
            restaurantRegi.RestAddress = request.RestAddress;
            restaurantRegi.RestEmail = request.RestEmail;
            restaurantRegi.CityID = request.CityID;
            restaurantRegi.FeedBack = request.FeedBack;
            restaurantRegi.ApprovalID = request.ApprovalID;
            restaurantRegi.RoleID = request.RoleID;

            _unitOfWork.RestaurantRepo.update(restaurantRegi);
            _unitOfWork.Save();

            return Task.FromResult(Enumerable.Repeat(restaurantRegi, 1));
        }
    }
}
