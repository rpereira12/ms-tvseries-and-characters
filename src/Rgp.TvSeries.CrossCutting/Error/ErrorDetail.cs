namespace Rgp.TvSeries.CrossCutting.Error
{
    public class ErrorDetail
    {
        public ErrorDetail(string errorCode, string message, string property = null)
        {
            Property = property;
            ErrorCode = errorCode;
            Message = message;
        }

        public string Property { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }
}
