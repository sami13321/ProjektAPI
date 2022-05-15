using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilfabrik.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id1",
                table: "Montörer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id1",
                table: "Montörer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
