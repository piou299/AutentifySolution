using Microsoft.EntityFrameworkCore.Migrations;

namespace AutentifyAPI.Migrations
{
    public partial class Pays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Indicatif",
                table: "Pays",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Pays",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Indicatif",
                table: "Pays");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Pays");
        }
    }
}
