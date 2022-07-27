namespace Rgp.TvSeries.Application.V1.Base
{
    public abstract class CommandBase<TRequest> : SegregationBase<TRequest>
        where TRequest : SegregationBase<TRequest>
    {
    }
}
