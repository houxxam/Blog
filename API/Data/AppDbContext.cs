using Microsoft.EntityFrameworkCore;
using Models;
namespace API.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PostCategorie> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<LogList> LogLists { get; set; }

    }
}
