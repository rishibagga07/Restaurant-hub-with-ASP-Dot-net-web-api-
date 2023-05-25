using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class GetAllCityHandler : IRequestHandler<GetAllCity, IEnumerable<City>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllCityHandler( IUnitOfWork unitOfWork )
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IEnumerable<City>> Handle(GetAllCity request, CancellationToken cancellationToken)
        {
            var GetAllcity = _unitOfWork.CityRepo.GetAll();
          return Task.FromResult( GetAllcity );
            
        }
    }
}
