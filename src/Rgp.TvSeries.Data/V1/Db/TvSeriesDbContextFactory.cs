using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rgp.TvSeries.Data.V1.Db
{
    public class TvSeriesDbContextFactory : IDesignTimeDbContextFactory<TvSeriesDbContext>
    {
        public TvSeriesDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("dbConfig.json")
                .Build();
            var builder = new DbContextOptionsBuilder<TvSeriesDbContext>();

            var connectionString = configuration.GetConnectionString("dbConnection");
            builder.UseSqlServer(connectionString);
            return new TvSeriesDbContext(builder.Options);
        }
    }
}
