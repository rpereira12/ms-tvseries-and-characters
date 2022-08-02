using FluentValidation;
using Rgp.TvSeries.Application.Extension;
using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.Application.V1.Commands.Queries.GetById
{
    public class GetTvSeriesByIdQueryValidation : AbstractValidator<GetTvSeriesByIdQuery>
    {
        public GetTvSeriesByIdQueryValidation()
        {
            RuleFor(r => r)
                .NotNull()
                .WithErrorCatalog(ErrorCatalog.Value.BaseInvalidRequest);
        }
    }

}
