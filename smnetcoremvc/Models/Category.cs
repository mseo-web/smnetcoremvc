using System.ComponentModel.DataAnnotations;

namespace smnetcoremvc.Models
{
    public class Category
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        /*public IEnumerable<Project>? Projects { get; set; }*/
    }
}
