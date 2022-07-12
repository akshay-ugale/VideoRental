using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoRental.Migrations
{
    public partial class addedRecordsinMemrshipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"update MembershipType SET Name='Pay per Usage' where Id=1");
            migrationBuilder.Sql(@"update MembershipType SET Name='Montly Member' where Id=2");
            migrationBuilder.Sql(@"update MembershipType SET Name='Quarterly Member' where Id=3");
            migrationBuilder.Sql(@"update MembershipType SET Name='Yearly Member' where Id=4");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
