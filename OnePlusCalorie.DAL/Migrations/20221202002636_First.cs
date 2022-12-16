using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnePlusCalorie.DAL.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdminSifre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BesinKategorileri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinKategorileri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyelikTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OgunDetaylar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BesinBirID = table.Column<int>(type: "int", nullable: false),
                    BesinIkiID = table.Column<int>(type: "int", nullable: false),
                    BesinUcID = table.Column<int>(type: "int", nullable: false),
                    BesinDortID = table.Column<int>(type: "int", nullable: false),
                    BesinBesID = table.Column<int>(type: "int", nullable: false),
                    BesinAltiID = table.Column<int>(type: "int", nullable: false),
                    BesinYediID = table.Column<int>(type: "int", nullable: false),
                    BesinSekizID = table.Column<int>(type: "int", nullable: false),
                    BesinDokuzID = table.Column<int>(type: "int", nullable: false),
                    BesinOnID = table.Column<int>(type: "int", nullable: false),
                    ToplamGram = table.Column<int>(type: "int", nullable: false),
                    ToplamKalori = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunDetaylar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Besinler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    BesininKategorisiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besinler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Besinler_BesinKategorileri_BesininKategorisiID",
                        column: x => x.BesininKategorisiID,
                        principalTable: "BesinKategorileri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfilBilgileri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    YasamTarzi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VucutKitleEndeksi = table.Column<double>(type: "float", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilBilgileri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProfilBilgileri_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgunZamanlari",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    EklenmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "BesinDegerleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Karbonhidrat = table.Column<int>(type: "int", nullable: false),
                    Yag = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<int>(type: "int", nullable: false),
                    Lif = table.Column<int>(type: "int", nullable: false),
                    Kolestrol = table.Column<int>(type: "int", nullable: false),
                    Sodyum = table.Column<int>(type: "int", nullable: false),
                    Potasyum = table.Column<int>(type: "int", nullable: false),
                    Kalsiyum = table.Column<int>(type: "int", nullable: false),
                    BesinID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinDegerleri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BesinDegerleri_Besinler_BesinID",
                        column: x => x.BesinID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BesinOgunTablosu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BesinID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    BesininOgunuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinOgunTablosu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BesinOgunTablosu_Besinler_BesinID",
                        column: x => x.BesinID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BesinOgunTablosu_OgunDetaylar_BesininOgunuID",
                        column: x => x.BesininOgunuID,
                        principalTable: "OgunDetaylar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adminler_AdminAdi",
                table: "Adminler",
                column: "AdminAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BesinDegerleri_BesinID",
                table: "BesinDegerleri",
                column: "BesinID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_BesininKategorisiID",
                table: "Besinler",
                column: "BesininKategorisiID");

            migrationBuilder.CreateIndex(
                name: "IX_BesinOgunTablosu_BesinID",
                table: "BesinOgunTablosu",
                column: "BesinID");

            migrationBuilder.CreateIndex(
                name: "IX_BesinOgunTablosu_BesininOgunuID",
                table: "BesinOgunTablosu",
                column: "BesininOgunuID");

            migrationBuilder.CreateIndex(
                name: "IX_OgunZamanlari_OgunID",
                table: "OgunZamanlari",
                column: "OgunID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfilBilgileri_KullaniciID",
                table: "ProfilBilgileri",
                column: "KullaniciID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminler");

            migrationBuilder.DropTable(
                name: "BesinDegerleri");

            migrationBuilder.DropTable(
                name: "BesinOgunTablosu");

            migrationBuilder.DropTable(
                name: "OgunZamanlari");

            migrationBuilder.DropTable(
                name: "ProfilBilgileri");

            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "OgunDetaylar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "BesinKategorileri");
        }
    }
}
