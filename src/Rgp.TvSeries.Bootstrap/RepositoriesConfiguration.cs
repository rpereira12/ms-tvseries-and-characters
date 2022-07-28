using Microsoft.Extensions.DependencyInjection;
using Rgp.TvSeries.Core.V1.Repository;
using Rgp.TvSeries.Data.V1.Repositories;

namespace Rgp.TvSeries.Bootstrap
{
    public static class RepositoriesConfiguration
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection service)
        {
            service.AddScoped<ITvSeriesRepository, TvSeriesRepository>();
            return service;
        }
    }
}
