using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoRental.Migrations
{
    public partial class addrecordsBirthdateToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"update Customers SET BirthDate='1997-11-12' where Id=1");
            migrationBuilder.Sql(@"update Customers SET BirthDate='1990-11-12' where Id=3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
