using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TestBackEndApi.Domain.Queries.Cep.Get;

namespace TextBackEndApi.Infrastructure.Ioc.Dependencies
{
    public static class MediatorDependencies
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<GetCepQuery, GetCepQueryResponse>, GetCepQueryHandler>();

            return services;
        }
    }
}
