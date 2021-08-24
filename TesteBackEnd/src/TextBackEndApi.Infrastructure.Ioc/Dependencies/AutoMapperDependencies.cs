using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TestBackEndApi.Domain.Profiles;

namespace TextBackEndApi.Infrastructure.Ioc.Dependencies
{
    public static class AutoMapperDependencies
    {
        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new GetCepQueryResponseProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
