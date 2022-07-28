using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rgp.TvSeries.Core.V1.Repository;
using Rgp.TvSeries.Data.V1.Db;
using Rgp.TvSeries.Data.V1.Repositories;

namespace Rgp.TvSeries.Bootstrap
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection ConfigureDatabases(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("dbConnection");

            services.AddDbContext<TvSeriesDbContext>(opts =>
                opts.UseSqlServer(connectionString,
                 options => options.MigrationsAssembly("Rgp.TvSeries.Data")));

            return services;
        }
    }
}
