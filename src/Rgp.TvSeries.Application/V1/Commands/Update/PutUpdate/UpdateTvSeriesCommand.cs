using Rgp.TvSeries.Application.V1.Base;
using System.ComponentModel.DataAnnotations;

namespace Rgp.TvSeries.Application.V1.Commands.Update.PutUpdate
{
    public class UpdateTvSeriesCommand : CommandBase<UpdateTvSeriesCommand>
    {
        public UpdateTvSeriesCommand(string id, string title, string summary)
        {
            Id = id;
            Title = title;
            Summary = summary;
        }

        /// <summary>
        /// ID of the TV Series
        /// </summary>
        [Required(ErrorMessage = "The ID is required.")]
        [MinLength(36)]
        [MaxLength(36)]
        public string Id { get; set; }

        /// <summary>
        /// Title of the TV Series
        /// </summary>
        [Required(ErrorMessage = "The Title is required.")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Title { get; set; }
        /// <summary>
        /// A little description of the show
        /// </summary>
        [Required(ErrorMessage = "The Summary is required.")]
        [MinLength(3)]
        [MaxLength(200)]
        public string Summary { get; set; }
    }
}
