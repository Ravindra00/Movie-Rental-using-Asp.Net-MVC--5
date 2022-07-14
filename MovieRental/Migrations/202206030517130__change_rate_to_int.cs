namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _change_rate_to_int : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Rate", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rate", c => c.Int(nullable: true));
        }
    }
}
