using AutoMapper;
using Cidax.Communication.Requests;
using Cidax.Communication.Responses;
using Cidax.Domain.Repositories;
using Cidax.Exceptions.ExceptionsBase;

namespace Cidax.Application.UseCases.Location.Register
{
    public class RegisterLocationUseCase
    {
        private readonly IMapper _mapper;
        private readonly ILocationRepository _repository;

        public RegisterLocationUseCase(IMapper mapper, ILocationRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ResponseRegisteredLocationJson> ExecuteAsync(RequestRegisterLocationJson request)
        {
            Validate(request);

            var location = _mapper.Map<Domain.Entities.Location>(request);

            await _repository.AddAsync(location);

            return new ResponseRegisteredLocationJson
            {
                Name = location.Name
            };
        }

        private void Validate(RequestRegisterLocationJson request)
        {
            var validator = new RegisterLocationValidator();
            var result = validator.Validate(request);

            if (!result.IsValid)
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).Distinct().ToList());
        }
    }
}
