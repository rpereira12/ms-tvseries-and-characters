using Microsoft.AspNetCore.Mvc;
using Rgp.TvSeries.CrossCutting.Error;
using Rgp.TvSeries.Application.V1.Base;
using Rgp.TvSeries.CrossCutting.Extensions;
using System.Net;

namespace Rgp.TvSeries.API.Presenters
{
    public static class BasePresenter
    {
        public static ActionResult<DefaultResult> Cast(Result result, HttpStatusCode statusCode)
        {
            if (result.Error.HasValue)
            {
                return result.Error.Value
                switch
                {
                    ErrorCode.NotFound => new NotFoundObjectResult(CreateFailureResult(result)),
                    ErrorCode.UnprocessableEntity => new UnprocessableEntityObjectResult(CreateFailureResult(result)),
                    ErrorCode.Unauthorized => new UnauthorizedObjectResult(CreateFailureResult(result)),
                    ErrorCode.InternalServerError => new ObjectResult(CreateFailureResult(result))
                    {
                        StatusCode = (int)HttpStatusCode.InternalServerError
                    },
                    _ => new BadRequestObjectResult(CreateFailureResult(result)),
                };
            }
            else
            {
                return statusCode
                switch
                {
                    HttpStatusCode.OK => new OkObjectResult(result),
                    HttpStatusCode.Created => new CreatedResult(string.Empty, CreateSucessResult(result, "Your content has been created succesfully.")), //TO DO: Create Enum to these messages!
                    HttpStatusCode.NoContent => new NoContentResult(),
                    HttpStatusCode.Accepted => new AcceptedResult(string.Empty, CreateSucessResult(result, "Your content has been created succesfully.")),
                    _ => new OkResult()
                };
            }
        }

        public static FailureResult<ErrorDetail> CreateFailureResult(Result result)
        {
            return new FailureResult<ErrorDetail>(result.Error,
                result.Errors,
                result.Error.GetDescription());
        }

        public static SuccessResult CreateSucessResult(Result result, string message = null)
        {
            return new SuccessResult(result.Data, message);
        }
    }

}
