using Microsoft.AspNetCore.Mvc;
using nr5p_homepage.Models;

namespace nr5p_homepage.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IBlogData _blogData;

        public BlogPostController(IBlogData blogData) 
        {
            _blogData = blogData;
        }

        public ViewResult ListPosts()
        {
            return View(_blogData.allPosts);
        } 
    }
}