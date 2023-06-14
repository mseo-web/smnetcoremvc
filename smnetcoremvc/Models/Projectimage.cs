using System.ComponentModel.DataAnnotations;

namespace smnetcoremvc.Models
{
    public class Projectimage
    {
        public long Id { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
