using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlakDukkaniYoneticisiModulu.UI.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SifreHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SanatciGrup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IndirimOrani = table.Column<int>(type: "int", nullable: true),
                    SatisDevamEdiyorMu = table.Column<bool>(type: "bit", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albumler_Adminler_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Adminler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adminler_KullaniciAdi",
                table: "Adminler",
                column: "KullaniciAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albumler_AdminId",
                table: "Albumler",
                column: "AdminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albumler");

            migrationBuilder.DropTable(
                name: "Adminler");
        }
    }
}
