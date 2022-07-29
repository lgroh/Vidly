namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Harry Potter', 02/03/2002, 02/03/2022, 100, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('First Wives Club', 02/05/2002, 02/05/2022, 10, 5)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Fried Green Tomatoes', 04/08/2002, 04/10/2022, 19, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Hocus Pocus', 08/03/2002, 04/19/2022, 13, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
