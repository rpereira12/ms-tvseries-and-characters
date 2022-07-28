using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Rgp.TvSeries.Bootstrap
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.ConfigureMediatr();
            services.ConfigureDatabases(configuration);
            services.ConfigureRepositories();
            
            return services;
        }
    }
}
