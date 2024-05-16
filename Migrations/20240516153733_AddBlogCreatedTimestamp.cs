using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dijitalPano.Migrations
{
    /// <inheritdoc />
    public partial class AddBlogCreatedTimestamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NobetciOgrenciler",
                columns: table => new
                {
                    NobetciId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: true),
                    Soyad = table.Column<string>(type: "TEXT", nullable: true),
                    Sinif = table.Column<string>(type: "TEXT", nullable: true),
                    OkulNo = table.Column<string>(type: "TEXT", nullable: true),
                    NobetTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NobetciOgrenciler", x => x.NobetciId);
                });

            migrationBuilder.CreateTable(
                name: "NobetciOgretmenler",
                columns: table => new
                {
                    OgretmenId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OgretmenAd = table.Column<string>(type: "TEXT", nullable: true),
                    OgretmenSoyad = table.Column<string>(type: "TEXT", nullable: true),
                    Brans = table.Column<string>(type: "TEXT", nullable: true),
                    OgretmenNobetTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NobetciOgretmenler", x => x.OgretmenId);
                });

            migrationBuilder.CreateTable(
                name: "YemekTakibi",
                columns: table => new
                {
                    GunId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Menu = table.Column<string>(type: "TEXT", nullable: true),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekTakibi", x => x.GunId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NobetciOgrenciler");

            migrationBuilder.DropTable(
                name: "NobetciOgretmenler");

            migrationBuilder.DropTable(
                name: "YemekTakibi");
        }
    }
}
