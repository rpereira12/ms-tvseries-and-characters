using Rgp.TvSeries.Application.V1.Base;

namespace Rgp.TvSeries.Application.Base
{
    public abstract class QueryBase<TRequest> : SegregationBase<TRequest>
        where TRequest : SegregationBase<TRequest>
    {
    }
}
