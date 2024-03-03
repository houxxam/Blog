using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PostTag
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int TagId { get; set; }
        [ForeignKey("PostId")]
        public Post? Post { get; set; }
        [ForeignKey("TagId")]
        public Tag? Tag { get; set; }
    }
}
