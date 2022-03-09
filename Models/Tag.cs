using System.ComponentModel.DataAnnotations;

namespace Highlight.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string? Body { get; set; }
        public int KeywordId { get; set; }
        public Keyword Keyword { get; set; }
    }
}