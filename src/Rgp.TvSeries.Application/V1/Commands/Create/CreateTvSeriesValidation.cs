using FluentValidation;

namespace Rgp.TvSeries.Application.V1.Commands.Create
{
    public class CreateTvSeriesValidation : AbstractValidator<CreateTvSeriesCommand>
    {
        public CreateTvSeriesValidation()
        {
            RuleFor(r => r.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(r => r.Summary)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);
        }
    }
}
