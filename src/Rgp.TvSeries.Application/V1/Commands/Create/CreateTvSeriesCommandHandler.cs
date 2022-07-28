using Rgp.TvSeries.Application.V1.Base;
using Rgp.TvSeries.Core.V1.Repository;

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
            var result = new Result();
            var validationResult = new CreateTvSeriesValidation().Validate(request);

            if (!validationResult.IsValid)
            {
                result.AddValidationErrors(validationResult.Errors);
                return await Task.FromResult(result);
            }
            
            var tvSerie = CreateTvSeries(request);
            await _repository.Create(tvSerie);

            result.Data = tvSerie.Id;

            return await Task.FromResult(result);
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
