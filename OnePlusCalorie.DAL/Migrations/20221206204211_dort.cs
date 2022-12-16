using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnePlusCalorie.DAL.Migrations
{
    public partial class dort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfilOgunTablolari",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfillerID = table.Column<int>(type: "int", nullable: false),
                    OgunDetaylariID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilOgunTablolari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProfilOgunTablolari_OgunDetaylar_OgunDetaylariID",
                        column: x => x.OgunDetaylariID,
                        principalTable: "OgunDetaylar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfilOgunTablolari_ProfilBilgileri_ProfillerID",
                        column: x => x.ProfillerID,
                        principalTable: "ProfilBilgileri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfilOgunTablolari_OgunDetaylariID",
                table: "ProfilOgunTablolari",
                column: "OgunDetaylariID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilOgunTablolari_ProfillerID",
                table: "ProfilOgunTablolari",
                column: "ProfillerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfilOgunTablolari");
        }
    }
}
