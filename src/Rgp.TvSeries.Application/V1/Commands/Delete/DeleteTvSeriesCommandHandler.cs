using Rgp.TvSeries.Application.V1.Base;
using Rgp.TvSeries.Core.V1.Repository;
using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.Application.V1.Commands.Delete
{
    public class DeleteTvSeriesCommandHandler : HandlerBase<DeleteTvSeriesCommand>
    {
        private readonly ITvSeriesRepository _repository;

        public DeleteTvSeriesCommandHandler(ITvSeriesRepository repository)
        {
            _repository = repository;
        }

        public override async Task<Result> Handle(DeleteTvSeriesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var tvSerie = await _repository.GetById(request.Id);
                if (tvSerie is null)
                {
                    Result.AddError(ErrorCatalog.Value.GetByIdNotFound, ErrorCode.NotFound);
                }
                else
                {
                    await _repository.Delete(tvSerie);
                    Result.Data = new DeleteTvSeriesCommandResponse(tvSerie.Id);
                }
            }
            catch (Exception)
            {
                Result.AddError(ErrorCatalog.Value.DatabaseError, ErrorCode.InternalServerError);
            }
            
            return await Task.FromResult(Result);
        }
    }
}
