using MediatR;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries;
using Restaurants_MinimalAPI_Mediator.Queries.Customer;

namespace Restaurants_MinimalAPI_Mediator.QueryHandler.AddCustomerHandler
{
    public class AddCustomerOrderHandler : IRequestHandler<AddCustomerOrder, IEnumerable<CustomerOrder>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddCustomerOrderHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IEnumerable<CustomerOrder>> Handle(AddCustomerOrder request, CancellationToken cancellationToken)
        {
            CustomerOrder customerOrder = new CustomerOrder();

            customerOrder.CustomerOrderProductName = request.CustomerOrderProductName;
            customerOrder.CustomerOrderQuantity = request.CustomerOrderQuantity;
            customerOrder.CustomerOrderPrice = request.CustomerOrderPrice;
            customerOrder.CustomerOrderTotal = request.CustomerOrderTotal;
            //customerOrder.CustomerOrderGrandTotal = request.CustomerOrderGrandTotal;
           // customerOrder.TableID = request.TableID;
            customerOrder.UserID = request.UserID;
            customerOrder.RestID = request.RestID;
            customerOrder.CustomerOrderFoodImage = request.CustomerOrderFoodImage;
            customerOrder.IsDeleted = true;

            _unitOfWork.customerOrderRepo.Add(customerOrder);
            _unitOfWork.Save();
            return Task.FromResult(Enumerable.Repeat(customerOrder, 1));



        }
    }
}
                                                                                                                                        