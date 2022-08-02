using Rgp.TvSeries.Application.V1.Base;
using Rgp.TvSeries.Core.V1.Repository;
using Rgp.TvSeries.CrossCutting.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rgp.TvSeries.Application.V1.Commands.Update.PutUpdate
{
    public class UpdateTvSeriesCommandHandler : HandlerBase<UpdateTvSeriesCommand>
    {
        private readonly ITvSeriesRepository _repository;

        public UpdateTvSeriesCommandHandler(ITvSeriesRepository repository)
        {
            _repository = repository;
        }

        public async override Task<Result> Handle(UpdateTvSeriesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var tvSerie = CreateTvSeries(request);
                await _repository.Update(tvSerie);

                Result.Data = new UpdateTvSeriesCommandResponse(tvSerie.Id);
            }
            catch (Exception)
            {
                Result.AddError(ErrorCatalog.Value.DatabaseError, ErrorCode.InternalServerError);
            }

            return await Task.FromResult(Result);
        }

        private Core.Entities.TvSeries CreateTvSeries(UpdateTvSeriesCommand request)
        {
            return new Core.Entities.TvSeries()
            {
                Id = request.Id,
                Title = request.Title,
                Summary = request.Summary
            };
        }
    }
}
