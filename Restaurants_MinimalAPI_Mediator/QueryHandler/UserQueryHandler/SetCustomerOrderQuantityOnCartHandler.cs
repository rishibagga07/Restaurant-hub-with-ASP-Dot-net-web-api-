using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.UserQueryHandler
{
    public class SetCustomerOrderQuantityOnCartHandler : IRequestHandler<SetCustomerOrderQuantityOnCart, IEnumerable<CustomerOrder>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SetCustomerOrderQuantityOnCartHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<CustomerOrder>> Handle(SetCustomerOrderQuantityOnCart request, CancellationToken cancellationToken)
        {
            
            var CustomerOrderID = _unitOfWork.customerOrderRepo.FirstOrDefault(x => x.CustomerOrderID== request.CustomerOrderID);

            var customerOrderQuantity = CustomerOrderID.CustomerOrderQuantity;

            if (customerOrderQuantity >1 ) { 
            CustomerOrderID.CustomerOrderQuantity = CustomerOrderID.CustomerOrderQuantity +  request.CustomerOrderQuantity;
            }
            else if( request.CustomerOrderQuantity == +1)
            {
                CustomerOrderID.CustomerOrderQuantity = CustomerOrderID.CustomerOrderQuantity + request.CustomerOrderQuantity;
            }
            else
            {
                CustomerOrderID.CustomerOrderQuantity = 1;
            }


            _unitOfWork.customerOrderRepo.update(CustomerOrderID);
            _unitOfWork.Save();
            return Task.FromResult(Enumerable.Repeat(CustomerOrderID, 1));

        }
    }
}
