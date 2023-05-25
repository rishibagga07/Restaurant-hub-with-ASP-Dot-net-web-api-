using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.RestaurantsQueryHandler
{
    public class RestaurantGetByCityIDHandler : IRequestHandler<RestaurantGetByCityID, IEnumerable<RestaurantsRegi>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantGetByCityIDHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<RestaurantsRegi>> Handle(RestaurantGetByCityID request, CancellationToken cancellationToken)
        {
            var CiyId = _unitOfWork.RestaurantRepo.GetAll(includeProperties: "City").Where(r => r.CityID == request.CityID);
            var top3Restaurants = CiyId.OrderByDescending(r => r.FeedBack).ToList();
            //var top3Restaurants = CiyId.OrderByDescending(r => r.FeedBack).Take(3).ToList();
            return Task.FromResult<IEnumerable<RestaurantsRegi>>(top3Restaurants);
        }
    }
}
