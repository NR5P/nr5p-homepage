using System;
using System.Linq;
using System.Collections.Generic;

namespace nr5p_homepage.Models
{
    public class MockBlogData : IBlogData
    {
        public IEnumerable<BlogPost> allPosts()
        {
            return new List<BlogPost>
            {
                new BlogPost{id=1, title="first post", body="this is the first post", createdOn=new DateTime(2017,1,18)},
                new BlogPost{id=2, title="second post", body="this is the second post", createdOn=new DateTime(2018,2,19)},
                new BlogPost{id=3, title="third post", body="this is the third post", createdOn=new DateTime(2019,3,20)}
            };
        }

        public BlogPost getBlogPostById(int id) 
        {
            return allPosts().FirstOrDefault(p => p.id == id);
        }
    }
}