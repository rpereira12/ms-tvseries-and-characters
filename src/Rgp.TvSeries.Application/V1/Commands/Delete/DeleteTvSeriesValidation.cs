using FluentValidation;
using Rgp.TvSeries.CrossCutting.Error;
using Rgp.TvSeries.Application.Extension;

namespace Rgp.TvSeries.Application.V1.Commands.Delete
{
    public class DeleteTvSeriesValidation : AbstractValidator<DeleteTvSeriesCommand>
    {
        public DeleteTvSeriesValidation()
        {
            RuleFor(r => r)
                .NotNull()
                .WithErrorCatalog(ErrorCatalog.Value.BaseInvalidRequest);

            RuleFor(r => r.Id)
                .NotNull()
                .NotEmpty()
                .WithErrorCatalog(ErrorCatalog.Value.CraeteCodeIsNullOrEmpty);
        }
    }
}
