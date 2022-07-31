namespace Rgp.TvSeries.API.Presenters
{
    public class SuccessResult : DefaultResult
    {
        public SuccessResult(object data, string message = null)
        {
            Message = message;
            Data = data;
        }

        public string Message { get; set; }
        public object Data { get; set; }

    }
}
