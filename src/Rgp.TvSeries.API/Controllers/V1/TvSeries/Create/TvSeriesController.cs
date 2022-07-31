using Microsoft.AspNetCore.Mvc;
using Rgp.TvSeries.API.Presenters;
using Rgp.TvSeries.Application.V1.Base;
using Rgp.TvSeries.Application.V1.Commands.Create;
using System.Net;

namespace Rgp.TvSeries.API.Controllers.V1.TvSeries
{
    public partial class TvSeriesController
    {
        /// <summary>
        ///   Create a new TV Series
        /// </summary>
        /// <param name="request">The TV Series JSON represetation you want to create</param>
        /// <returns>Returns an object of type DefaultResult that could be a SuccessResult or FailureResult containing information about the request</returns>
        /// <response code ="201">Returns a SuccessResult with the ID of the new TV Series in the data field.</response>
        /// <response code ="400">Returns a FailureResult with a list of errors.</response>
        /// <response code ="500">Returns a FailureResult with a list of errors.</response>
        [HttpPost]
        public async Task<ActionResult<DefaultResult>> Post([FromBody] CreateTvSeriesCommand request)
        {
            var result = await _mediator.Send(request);

            var response = BasePresenter.Cast(result, HttpStatusCode.Created);
            return response;
        }
    }
}
