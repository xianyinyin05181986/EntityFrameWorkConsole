using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameWorkConsoleApp
{
    /// <summary>
    /// You’ll notice that we’re making the two navigation properties (Blog.Posts and Post.Blog) virtual. 
    /// This enables the Lazy Loading feature of Entity Framework.
    /// Lazy Loading means that the contents of these properties will 
    /// be automatically loaded from the database when you try to access them.
    /// 
    /// 
    /// Dealing with Model Changes Tools -> Library Package Manager -> Package Manager Console
    ///                 Run the Enable-Migrations command in Package Manager Console
    ///                 
    /// Configuration.cs – This file contains the settings that Migrations will use for migrating BloggingContext.
    /// We don’t need to change anything for this walkthrough, but here is where you can specify seed data, 
    /// register providers for other databases, changes the namespace that migrations are generated in etc.
    /// 
    /// 
    /// </summary>
   public class Blog
    {
       public int BlogId { get; set; }
       public string Name { get; set; }
       public string Url { get; set; } 
       public virtual List<Post> Posts { get; set; }
    }

   
}
