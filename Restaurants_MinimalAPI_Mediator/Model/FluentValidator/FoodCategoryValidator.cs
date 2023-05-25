using FluentValidation;
using Restaurants_MinimalAPI_Mediator.Queries;

namespace Restaurants_MinimalAPI_Mediator.Model.FluentValidator
{
    public class FoodCategoryValidator : AbstractValidator<AddNewFood>
    {

        public FoodCategoryValidator()
        {
           // RuleFor(x => x.FoodCategoryID).NotEmpty().WithMessage("Id Feild Should Not Be Nullable");
            RuleFor(x => x.FoodName).NotEmpty().WithMessage("Name Feild Should Not Be Nullable");
            



        }

    }
}
