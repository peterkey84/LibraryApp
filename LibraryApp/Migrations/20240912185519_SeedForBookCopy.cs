using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedForBookCopy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "EAN", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "5012345678900", 50 },
                    { 2, 2, "9780201379624", 50 },
                    { 3, 3, "8000500310429", 510 },
                    { 4, 4, "4029764001805", 10 },
                    { 5, 5, "3800029146455", 100 },
                    { 6, 6, "8710123456789", 320 },
                    { 7, 7, "5051234567894", 99 },
                    { 8, 8, "4006381333931", 111 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
