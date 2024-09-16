using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookCoppyDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "BookCopies",
                newName: "Status");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "BookCopies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RepairComment",
                table: "BookCopies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsAvailable", "RepairComment", "Status" },
                values: new object[] { true, null, 0 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "IsAvailable", "RepairComment", "Status" },
                values: new object[] { 1, true, null, 0 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "IsAvailable", "RepairComment", "Status" },
                values: new object[] { 2, false, null, 1 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "IsAvailable", "RepairComment", "Status" },
                values: new object[] { 2, false, null, 1 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "IsAvailable", "RepairComment", "Status" },
                values: new object[] { 2, true, null, 0 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "IsAvailable", "RepairComment", "Status" },
                values: new object[] { 3, false, null, 1 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "IsAvailable", "RepairComment", "Status" },
                values: new object[] { 3, true, null, 0 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "IsAvailable", "RepairComment", "Status" },
                values: new object[] { 3, false, null, 1 });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "EAN", "IsAvailable", "RepairComment", "Status" },
                values: new object[] { 9, 3, "4006381333931", false, "Ksiązka z uszkodzoną okładką, do wymiany okładka przednia.", 2 });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 16, 20, 5, 53, 255, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 16, 20, 5, 53, 255, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 16, 20, 5, 53, 255, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 16, 20, 5, 53, 255, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 16, 20, 5, 53, 255, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 16, 20, 5, 53, 255, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 16, 20, 5, 53, 255, DateTimeKind.Local).AddTicks(412));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "BookCopies");

            migrationBuilder.DropColumn(
                name: "RepairComment",
                table: "BookCopies");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "BookCopies",
                newName: "Quantity");

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Quantity" },
                values: new object[] { 2, 50 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Quantity" },
                values: new object[] { 3, 510 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Quantity" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Quantity" },
                values: new object[] { 5, 100 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Quantity" },
                values: new object[] { 6, 320 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Quantity" },
                values: new object[] { 7, 99 });

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Quantity" },
                values: new object[] { 8, 111 });

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
    }
}
