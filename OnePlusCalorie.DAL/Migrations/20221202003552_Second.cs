using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnePlusCalorie.DAL.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Besinler_BesinKategorileri_BesininKategorisiID",
                table: "Besinler");

            migrationBuilder.DropIndex(
                name: "IX_Besinler_BesininKategorisiID",
                table: "Besinler");

            migrationBuilder.DropColumn(
                name: "BesininKategorisiID",
                table: "Besinler");

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_KategoriID",
                table: "Besinler",
                column: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Besinler_BesinKategorileri_KategoriID",
                table: "Besinler",
                column: "KategoriID",
                principalTable: "BesinKategorileri",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Besinler_BesinKategorileri_KategoriID",
                table: "Besinler");

            migrationBuilder.DropIndex(
                name: "IX_Besinler_KategoriID",
                table: "Besinler");

            migrationBuilder.AddColumn<int>(
                name: "BesininKategorisiID",
                table: "Besinler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_BesininKategorisiID",
                table: "Besinler",
                column: "BesininKategorisiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Besinler_BesinKategorileri_BesininKategorisiID",
                table: "Besinler",
                column: "BesininKategorisiID",
                principalTable: "BesinKategorileri",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
