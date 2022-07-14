namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_genretbl : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres  (GenreId,Name)  values (1,'Action')");
            Sql("Insert into Genres (GenreId,Name) values (2,'Adventure')");
            Sql("Insert into Genres (GenreId,Name) values (3,'Thriller')");
            Sql("Insert into Genres (GenreId,Name) values (4,'Suspence')");
            Sql("Insert into Genres (GenreId,Name) values (5,'Horror')");
            Sql("Insert into Genres (GenreId,Name) values (6,'Drama')");
            Sql("Insert into Genres (GenreId,Name) values (7,'Animated')");
            Sql("Insert into Genres (GenreId,Name) values (8,'Feel Good')");
            Sql("Insert into Genres (GenreId,Name) values (9,'Fiction')");
            Sql("Insert into Genres (GenreId,Name) values (10,'Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
