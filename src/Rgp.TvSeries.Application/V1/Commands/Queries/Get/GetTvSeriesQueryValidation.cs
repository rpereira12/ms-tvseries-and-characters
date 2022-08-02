using FluentValidation;
using Rgp.TvSeries.Application.Extension;
using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.Application.V1.Commands.Queries.Get
{
    public class GetTvSeriesQueryValidation : AbstractValidator<GetTvSeriesQuery>
    {
        public GetTvSeriesQueryValidation()
        {
            RuleFor(r => r)
                .NotNull()
                .WithErrorCatalog(ErrorCatalog.Value.BaseInvalidRequest);
        }
    }
}
