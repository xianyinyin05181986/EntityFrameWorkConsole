using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EntityFrameWorkConsoleApp
{
    public class BloggingContext : DbContext 
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Most model configuration can be done using simple data annotations. 
        /// The fluent API is a more advanced way of specifying model configuration
        /// that covers everything that data annotations can do in addition to 
        /// some more advanced configuration not possible with data annotations.
        /// Data annotations and the fluent API can be used together.
        /// 
        /// To access the fluent API you override the OnModelCreating method in DbContext.
        /// Let’s say we wanted to rename the column that User.
        /// DisplayName is stored in to display_name.
        /// Override the OnModelCreating method on BloggingContext with the following code
        /// 
        /// Use the Add-Migration ChangeDisplayName command to scaffold a migration to apply these changes to the database.
        /// Run the Update-Database command to apply the new migration to the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("display_name");
        } 

    }


}
