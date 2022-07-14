namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rate_modified_to_float : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Rate", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rate", c => c.Int(nullable: false));
        }
    }
}
