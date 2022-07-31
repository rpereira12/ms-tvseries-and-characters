using FluentValidation;
using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.Application.Extension
{
    public static class RuleBuilderOptionExtension
    {
        public static IRuleBuilderOptions<T, TProperty> WithErrorCatalog<T, TProperty>(
            this IRuleBuilderOptions<T, TProperty> rule, ErrorCatalogEntry errorCatalogEntry)
        {
            //todo
            return null;
            //return rule.WithErrorCode(errorCatalogEntry.Code).WithMessage(errorCatalogEntry.Message);
        }
    }
}
