using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnePlusCalorie.DAL.Migrations
{
    public partial class Seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kalori",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Kalori = table.Column<int>(type: "int", nullable: false),
                    BesinGrami = table.Column<int>(type: "int", nullable: false),
                    BesinID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kalori", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kalori_Besinler_BesinID",
                        column: x => x.BesinID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kalori_BesinID",
                table: "Kalori",
                column: "BesinID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kalori");
        }
    }
}
