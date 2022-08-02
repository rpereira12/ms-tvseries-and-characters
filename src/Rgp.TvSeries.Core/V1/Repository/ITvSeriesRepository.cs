﻿namespace Rgp.TvSeries.Core.V1.Repository
{
    public interface ITvSeriesRepository
    {
        Task Create(Entities.TvSeries tvSeries);
        Task<List<Entities.TvSeries>> GetAll();
        Task<Entities.TvSeries> GetById(string id);
    }
}
