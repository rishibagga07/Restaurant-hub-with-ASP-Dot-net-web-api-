using FluentValidation;
using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;

namespace Restaurants_MinimalAPI_Mediator.Model.FluentValidator
{
    public class RestaurantsRegiValidation : AbstractValidator<AddRestaurant>
    {

        public RestaurantsRegiValidation()
        {
            RuleFor(r => r.RestName).NotEmpty();
            RuleFor(r => r.RestImage).NotEmpty();
            RuleFor(r => r.RestAddress).NotEmpty();
            RuleFor(r => r.RestEmail).NotEmpty();
            RuleFor(r => r.RestPassword).NotEmpty();
            RuleFor(r => r.CityID).NotEmpty();

        }
    }
}
