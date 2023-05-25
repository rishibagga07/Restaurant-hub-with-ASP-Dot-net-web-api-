using FluentValidation;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.Model.FluentValidator
{
    public class UserValidator : AbstractValidator<AddNewUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Name Feild Should Not Be Nullable");
            RuleFor(x => x.UserAge).NotEmpty();
            RuleFor(x => x.UserAddress).NotEmpty();
            RuleFor(x => x.UserEmail).EmailAddress();
            RuleFor(x => x.UserPassword).NotEmpty();


        }
    }
}
