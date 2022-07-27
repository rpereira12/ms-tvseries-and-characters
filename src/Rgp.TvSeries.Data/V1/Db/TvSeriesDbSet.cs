using Microsoft.EntityFrameworkCore;
using Rgp.TvSeries.Data.V1.Mappings;

namespace Rgp.TvSeries.Data.V1.Db
{
    public partial class TvSeriesDbContext
    {
        public DbSet<Core.Entities.TvSeries> TvSeries { get; set; }

        public static void RegisterMaps(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TvSeriesMap());
        }
    }
}
