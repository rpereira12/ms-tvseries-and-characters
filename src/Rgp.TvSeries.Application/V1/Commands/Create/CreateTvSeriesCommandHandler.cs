using Rgp.TvSeries.Application.V1.Base;
using Rgp.TvSeries.Core.V1.Repository;
using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.Application.V1.Commands.Create
{
    public class CreateTvSeriesCommandHandler : HandlerBase<CreateTvSeriesCommand>
    {
        private readonly ITvSeriesRepository _repository;

        public CreateTvSeriesCommandHandler(ITvSeriesRepository repository)
        {
            _repository = repository;
        }

        public override async Task<Result> Handle(CreateTvSeriesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var tvSerie = CreateTvSeries(request);
                await _repository.Create(tvSerie);

                Result.Data = new CreateTvSeriesCommandResponse(tvSerie.Id);
            }
            catch (Exception)
            {
                Result.AddError(ErrorCatalog.Value.DatabaseError, ErrorCode.InternalServerError);
            }
            
            return await Task.FromResult(Result);
        }

        private Core.Entities.TvSeries CreateTvSeries(CreateTvSeriesCommand request)
        {
            return new Core.Entities.TvSeries()
            {
                Id = Guid.NewGuid().ToString(),
                Title = request.Title,
                Summary = request.Summary
            };
        }
    }
}
