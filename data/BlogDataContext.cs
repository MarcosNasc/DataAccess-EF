using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEF.Data
{
    public class BlogDataContext : DbContext
    {
        private const string ConnectionString = "Server=localhost;Database=Blog;Trusted_Connection=True;TrustServerCertificate=True;";

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString);
            //options.LogTo(Console.WriteLine);
        }
    }
}