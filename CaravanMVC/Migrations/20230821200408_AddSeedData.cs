using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaravanMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "wagons",
                columns: new[] { "id", "covered", "name", "num_wheels" },
                values: new object[,]
                {
                    { 1, true, "Old Faithful", 4 },
                    { 2, false, "New Model Wagon", 2 }
                });

            migrationBuilder.InsertData(
                table: "passengers",
                columns: new[] { "id", "age", "destination", "name", "wagon_id" },
                values: new object[,]
                {
                    { 1, 34, "Oregon", "Prudence", 1 },
                    { 2, 36, "Oregon", "John", 1 },
                    { 3, 15, "Oregon", "Abigail", 1 },
                    { 4, 6, "Oregon", "John jr", 1 },
                    { 5, 24, "Canada", "Seth", 2 },
                    { 6, 24, "Canada", "Joe", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "wagons",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "wagons",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
