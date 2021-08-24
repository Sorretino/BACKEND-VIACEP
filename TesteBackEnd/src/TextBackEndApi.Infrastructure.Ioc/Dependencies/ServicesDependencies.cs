using Microsoft.Extensions.DependencyInjection;
using TestBackEndApi.Infrastructure.Services.Interfaces;
using TestBackEndApi.Infrastructure.Services.ServiceHandlers;

namespace TextBackEndApi.Infrastructure.Ioc.Dependencies
{
    public static class ServicesDependencies
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IViaCepServiceClient, ViaCepServiceClient>();

            return services;
        }
    }
}
