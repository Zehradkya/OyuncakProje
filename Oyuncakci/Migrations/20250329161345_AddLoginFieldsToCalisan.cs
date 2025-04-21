using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oyuncakci.Migrations
{
    /// <inheritdoc />
    public partial class AddLoginFieldsToCalisan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KullaniciAdi",
                table: "Calisanlar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SifreHash",
                table: "Calisanlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KullaniciAdi",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "SifreHash",
                table: "Calisanlar");
        }
    }
}
