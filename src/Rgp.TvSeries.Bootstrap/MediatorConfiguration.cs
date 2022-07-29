using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Rgp.TvSeries.Bootstrap.Pipelines;
using System.Reflection;

namespace Rgp.TvSeries.Bootstrap
{
    public static class MediatorConfiguration
    {

        private const string APPLICATION_NAMESPACE = "Rgp.TvSeries.Application";

        public static IServiceCollection ConfigureMediatr(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.Load(APPLICATION_NAMESPACE));

            var currentAssemblies = AppDomain.CurrentDomain.GetAssemblies()
            .Where(c => c.GetName().Name.Contains(APPLICATION_NAMESPACE));

            AssemblyScanner.FindValidatorsInAssemblies(currentAssemblies)
              .ForEach(c => services.AddScoped(c.InterfaceType, c.ValidatorType));

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
