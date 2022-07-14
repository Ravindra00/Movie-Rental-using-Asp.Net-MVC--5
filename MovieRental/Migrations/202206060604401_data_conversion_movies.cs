namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data_conversion_movies : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Rate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rate", c => c.Single(nullable: false));
        }
    }
}
