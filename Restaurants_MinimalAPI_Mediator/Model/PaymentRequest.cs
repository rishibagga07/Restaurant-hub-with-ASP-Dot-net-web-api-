namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class PaymentRequest
    {
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string Token { get; set; }

       
    }
}
