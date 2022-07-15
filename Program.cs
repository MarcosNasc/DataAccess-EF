using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // var user = new User
            // {
            //     Name = "Marcos Nascimento",
            //     Slug = "marcosnascimento",
            //     Email = "marcosnascimento.dev@gmail.com",
            //     Bio = "Software Developer",
            //     Image = "https://avatars.githubusercontent.com/u/37333237?v=4",
            //     PasswordHash = "passowrd",
            // };

            // var category = new Category
            // {
            //     Name = "Backend",
            //     Slug = "backend",
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p> Hello </p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender EF core ",
            //     Title = "Começando com EF core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            var posts = context
                    .Posts
                    .AsNoTracking()
                    .Include(x => x.Author)
                    .Include(x => x.Category)
                    .OrderByDescending(x => x.LastUpdateDate)
                    .ToList();

            foreach (var post in posts)
            {

                Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
            }
        }
    }
}