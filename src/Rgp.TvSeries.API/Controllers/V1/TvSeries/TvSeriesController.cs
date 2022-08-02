using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rgp.TvSeries.API.Presenters;
using Rgp.TvSeries.Application.V1.Base;

namespace Rgp.TvSeries.API.Controllers.V1.TvSeries
{
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(FailureResult<Result>))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(FailureResult<Result>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(FailureResult<Result>))]
    [Route("[controller]")]
    [ApiVersion("1")]
    public partial class TvSeriesController : ControllerBase
    {
        private readonly IMediator _mediator;


        public TvSeriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
