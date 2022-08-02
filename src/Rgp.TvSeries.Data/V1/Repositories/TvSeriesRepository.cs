using Microsoft.EntityFrameworkCore;
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

        public async Task Delete(Core.Entities.TvSeries tvSeries)
        {
            _context.Remove(tvSeries);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Core.Entities.TvSeries>> GetAll()
        {
            return await _context.TvSeries.ToListAsync();
        }

        public async Task<Core.Entities.TvSeries> GetById(string id)
        {
            return await _context.TvSeries.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Core.Entities.TvSeries tvSeries)
        {
            _context.Update(tvSeries);
            await _context.SaveChangesAsync();
        }
    }
}
