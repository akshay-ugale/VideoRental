using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoRental.Migrations
{
    public partial class Ex2RecordsMoviesMVCV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Insert into Genre values ('Comedy')");
            migrationBuilder.Sql(@"Insert into Genre values ('Thriller')");
            migrationBuilder.Sql(@"Insert into Genre values ('Horror')");
            migrationBuilder.Sql(@"Insert into Genre values ('Sci-Fi')");


            migrationBuilder.Sql(@"Insert into Movies (Name,DateAdded,GenreId,ReleaseDate,stocks) values ('Thor','2019-10-23',2,'1997-12-12',101)");
            migrationBuilder.Sql(@"Insert into Movies (Name,DateAdded,GenreId,ReleaseDate,stocks) values ('Hulk','2019-10-23',1,'1997-12-12',101)");
            migrationBuilder.Sql(@"Insert into Movies (Name,DateAdded,GenreId,ReleaseDate,stocks) values ('Gear','2019-10-23',3,'1997-12-12',101)");
            migrationBuilder.Sql(@"Insert into Movies (Name,DateAdded,GenreId,ReleaseDate,stocks) values ('Blow','2019-10-23',4,'1997-12-12',101)");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
