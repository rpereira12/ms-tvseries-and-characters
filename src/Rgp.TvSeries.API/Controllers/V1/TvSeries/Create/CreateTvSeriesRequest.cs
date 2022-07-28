using Rgp.TvSeries.Application.V1.Commands.Create;

namespace Rgp.TvSeries.API.Controllers.V1.TvSeries.Create
{
    public class CreateTvSeriesRequest
    {
        public string Title { get; set; }
        public string Summary { get; set; }


        public static implicit operator CreateTvSeriesCommand(CreateTvSeriesRequest request)
        {
            if (request is null)
            {
                return null;
            }

            return new CreateTvSeriesCommand(request.Title,
                request.Summary);
        }
    }
}
