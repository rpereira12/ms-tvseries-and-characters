namespace Rgp.TvSeries.Application.V1.Commands.Create
{
    public class CreateTvSeriesCommandResponse
    {
        public string Id { get; set; }

        public CreateTvSeriesCommandResponse(string id)
        {
            Id = id;
        }
    }
}