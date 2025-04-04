using Cidax.Application.Services.AutoMapper;
using Cidax.Communication.Requests;
using Cidax.Communication.Responses;
using Cidax.Exceptions.ExceptionsBase;
using System.Net.Http.Headers;

namespace Cidax.Application.UseCases.Location.Register
{
    public class RegisterLocationUseCase
    {
        public ResponseRegisteredLocationJson Execute(RequestRegisterLocationJson request)
        {
            var autoMapper = new AutoMapper.MapperConfiguration(options =>
            {
                options.AddProfile(new AutoMapping());
            }).CreateMapper();

            Validate(request);

            var location = autoMapper.Map<Domain.Entities.Location>(request);

            // Salvar no banco de dados

            return new ResponseRegisteredLocationJson
            {
                Name = request.Name,
            };
        }
        private void Validate(RequestRegisterLocationJson request)
        {
            var validator = new RegisterLocationValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage).Distinct().ToList();

                throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
