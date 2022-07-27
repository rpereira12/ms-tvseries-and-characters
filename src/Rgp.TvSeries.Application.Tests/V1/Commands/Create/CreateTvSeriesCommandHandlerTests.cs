using Rgp.TvSeries.Application.V1.Commands.Create;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Rgp.TvSeries.Application.Tests.V1.Commands.Create
{
    public class CreateTvSeriesCommandHandlerTests
    {
        [Fact]
        public async Task Create_TvSeries_ReturnValueId()
        {
            var request = new CreateTvSeriesCommand
            (
                title: "Breaking Bad",
                summary: "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future."
            );

            var handler = new CreateTvSeriesCommandHandler();
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

            var handler = new CreateTvSeriesCommandHandler();
            var result = await handler.Handle(request, CancellationToken.None);

            Assert.False(result.IsValid);
            Assert.NotNull(result);
        }
    }
}
