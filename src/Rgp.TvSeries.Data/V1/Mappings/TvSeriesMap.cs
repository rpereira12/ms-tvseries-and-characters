using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rgp.TvSeries.Data.V1.Mappings
{
    public class TvSeriesMap : IEntityTypeConfiguration<Core.Entities.TvSeries>
    {
        void IEntityTypeConfiguration<Core.Entities.TvSeries>.Configure(EntityTypeBuilder<Core.Entities.TvSeries> builder)
        {
            builder.Property(x => x.Id).HasColumnType("nvarchar(36)").IsRequired();
            builder.Property(x => x.Title).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Summary).HasColumnType("nvarchar(200)");

            builder.HasKey(x => x.Id);
            builder.ToTable("TvSeries");
        }
    }
}
