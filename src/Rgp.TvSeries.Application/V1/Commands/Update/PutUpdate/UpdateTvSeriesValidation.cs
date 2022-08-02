using FluentValidation;
using Rgp.TvSeries.Application.Extension;
using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.Application.V1.Commands.Update.PutUpdate
{
    public class UpdateTvSeriesValidation : AbstractValidator<UpdateTvSeriesCommand>
    {
        public UpdateTvSeriesValidation()
        {
            RuleFor(r => r)
                .NotNull()
                .WithErrorCatalog(ErrorCatalog.Value.BaseInvalidRequest);

            RuleFor(r => r.Id)
                .NotNull()
                .NotEmpty()
                .WithErrorCatalog(ErrorCatalog.Value.CraeteCodeIsNullOrEmpty);


            RuleFor(r => r.Title)
                .NotEmpty()
                .NotNull()
                .WithErrorCatalog(ErrorCatalog.Value.CraeteDescriptionIsNullOrEmpty);

            RuleFor(r => r.Title)
               .MinimumLength(3)
               .WithErrorCatalog(ErrorCatalog.Value.CraeteDescriptionIsTooShort);


            RuleFor(r => r.Summary)
                .NotEmpty()
                .NotNull()
                .WithErrorCatalog(ErrorCatalog.Value.CraeteDescriptionIsNullOrEmpty);

            RuleFor(r => r.Summary)
               .MinimumLength(3)
               .WithErrorCatalog(ErrorCatalog.Value.CraeteDescriptionIsTooShort);
        }
    }
}
