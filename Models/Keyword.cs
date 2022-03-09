using System.ComponentModel.DataAnnotations;

namespace Highlight.Models
{
    public class Keyword
    {
        [Key]
        public int Id { get; set; }
        public int Preference { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public string? Note { get; set; }
        public string? Url { get; set; }
        // [Required]
        public string? Highlight { get; set; }
        public List<Tag> Tags { get; set; }
    }
}