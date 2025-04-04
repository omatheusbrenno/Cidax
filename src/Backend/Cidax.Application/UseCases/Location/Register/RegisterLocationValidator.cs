using Cidax.Communication.Requests;
using Cidax.Domain.Enums;
using Cidax.Exceptions;
using FluentValidation;

namespace Cidax.Application.UseCases.Location.Register
{
    public class RegisterLocationValidator : AbstractValidator<RequestRegisterLocationJson>
    {
        public RegisterLocationValidator()
        {
            RuleFor(location => location.Name)
                .NotEmpty().WithMessage(ResourceMessagesException.NAME_NOT_EMPTY)
                .Length(3, 100).WithMessage(ResourceMessagesException.NAME_LENGTH);

            RuleFor(location => location.Category)
                .NotEmpty().WithMessage(ResourceMessagesException.CATEGORY_NOT_EMPTY)
                .IsEnumName(typeof(Category), caseSensitive: false).WithMessage(ResourceMessagesException.INVALID_CATEGORY);

            RuleFor(location => location.Longitude)
                .NotEmpty().WithMessage(ResourceMessagesException.LONGITUDE_NOT_EMPTY)
                .InclusiveBetween(-180, 180).WithMessage(ResourceMessagesException.LONGITUDE_INCLUSIVE_BETWEEN);

            RuleFor(location => location.Latitude)
                .NotEmpty().WithMessage(ResourceMessagesException.LATITUDE_NOT_EMPTY)
                .InclusiveBetween(-90, 90).WithMessage(ResourceMessagesException.LATITUDE_INCLUSIVE_BETWEEN);
        }
    }
}
