using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class GetStateByCountryIDHandler : IRequestHandler<GetStateByCountryID, IEnumerable<State>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetStateByCountryIDHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<State>> Handle(GetStateByCountryID request, CancellationToken cancellationToken)
        {
            var StateListByCountryID = _unitOfWork.StateRepo.GetAll(includeProperties: "Country").Where(State => State.CountryID == request.CountryID);
            return Task.FromResult(StateListByCountryID);
        }
    }
}
