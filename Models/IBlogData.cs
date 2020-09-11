using System;
using System.Collections.Generic;

namespace nr5p_homepage.Models
{
    public interface IBlogData
    {
        IEnumerable<BlogPost> allPosts();
        BlogPost getBlogPostById(int id);
    }
}