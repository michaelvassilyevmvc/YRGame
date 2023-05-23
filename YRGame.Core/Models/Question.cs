using System.ComponentModel.DataAnnotations;

namespace YRGame.Core.Models
{
    public class Question
    {
        [Key]
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        public string Comment { get; set; }

    }
}
