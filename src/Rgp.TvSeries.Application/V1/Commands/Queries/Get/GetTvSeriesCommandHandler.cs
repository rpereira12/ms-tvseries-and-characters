using Rgp.TvSeries.Application.V1.Base;
using Rgp.TvSeries.Core.V1.Repository;
using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.Application.V1.Commands.Queries.Get
{
    public class GetTvSeriesCommandHandler : HandlerBase<GetTvSeriesQuery>
    {
        private readonly ITvSeriesRepository _repository;

        public GetTvSeriesCommandHandler(ITvSeriesRepository repository)
        {
            _repository = repository;
        }

        public override async Task<Result> Handle(GetTvSeriesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var tvSeries = await _repository.GetAll();
                Result.Data = AddTvSeriesQueryResponse(tvSeries);
            }
            catch (Exception)
            {
                Result.AddError(ErrorCatalog.Value.DatabaseError, ErrorCode.InternalServerError);
            }

            return await Task.FromResult(Result);
        }

        private IEnumerable<GetTvSeriesQueryResponse> AddTvSeriesQueryResponse(List<Core.Entities.TvSeries> tvSeries)
        {
            return tvSeries.Select(s => new GetTvSeriesQueryResponse(Guid.Parse(s.Id), s.Title, s.Summary));
        }
    }
}
