using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Rgp.TvSeries.Application.V1.Base;

namespace Rgp.TvSeries.Bootstrap.Pipelines
{
    public sealed class ValidationBehavior<TRequest, TResponse> :
        IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : Result, new()
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            var errors = _validators
                .Select(v => v.Validate(request))
                .SelectMany(result => result.Errors)
                .Where(f => f != null)
                .ToList();
            return errors.Any() ? ErrorHandlerAsync(errors) : next();
        }

        private static async Task<TResponse> ErrorHandlerAsync(IEnumerable<ValidationFailure> validationFail)
        {
            var response = new TResponse();

            response.AddValidationErrors(validationFail.ToList());

            return await Task.FromResult(response);
        }
    }
}
