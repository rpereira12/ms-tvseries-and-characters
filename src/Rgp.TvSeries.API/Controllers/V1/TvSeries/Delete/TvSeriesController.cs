using Microsoft.AspNetCore.Mvc;
using Rgp.TvSeries.API.Presenters;
using Rgp.TvSeries.Application.V1.Commands.Delete;
using System.Net;

namespace Rgp.TvSeries.API.Controllers.V1.TvSeries
{
    public partial class TvSeriesController
    {
        /// <summary>
        ///   Delete an existing TV Series register
        /// </summary>
        /// <param name="id">The TV Series ID you wanna Delete</param>
        /// <returns>Returns an object of type DefaultResult that could be a SuccessResult or FailureResult containing information about the request</returns>
        /// <response code ="201">Returns a SuccessResult with the ID of the deleted TV Series.</response>
        /// <response code ="400">Returns a FailureResult with a list of errors.</response>
        /// <response code ="500">Returns a FailureResult with a list of errors.</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResult))]
        [HttpDelete]
        public async Task<ActionResult<DefaultResult>> Delete([FromQuery] string id)
        {
            var request = new DeleteTvSeriesCommand(id);
            var result = await _mediator.Send(request);

            var response = BasePresenter.Cast(result, HttpStatusCode.OK);
            return response;
        }
    }
}
