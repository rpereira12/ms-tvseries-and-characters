using MediatR;
using Rgp.TvSeries.Application.V1.Base;
using System.ComponentModel.DataAnnotations;

namespace Rgp.TvSeries.Application.V1.Commands.Create
{
    public class CreateTvSeriesCommand : CommandBase<CreateTvSeriesCommand>
    {
        public CreateTvSeriesCommand(string title, string summary)
        {
            Title = title;
            Summary = summary;
        }

        /// <summary>
        /// Title of the TV Series
        /// </summary>
        [Required(ErrorMessage = "The title is required.")]
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
