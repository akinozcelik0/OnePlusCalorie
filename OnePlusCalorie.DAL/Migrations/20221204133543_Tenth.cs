using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnePlusCalorie.DAL.Migrations
{
    public partial class Tenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgunZamanlari");

            migrationBuilder.DropColumn(
                name: "BesinAltiID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinBesID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinBirID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinDokuzID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinDortID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinIkiID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinOnID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinSekizID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinUcID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "BesinYediID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "ToplamGram",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "ToplamKalori",
                table: "OgunDetaylar");

            migrationBuilder.AddColumn<int>(
                name: "BesinID",
                table: "OgunDetaylar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EklenmeZamani",
                table: "OgunDetaylar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OgunAdi",
                table: "OgunDetaylar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BesinID",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "EklenmeZamani",
                table: "OgunDetaylar");

            migrationBuilder.DropColumn(
                name: "OgunAdi",
                table: "OgunDetaylar");

            migrationBuilder.AddColumn<int>(
                name: "BesinAltiID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinBesID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinBirID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinDokuzID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinDortID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinIkiID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinOnID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinSekizID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinUcID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BesinYediID",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToplamGram",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToplamKalori",
                table: "OgunDetaylar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OgunZamanlari",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    EklenmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OgunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunZamanlari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OgunZamanlari_OgunDetaylar_OgunID",
                        column: x => x.OgunID,
                        principalTable: "OgunDetaylar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgunZamanlari_OgunID",
                table: "OgunZamanlari",
                column: "OgunID",
                unique: true);
        }
    }
}
