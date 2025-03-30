using Cidax.Communication.Requests;
using FluentValidation;

namespace Cidax.Application.UseCases.Location.Register
{
    public class RegisterLocationValidator : AbstractValidator<RequestRegisterLocationJson>
    {
        public RegisterLocationValidator()
        {
            RuleFor(location => location.Name)
                .NotEmpty().WithMessage("kkj")
                .Length(3, 100).WithMessage("kjk");

            RuleFor(location => location.Category)
                .NotEmpty().WithMessage("h")
                .IsEnumName(typeof(LocationCategory), caseSensitive: false).WithMessage("A");

            RuleFor(location => location.Latitude)
                .NotEmpty().WithMessage("h")
                .InclusiveBetween(-90, 90).WithMessage("A");

            RuleFor(location => location.Longitude)
                .NotEmpty().WithMessage("h")
                .InclusiveBetween(-180, 180).WithMessage("A");
        }
    }
}
