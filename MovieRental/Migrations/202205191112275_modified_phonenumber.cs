namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modified_phonenumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
        }
    }
}
