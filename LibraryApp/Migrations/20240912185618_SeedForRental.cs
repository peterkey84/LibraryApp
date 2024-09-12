using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedForRental : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "BookCopyId", "DateOfLoan", "DateOfReturn", "Fees", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7827), new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 1 },
                    { 2, 1, new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7922), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 2 },
                    { 3, 1, new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7924), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 3 },
                    { 4, 1, new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7926), new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 4 },
                    { 5, 1, new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7929), new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 5 },
                    { 6, 1, new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7931), new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 1 },
                    { 7, 1, new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7933), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
