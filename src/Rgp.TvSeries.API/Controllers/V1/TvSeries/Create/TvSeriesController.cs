using Microsoft.AspNetCore.Mvc;
using Rgp.TvSeries.API.Controllers.V1.TvSeries.Create;
using Rgp.TvSeries.Application.V1.Commands.Create;
using System.Net;

namespace Rgp.TvSeries.API.Controllers.V1.TvSeries
{
    public partial class TvSeriesController
    {
        [HttpPost]
        public async Task<IActionResult> CreateValueV1Async([FromBody] CreateTvSeriesRequest request)
        {
            CreateTvSeriesCommand command = request;
            var result = await _mediator.Send(command);

            if (!result.IsValid)
                return BadRequest(result);
            
            return Ok(result);
        }
    }
}
