using FluentValidation;
using Rgp.TvSeries.CrossCutting.Error;
using Rgp.TvSeries.Application.Extension;

namespace Rgp.TvSeries.Application.V1.Commands.Create
{
    public class CreateTvSeriesValidation : AbstractValidator<CreateTvSeriesCommand>
    {
        public CreateTvSeriesValidation()
        {
            RuleFor(r => r)
                .NotNull()
                .WithErrorCatalog(ErrorCatalog.Value.BaseInvalidRequest);

            RuleFor(r => r.Title)
                .NotEmpty()
                .NotNull()
                .WithErrorCatalog(ErrorCatalog.Value.CraeteDescriptionIsNullOrEmpty);

            RuleFor(r => r.Title)
               .MinimumLength(3)
               .WithErrorCatalog(ErrorCatalog.Value.CraeteDescriptionIsNullOrEmpty);
            

            RuleFor(r => r.Summary)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);
        }
    }
}
