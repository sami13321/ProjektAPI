using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilfabrik.Migrations
{
    public partial class igen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Namn",
                table: "Montörer",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Namn",
                table: "Montörer");
        }
    }
}
