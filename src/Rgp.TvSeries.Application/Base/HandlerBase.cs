using MediatR;

namespace Rgp.TvSeries.Application.V1.Base
{
    public abstract class HandlerBase<TRequest> : IRequestHandler<TRequest, Result>
         where TRequest : SegregationBase<TRequest>
    {
        public Result Result { get; set; }

        protected HandlerBase()
        {
            Result = new Result();
        }

        public abstract Task<Result> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
