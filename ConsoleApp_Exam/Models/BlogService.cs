using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exam.Models
{
    internal static class BlogService
    {
        public static void AddBlog(Blog blog)
        {
            BlogDatabase.Blogs.Add(blog);
        }
        public static void RemoveBlog(int id)
        {
            Blog Removeblog = BlogDatabase.Blogs.SingleOrDefault(blog => blog.Id == id);
            if (Removeblog != null)
            {
                BlogDatabase.Blogs.Remove(Removeblog);
            }
        }
        public static Blog GetBlogById(int id)
        {
            return BlogDatabase.Blogs.FirstOrDefault(blog => blog.Id == id);
        }
        public static List<Blog> GetAllBlogs()
        {
            return BlogDatabase.Blogs;
        }
        public static void GetBlogsByValue(string value)
        {
            BlogDatabase.Blogs.ForEach(item =>
            {
                if (item.Title.ToLower().Contains(value.ToLower()) && item.Description.ToLower().Contains(value.ToLower()))
                {
                    Console.WriteLine(item);//Eger return tipi olsaydi tapdigi ilk blog'u gostereceydi , ona gore voidnen verib console.writeline edirikki hamisini cixarsin
                }
            });
        }



    }
}
