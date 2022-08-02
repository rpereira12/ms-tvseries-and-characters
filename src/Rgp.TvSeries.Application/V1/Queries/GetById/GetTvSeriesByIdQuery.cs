using Rgp.TvSeries.Application.Base;
using System.ComponentModel.DataAnnotations;

namespace Rgp.TvSeries.Application.V1.Commands.Queries.GetById
{
    public class GetTvSeriesByIdQuery : QueryBase<GetTvSeriesByIdQuery>
    {
        public GetTvSeriesByIdQuery(string id)
        {
            Id = id;
        }

        /// <summary>
        /// ID of the TV Series
        /// </summary>
        [Required(ErrorMessage = "The ID is required.")]
        [MinLength(36)]
        [MaxLength(36)]
        public string Id { get; set; }

    }
}
