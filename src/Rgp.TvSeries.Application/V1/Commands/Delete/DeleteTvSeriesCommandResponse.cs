namespace Rgp.TvSeries.Application.V1.Commands.Delete
{
    public class DeleteTvSeriesCommandResponse
    {
        public string Id { get; set; }

        public DeleteTvSeriesCommandResponse(string id)
        {
            Id = id;
        }
    }
}