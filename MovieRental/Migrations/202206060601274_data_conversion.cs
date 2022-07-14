namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data_conversion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "Rate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "Rate", c => c.Single(nullable: false));
        }
    }
}
