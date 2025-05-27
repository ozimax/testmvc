
namespace DemoAzureWebsite.Models
{
    public class Post
    {
        public int PostId { get; set; } // Primary key
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; } // Foreign key to the Blogs table


        public string vum { get; set; }
        public string kum { get; set; }
        public int bumbum { get; set; } // Foreign key to the Blogs table

        public virtual Blog Blog { get; set; } // Navigation property to Blog
    }
}
