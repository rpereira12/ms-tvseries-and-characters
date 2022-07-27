using Rgp.TvSeries.Application.V1.Base;

namespace Rgp.TvSeries.Application.V1.Commands.Create
{
    public class CreateTvSeriesCommandHandler : HandlerBase<CreateTvSeriesCommand>
    {
        public override async Task<Result> Handle(CreateTvSeriesCommand request, CancellationToken cancellationToken)
        {
            var result = new Result();
            var validationResult = new CreateTvSeriesValidation().Validate(request);

            if (!validationResult.IsValid)
            {
                result.AddValidationErrors(validationResult.Errors);
                return await Task.FromResult(result);
            }

            var mock = new CreateTvSeriesCommandResponse(Guid.NewGuid().ToString());
            result.Data = mock;

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
