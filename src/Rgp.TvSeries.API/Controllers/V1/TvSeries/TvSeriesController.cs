using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Rgp.TvSeries.API.Controllers.V1.TvSeries
{
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
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
