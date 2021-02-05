using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Landmark",
                table: "Outlets",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "No_of_AvaiFoodItems",
                table: "Outlets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderDate",
                table: "Outlets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Req_Volunteer",
                table: "Outlets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Outlets",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Landmark",
                table: "Outlets");

            migrationBuilder.DropColumn(
                name: "No_of_AvaiFoodItems",
                table: "Outlets");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Outlets");

            migrationBuilder.DropColumn(
                name: "Req_Volunteer",
                table: "Outlets");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Outlets");
        }
    }
}
