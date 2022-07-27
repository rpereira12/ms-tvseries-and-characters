using MediatR;
using Rgp.TvSeries.Application.V1.Base;

namespace Rgp.TvSeries.Application.V1.Commands.Create
{
    public class CreateTvSeriesCommand : CommandBase<CreateTvSeriesCommand>
    {
        public CreateTvSeriesCommand(string title, string summary)
        {
            Title = title;
            Summary = summary;
        }

        public string Title { get; set; }
        public string Summary { get; set; }
    }
}
