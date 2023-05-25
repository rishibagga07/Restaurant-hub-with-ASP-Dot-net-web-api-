using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class GetAllCountryHandler : IRequestHandler<GetAllCountry, IEnumerable<Country>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllCountryHandler(IUnitOfWork unitOfWork )
        {
            _unitOfWork= unitOfWork;
        }
        public Task<IEnumerable<Country>> Handle(GetAllCountry request, CancellationToken cancellationToken)
        {
            var CountryList = _unitOfWork.CountryRepo.GetAllCountry();
            return Task.FromResult(CountryList);
        }
    }
}
