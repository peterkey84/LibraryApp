using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class MakeDateOfReturnFromRentalTableNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfReturn",
                table: "Rentals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 15, 13, 14, 52, 891, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 15, 13, 14, 52, 891, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 15, 13, 14, 52, 891, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 15, 13, 14, 52, 891, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 15, 13, 14, 52, 891, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 15, 13, 14, 52, 891, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 15, 13, 14, 52, 891, DateTimeKind.Local).AddTicks(2134));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfReturn",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 14, 16, 28, 4, 348, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 14, 16, 28, 4, 348, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 14, 16, 28, 4, 348, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 14, 16, 28, 4, 348, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 14, 16, 28, 4, 348, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 14, 16, 28, 4, 348, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 14, 16, 28, 4, 348, DateTimeKind.Local).AddTicks(5544));
        }
    }
}
