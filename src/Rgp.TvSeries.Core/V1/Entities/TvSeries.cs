using Rgp.TvSeries.Core.Entities.Base;

namespace Rgp.TvSeries.Core.Entities
{
    public class TvSeries : BaseEntity
    {
        public TvSeries()
        {
        }

        public string Title { get; set; }
        public string Summary { get; set; }
    }
}
