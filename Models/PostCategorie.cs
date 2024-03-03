using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PostCategorie
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int CategorieId { get; set; }
        [ForeignKey("PostId")]
        public Post? Post { get; set; }
        [ForeignKey("CategorieId")]
        public Categorie? Categorie { get; set; }
    }
}
