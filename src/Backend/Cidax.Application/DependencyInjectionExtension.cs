using AutoMapper;
using Cidax.Application.Services.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Cidax.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddAutoMapper(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping).Assembly);
        }
    }
}
