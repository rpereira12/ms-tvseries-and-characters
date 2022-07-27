using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Rgp.TvSeries.Bootstrap
{
    public static class MediatorConfiguration
    {

        private const string APPLICATION_NAMESPACE = "Rgp.TvSeries.Application";

        public static IServiceCollection ConfigureMediatr(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.Load(APPLICATION_NAMESPACE));
            return services;
        }
    }
}
