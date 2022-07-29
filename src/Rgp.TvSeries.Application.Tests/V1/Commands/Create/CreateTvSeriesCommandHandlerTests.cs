using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Rgp.TvSeries.Application.V1.Commands.Create;
using Rgp.TvSeries.Core.V1.Repository;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Rgp.TvSeries.Application.Tests.V1.Commands.Create
{
    public class CreateTvSeriesCommandHandlerTests : BaseTest
    {
        private readonly ITvSeriesRepository tvSeriesRespository;
        
        public CreateTvSeriesCommandHandlerTests()
        {
            tvSeriesRespository = serviceProvider.GetRequiredService<ITvSeriesRepository>();
        }

        [Fact]
        public async Task Create_TvSeries_ReturnValueId()
        {
            var request = new CreateTvSeriesCommand
            (
                title: "Dexter",
                summary: "He's smart. He's lovable. He's Dexter Morgan, America's favorite serial killer, who spends his days solving crimes and nights committing them."
            );

            var handler = new CreateTvSeriesCommandHandler(tvSeriesRespository);
            var result = await handler.Handle(request, CancellationToken.None);

            Assert.True(result.IsValid);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Create_TvSeries_WithInvalidCommands()
        {
            var request = new CreateTvSeriesCommand
            (
                title: "aa",
                summary: "aa"
            );

            var handler = new CreateTvSeriesCommandHandler(tvSeriesRespository);
            var result = await handler.Handle(request, CancellationToken.None);

            Assert.False(result.IsValid);
            Assert.NotNull(result);
        }
    }
}
