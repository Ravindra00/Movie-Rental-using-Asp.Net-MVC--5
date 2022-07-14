namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _rate_added_to_rental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "Rate", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "Rate");
        }
    }
}
