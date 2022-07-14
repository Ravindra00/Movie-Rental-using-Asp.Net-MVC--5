namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_genre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres  values ('Action')");
            Sql("Insert into Genres  values ('Adventure')");
            Sql("Insert into Genres  values ('Thriller')");
            Sql("Insert into Genres  values ('Suspence')");
            Sql("Insert into Genres  values ('Horror')");
            Sql("Insert into Genres  values ('Drama')");
            Sql("Insert into Genres  values ('Animated')");
            Sql("Insert into Genres  values ('Feel Good')");
            Sql("Insert into Genres  values ('Fiction')");
            Sql("Insert into Genres  values ('Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
