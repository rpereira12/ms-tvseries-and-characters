using FluentValidation.Results;

namespace Rgp.TvSeries.Application.V1.Base
{
    public class Result
    {
        private readonly List<string> _errors;
        public IReadOnlyCollection<string> Errors => _errors;
        public object Data { get; set; }
        public bool IsValid => Errors.Any() == false;

        public Result()
        {
            _errors = new List<string>();
        }

        public void AddValidationErrors(List<ValidationFailure> errors)
        {
            foreach (var error in errors)
                _errors.Add(error.ErrorMessage);
        }
    }
}
