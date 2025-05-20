using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlakDukkaniYoneticisiModulu.UI.Migrations
{
    /// <inheritdoc />
    public partial class m2_SeedDataAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Adminler",
                columns: new[] { "Id", "KullaniciAdi", "SifreHash" },
                values: new object[] { 1, "Admin", "6CEB6BFBF24566237485A49F21393D4FEF9B2940057FF396522C890C8D16DC86" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adminler",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
