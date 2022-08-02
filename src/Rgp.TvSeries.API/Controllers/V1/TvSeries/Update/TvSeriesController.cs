using Microsoft.AspNetCore.Mvc;
using Rgp.TvSeries.API.Presenters;
using Rgp.TvSeries.Application.V1.Commands.Create;
using Rgp.TvSeries.Application.V1.Commands.Update.PutUpdate;
using System.Net;

namespace Rgp.TvSeries.API.Controllers.V1.TvSeries
{
    public partial class TvSeriesController
    {
        /// <summary>
        ///   Update an existing TV Series register
        /// </summary>
        /// <param name="request">The TV Series JSON represetation you want to update</param>
        /// <returns>Returns an object of type DefaultResult that could be a SuccessResult or FailureResult containing information about the request</returns>
        /// <response code ="201">Returns a SuccessResult with the ID of the updated TV Series.</response>
        /// <response code ="400">Returns a FailureResult with a list of errors.</response>
        /// <response code ="500">Returns a FailureResult with a list of errors.</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResult))]
        [HttpPut]
        public async Task<ActionResult<DefaultResult>> Put([FromBody] UpdateTvSeriesCommand request)
        {
            var result = await _mediator.Send(request);

            var response = BasePresenter.Cast(result, HttpStatusCode.OK);
            return response;
        }
    }
}
