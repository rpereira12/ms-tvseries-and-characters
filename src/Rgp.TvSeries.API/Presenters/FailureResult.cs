using Rgp.TvSeries.CrossCutting.Error;

namespace Rgp.TvSeries.API.Presenters
{
    public class FailureResult<TNotifications> : DefaultResult
    {
        public ErrorCode? Code { get; }
        public string Message { get; }
        public IEnumerable<TNotifications> Errors { get; }


        public FailureResult()
        {
        }

        public FailureResult(ErrorCode? code,
            IEnumerable<TNotifications> errors,
            string message)
        {
            Code = code;
            Message = message;
            Errors = errors;
        }
    }
}

