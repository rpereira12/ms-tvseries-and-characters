using Rgp.TvSeries.Application.Base;

namespace Rgp.TvSeries.Application.V1.Commands.Queries.GetById
{
    public class GetTvSeriesByIdQuery : QueryBase<GetTvSeriesByIdQuery>
    {
        public GetTvSeriesByIdQuery(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

    }
}
