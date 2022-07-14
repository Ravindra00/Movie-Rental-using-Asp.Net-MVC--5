namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _add_rental_tbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        RentalId = c.Int(nullable: false, identity: true),
                        RentedDate = c.DateTime(nullable: false),
                        ReturnedDate = c.DateTime(),
                        Customer_Id = c.Int(),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.RentalId)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Movies", t => t.Movie_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropTable("dbo.Rentals");
        }
    }
}
