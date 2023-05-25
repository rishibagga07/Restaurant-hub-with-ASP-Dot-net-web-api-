
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.Options;
using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Stripe;


using System;

namespace Restaurants_MinimalAPI_Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly StripeSetting _stripeSettings;
        private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public PaymentController(IOptions<StripeSetting> stripeSettings , ApplicationDbContext _context , IConfiguration configuration , IUnitOfWork unitOfWork)
        {
            _stripeSettings = stripeSettings.Value;
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }





        //[HttpPost]
        //public async Task<IActionResult> ProcessPayment([FromBody] PaymentRequest paymentRequest)
        //{
        //    StripeConfiguration.ApiKey = _configuration.GetSection("Stripe")["SecretKey"];

        //    var options = new ChargeCreateOptions
        //    {
        //        Amount = paymentRequest.Amount,
        //        Currency = paymentRequest.Currency,
        //        Description = paymentRequest.Description,
        //        Source = paymentRequest.Token
        //    };

        //    var service = new ChargeService();
        //    var charge = await service.CreateAsync(options);

        //    if (charge.Status == "succeeded")
        //    {
        //        // Payment succeeded
        //        return Ok(new { Message = "Payment succeeded!" });
        //    }
        //    else
        //    {
        //        // Payment failed
        //        return BadRequest(new { Message = "Payment failed." });
        //    }
        //}



        [HttpPost]
        public async Task<IActionResult> ProcessPayment([FromBody] PaymentRequest paymentRequest)
        {
            StripeConfiguration.ApiKey = _configuration.GetSection("Stripe")["SecretKey"];

            var options = new PaymentIntentCreateOptions
            {
                Amount = paymentRequest.Amount,
                Currency = paymentRequest.Currency,
                PaymentMethod = paymentRequest.Token,
                Confirm = true,
                Description = paymentRequest.Description,
            };

            var service = new PaymentIntentService();
            var paymentIntent = await service.CreateAsync(options);

            if (paymentIntent.Status == "succeeded")
            {
                // Payment succeeded
                return Ok(new { Message = "Payment succeeded!" });
            }
            else
            {
                // Payment failed
                return BadRequest(new { Message = "Payment failed." });
            }

            
        }

        [HttpPost("api/Payment/{UserID}")]
        public IActionResult RemoveItemFromCart(int UserID)
        {
            // var removeItemFromCart = _unitOfWork.customerOrderRepo.FirstOrDefault(x => x.UserID == UserID);
            var removeItemFromCart = _unitOfWork.customerOrderRepo.GetAll().Where(x => x.UserID == UserID && x.IsDeleted == true);
            foreach (var item in removeItemFromCart)
            {
                item.IsDeleted = false;
            }
            
            _unitOfWork.Save();
            return Ok();
        }


    }
}
