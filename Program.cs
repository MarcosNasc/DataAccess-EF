using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {

            }
        }
    }
}