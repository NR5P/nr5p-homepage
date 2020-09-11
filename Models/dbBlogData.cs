using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace nr5p_homepage.Models
{
    public class dbBlogData : IBlogData
    {
        String connectionString = "";
        private readonly IConfiguration config;
        public dbBlogData(IConfiguration config) 
        {
            this.config = config;
            //connectionString = config["dbConnectionString"];
            connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
        }
        public IEnumerable<BlogPost> allPosts()
        {
            List<BlogPost> posts = new List<BlogPost>();
            try {
                using SqlConnection connection = new SqlConnection(this.connectionString);
                connection.Open();
                String query = "SELECT ID, Title, Description FROM dbo.tblblog";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            posts.Add(new BlogPost{id=reader.GetInt32(0), title=reader.GetString(1), body=reader.GetString(2)});
                        }
                        connection.Close();
                        return posts;
                    }
                }
            } catch {
                return null;
            }
        }
        public BlogPost getBlogPostById(int id) 
        {
            return allPosts().FirstOrDefault(p => p.id == id);
        }
    }
}