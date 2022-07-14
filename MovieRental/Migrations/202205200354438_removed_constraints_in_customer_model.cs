namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removed_constraints_in_customer_model : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Customers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
