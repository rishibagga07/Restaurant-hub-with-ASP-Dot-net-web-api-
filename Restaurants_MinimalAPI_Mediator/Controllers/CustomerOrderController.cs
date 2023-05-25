using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Queries;
using Restaurants_MinimalAPI_Mediator.Queries.Customer;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerOrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

                                                                    

        [HttpGet("GetAllCustomerOrdersByUserID/{UserId}", Name = nameof(GetAllCustomerOrdersByUserID))]
        public async Task<IActionResult> GetAllCustomerOrdersByUserID(int UserId) => Ok(await _mediator.Send(new GetAllCustomerOrder { UserID = UserId })); 



        [HttpPost("AddNewCustomerOrder", Name = nameof(AddNewCustomerOrder))]
        public async Task<IActionResult> AddNewCustomerOrder(AddCustomerOrder request) => Ok(await _mediator.Send(request));



        [HttpPatch("/api/CustomerOrderController/SetCustomerOrderQuantityOnCart/")]

        public async Task<IActionResult> SetCustomerOrderQuantityOnCart(SetCustomerOrderQuantityOnCart request)
        {
            return Ok(await _mediator.Send(request));
        }


        [HttpDelete("RemoveItemFromCart/{CustomerOrderID}", Name = nameof(RemoveItemFromCart))]
        public async Task<IActionResult> RemoveItemFromCart(int CustomerOrderID)
        {
            var CustomerOrderFromDB = await _mediator.Send(new RemoveItemFromCart { CustomerOrderID = CustomerOrderID });
            return Ok(new { CustomerOrderFromDB, message = " Data Successfuly Delete" });
        }
    }
}
