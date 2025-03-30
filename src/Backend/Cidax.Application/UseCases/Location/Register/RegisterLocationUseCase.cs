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
            Validate(request);

            // Mapear a request com uma entidade

            // Transformar Json em GeoJson

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
                var errorMessages = result.Errors.Select(e => e.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
