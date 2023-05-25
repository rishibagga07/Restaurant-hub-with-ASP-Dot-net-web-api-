using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class GetCityByStateHandler : IRequestHandler<GetCityByState, IEnumerable<City>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCityByStateHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<City>> Handle(GetCityByState request, CancellationToken cancellationToken)
        {
            var StateListByCountryID = _unitOfWork.CityRepo.GetAll(includeProperties: "State").Where(city => city.StateID == request.StateID);
            return Task.FromResult(StateListByCountryID);
        }
    }
}
