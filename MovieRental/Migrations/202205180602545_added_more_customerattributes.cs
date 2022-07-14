namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_more_customerattributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Phone");
            DropColumn("dbo.Customers", "Email");
        }
    }
}
