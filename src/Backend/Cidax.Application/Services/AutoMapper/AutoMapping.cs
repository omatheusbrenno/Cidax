using AutoMapper;
using Cidax.Communication.Requests;
using Cidax.Communication.Responses;
using Cidax.Domain.Enums;
using Sqids;

namespace Cidax.Application.Services.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToDomain();
            DomainToResponse();
        }
        private void RequestToDomain()
        {
            CreateMap<RequestRegisterLocationJson, Domain.Entities.Location>()
            .ForMember(dest => dest.Point, opt => opt.Ignore())
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => ParseCategory(src.Category)))
            .ConstructUsing(static src => Domain.Entities.Location.Create(src.Name, ParseCategory(src.Category), src.Longitude, src.Latitude));
        }
        private static Category ParseCategory(string category)
        {
            return Enum.Parse<Category>(category, true);
        }
        private void DomainToResponse()
        {
            CreateMap<Domain.Entities.Location, ResponseRegisteredLocationJson>();
        }
    }
}
