namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_issubscribedtonewsletter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
        }
    }
}
