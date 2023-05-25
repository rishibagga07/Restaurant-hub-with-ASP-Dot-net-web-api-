using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries;
using Restaurants_MinimalAPI_Mediator.Queries.Customer;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.AddCustomerHandler
{
    public class GetAllCustomerOrderHandler : IRequestHandler<GetAllCustomerOrder, IEnumerable<CustomerOrder>>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetAllCustomerOrderHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<CustomerOrder>> Handle(GetAllCustomerOrder request, CancellationToken cancellationToken)
        {
            var GetAllOrders = _unitOfWork.customerOrderRepo.GetAll().Where(x => x.UserID == request.UserID && x.IsDeleted == true);
            return Task.FromResult(GetAllOrders);
        }
    }
}
