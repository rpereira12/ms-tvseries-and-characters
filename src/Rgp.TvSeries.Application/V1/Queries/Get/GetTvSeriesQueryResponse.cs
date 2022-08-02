namespace Rgp.TvSeries.Application.V1.Commands.Queries.Get
{
    public class GetTvSeriesQueryResponse
    {
        public GetTvSeriesQueryResponse(Guid id, string title, string summary)
        {
            Id = id;
            Title = title;
            Summary = summary;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
    }
}
