using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameWorkConsoleApp
{
    /// <summary>
    /// You’ll notice that we’re making the two navigation properties (Blog.Posts and Post.Blog) virtual. 
    /// This enables the Lazy Loading feature of Entity Framework. Lazy Loading means that the contents 
    /// of these properties will be automatically loaded from the database when you try to access them.
    /// </summary>
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; } 

    }
}
