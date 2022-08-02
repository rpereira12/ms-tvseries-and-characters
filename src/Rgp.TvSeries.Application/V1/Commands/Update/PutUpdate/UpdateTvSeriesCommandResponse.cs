namespace Rgp.TvSeries.Application.V1.Commands.Update.PutUpdate
{
    public class UpdateTvSeriesCommandResponse
    {
        public string Id { get; set; }

        public UpdateTvSeriesCommandResponse(string id)
        {
            Id = id;
        }
    }
}
