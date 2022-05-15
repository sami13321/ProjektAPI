using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilfabrik.Migrations
{
    public partial class @out : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OutTimestamp",
                table: "Stämpel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OutTimestamp",
                table: "Stämpel");
        }
    }
}
