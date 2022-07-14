namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _added_rate_to_movie_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rate", c => c.Single(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rate");
        }
    }
}
