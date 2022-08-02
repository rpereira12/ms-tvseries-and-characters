using Rgp.TvSeries.Application.V1.Base;
using Rgp.TvSeries.Core.V1.Repository;
using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.Application.V1.Commands.Queries.GetById
{
    public class GetTvSeriesByIdCommandHandler : HandlerBase<GetTvSeriesByIdQuery>
    {
        private readonly ITvSeriesRepository _repository;

        public GetTvSeriesByIdCommandHandler(ITvSeriesRepository repository)
        {
            _repository = repository;
        }

        public async override Task<Result> Handle(GetTvSeriesByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var tvSeries = await _repository.GetById(request.Id);
                if (tvSeries is null)
                {
                    Result.AddError(ErrorCatalog.Value.GetByIdNotFound, ErrorCode.NotFound);
                }
                else
                {
                    Result.Data = AddTvSeriesByIdQueryResponse(tvSeries);
                }
            }
            catch (Exception)
            {
                Result.AddError(ErrorCatalog.Value.DatabaseError, ErrorCode.InternalServerError);
            }

            return await Task.FromResult(Result);
        }

        private GetTvSeriesByIdQueryResponse AddTvSeriesByIdQueryResponse(Core.Entities.TvSeries tvSeries)
        {
            return new GetTvSeriesByIdQueryResponse(
                Guid.Parse(tvSeries.Id), 
                tvSeries.Title, 
                tvSeries.Summary);
        }
    }
}
