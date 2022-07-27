using MediatR;

namespace Rgp.TvSeries.Application.V1.Base
{
    public abstract class SegregationBase<TRequest> : IRequest<Result>
          where TRequest : SegregationBase<TRequest>
    {
    }
}