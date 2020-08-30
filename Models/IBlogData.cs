using System;
using System.Collections.Generic;

namespace nr5p_homepage.Models
{
    public interface IBlogData
    {
        IEnumerable<BlogPost> allPosts {get;}
        BlogPost getBlogPostById(int id);
    }
}