using Microsoft.AspNetCore.Mvc;
using Rgp.TvSeries.API.Presenters;
using Rgp.TvSeries.Application.V1.Commands.Queries.Get;
using Rgp.TvSeries.Application.V1.Commands.Queries.GetById;
using System.Net;

namespace Rgp.TvSeries.API.Controllers.V1.TvSeries
{
    public partial class TvSeriesController
    {
        /// <summary>
        ///   Create a new TV Series
        /// </summary>
        /// <param name="id">The TV Series ID you wanna search</param>
        /// <returns>Returns an object of type DefaultResult that could be a SuccessResult or FailureResult containing information about the request</returns>
        /// <response code ="200">Returns a SuccessResult a list all TV Series registered.</response>
        /// <response code ="400">Returns a FailureResult with a list of errors.</response>
        /// <response code ="404">No registers was found.</response>
        /// <response code ="500">Returns a FailureResult with a list of errors.</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResult))]
        [HttpGet("{id}")]
        public async Task<ActionResult<DefaultResult>> GetById([FromQuery] string id)
        {
            var getByIdQuery = new GetTvSeriesByIdQuery(id);
            var result = await _mediator.Send(getByIdQuery);

            var response = BasePresenter.Cast(result, HttpStatusCode.OK);
            return response;
        }
    }
}
