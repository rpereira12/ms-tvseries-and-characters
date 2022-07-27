using Rgp.TvSeries.Core.V1.Repository;
using Rgp.TvSeries.Data.V1.Db;

namespace Rgp.TvSeries.Data.V1.Repositories
{
    public class TvSeriesRepository : ITvSeriesRepository
    {
        private readonly TvSeriesDbContext _context;

        public TvSeriesRepository(TvSeriesDbContext context)
        {
            _context = context;
        }

        public async Task Create(Core.Entities.TvSeries tvSeries)
        {
            await _context.AddAsync(tvSeries);
            await _context.SaveChangesAsync();
        }
    }
}
