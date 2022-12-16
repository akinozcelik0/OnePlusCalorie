using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnePlusCalorie.DAL.Migrations
{
    public partial class Ninth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kalori_Besinler_BesinID",
                table: "Kalori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kalori",
                table: "Kalori");

            migrationBuilder.RenameTable(
                name: "Kalori",
                newName: "Kaloriler");

            migrationBuilder.RenameIndex(
                name: "IX_Kalori_BesinID",
                table: "Kaloriler",
                newName: "IX_Kaloriler_BesinID");

            migrationBuilder.AddColumn<string>(
                name: "HamilelikDurumu",
                table: "ProfilBilgileri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilResmi",
                table: "ProfilBilgileri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kaloriler",
                table: "Kaloriler",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kaloriler_Besinler_BesinID",
                table: "Kaloriler",
                column: "BesinID",
                principalTable: "Besinler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kaloriler_Besinler_BesinID",
                table: "Kaloriler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kaloriler",
                table: "Kaloriler");

            migrationBuilder.DropColumn(
                name: "HamilelikDurumu",
                table: "ProfilBilgileri");

            migrationBuilder.DropColumn(
                name: "ProfilResmi",
                table: "ProfilBilgileri");

            migrationBuilder.RenameTable(
                name: "Kaloriler",
                newName: "Kalori");

            migrationBuilder.RenameIndex(
                name: "IX_Kaloriler_BesinID",
                table: "Kalori",
                newName: "IX_Kalori_BesinID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kalori",
                table: "Kalori",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kalori_Besinler_BesinID",
                table: "Kalori",
                column: "BesinID",
                principalTable: "Besinler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
