using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnePlusCalorie.DAL.Migrations
{
    public partial class Twelth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OgunID",
                table: "BesinOgunTablosu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgunID",
                table: "BesinOgunTablosu",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
