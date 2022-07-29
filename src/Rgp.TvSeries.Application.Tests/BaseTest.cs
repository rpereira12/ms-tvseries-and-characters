using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rgp.TvSeries.Bootstrap;
using System.IO;

namespace Rgp.TvSeries.Application.Tests
{
    public abstract class BaseTest
    {
        protected readonly ServiceProvider serviceProvider;

        public BaseTest()
        {
            var services = new ServiceCollection();
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.Test.json");

            var configuration = configurationBuilder.Build();

            services.AddSingleton<IConfiguration>(configuration);
            ServicesConfiguration.ConfigureServices(services, configuration);

            serviceProvider = services.BuildServiceProvider();
        }
    }
}
