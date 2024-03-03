using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
        [ForeignKey("PostId")]
        public Post? Post { get; set; }

    }
}
