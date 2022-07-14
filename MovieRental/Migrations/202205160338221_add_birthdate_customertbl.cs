namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_birthdate_customertbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
