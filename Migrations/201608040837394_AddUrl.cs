namespace EntityFrameWorkConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    /// <summary>
    /// Run the Add-Migration AddUrl command in Package Manager Console.
    /// The Add-Migration command checks for changes since your last migration and
    /// scaffolds a new migration with any changes that are found. 
    /// We can give migrations a name; in this case we are calling the migration ‘AddUrl’.
    /// The scaffolded code is saying that we need to add a Url column, 
    /// that can hold string data, to the dbo.Blogs table. 
    /// If needed, we could edit the scaffolded code but that’s not required in this case.
    /// </summary>
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Url");
        }
    }
}
