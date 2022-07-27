using Microsoft.EntityFrameworkCore;

namespace Rgp.TvSeries.Data.V1.Db
{
    public partial class TvSeriesDbContext : DbContext
    {
        public TvSeriesDbContext(DbContextOptions<TvSeriesDbContext> context)
            : base(context)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            RegisterMaps(builder);
        }
    }
}
