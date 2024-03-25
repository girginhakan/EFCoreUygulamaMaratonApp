using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFPlakApp.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albumler_Sanatcilar_SanatciId",
                table: "Albumler");

            migrationBuilder.AlterColumn<int>(
                name: "SanatciId",
                table: "Albumler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Sanatcilar",
                columns: new[] { "Id", "SanatciAdi", "SanatciSoyadi" },
                values: new object[,]
                {
                    { 1, "Hakan", "Grgn" },
                    { 2, "Hivda", "Krhn" },
                    { 3, "Burak", "Gnc" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Albumler_Sanatcilar_SanatciId",
                table: "Albumler",
                column: "SanatciId",
                principalTable: "Sanatcilar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albumler_Sanatcilar_SanatciId",
                table: "Albumler");

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "SanatciId",
                table: "Albumler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Albumler_Sanatcilar_SanatciId",
                table: "Albumler",
                column: "SanatciId",
                principalTable: "Sanatcilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
