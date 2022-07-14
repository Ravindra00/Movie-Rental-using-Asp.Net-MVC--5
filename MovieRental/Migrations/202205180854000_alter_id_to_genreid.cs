namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter_id_to_genreid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Genres");
            AddColumn("dbo.Genres", "GenreId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "GenreId");
            DropColumn("dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Genres");
            DropColumn("dbo.Genres", "GenreId");
            AddPrimaryKey("dbo.Genres", "Id");
        }
    }
}
