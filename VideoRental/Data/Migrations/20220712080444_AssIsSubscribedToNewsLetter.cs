using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoRental.Migrations
{
    public partial class AssIsSubscribedToNewsLetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubbscribedToNewsletter",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubbscribedToNewsletter",
                table: "Customers");
        }
    }
}
