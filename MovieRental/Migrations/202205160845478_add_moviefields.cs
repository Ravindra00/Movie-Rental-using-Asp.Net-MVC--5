namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_moviefields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Movies", "ReleasedDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "ReleasedDate");
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
