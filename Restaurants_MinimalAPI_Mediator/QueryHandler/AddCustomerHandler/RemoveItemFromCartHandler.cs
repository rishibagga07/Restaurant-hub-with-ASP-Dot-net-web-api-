using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries;
using Restaurants_MinimalAPI_Mediator.Queries.Customer;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.AddCustomerHandler
{
    public class RemoveItemFromCartHandler : IRequestHandler<RemoveItemFromCart, IEnumerable<CustomerOrder>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveItemFromCartHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<CustomerOrder>> Handle(RemoveItemFromCart request, CancellationToken cancellationToken)
        {
            var CustomerOrderFromDB = _unitOfWork.customerOrderRepo.Get(request.CustomerOrderID);
            _unitOfWork.customerOrderRepo.Remove(CustomerOrderFromDB);
            _unitOfWork.Save();
            return Task.FromResult(Enumerable.Repeat(CustomerOrderFromDB, 1));
        }
    }
}
