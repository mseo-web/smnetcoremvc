using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace smnetcoremvc.Models
{
    public class Project
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public string Name { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        [Required, MinLength(4, ErrorMessage = "Minimum length is 2")]
        public string Description { get; set; } = string.Empty;

        public string Client { get; set; } = string.Empty;

        public string Spec { get; set; } = string.Empty;

        public string Period { get; set; } = string.Empty;

        public string Siteurl { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must choose a category")]
        public int CategoryId { get; set; }

        public string Images { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
