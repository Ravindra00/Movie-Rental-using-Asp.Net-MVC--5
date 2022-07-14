namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonth,DiscountRate) values (1,0,0,0)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonth,DiscountRate) values (2,30,3,10)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonth,DiscountRate) values (3,90,6,15)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonth,DiscountRate) values (4,110,12,2 0)");
        }
        
        public override void Down()
        {
        }
    }
}
