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

            builder.HasData
            (
                new Core.Entities.TvSeries
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Breaking Bad",
                    Summary = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future."
                },

                new Core.Entities.TvSeries
                {
                    Id= Guid.NewGuid().ToString(),
                    Title = "Stranger Things",
                    Summary = "When a young boy disappears, his mother, a police chief and his friends must confront terrifying supernatural forces in order to get him back."
                },

                new Core.Entities.TvSeries
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Lost",
                    Summary = "The survivors of a plane crash are forced to work together in order to survive on a seemingly deserted tropical island."
                }
            );
        }
    }
}
