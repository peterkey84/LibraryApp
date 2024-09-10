using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1530, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Kochanowski" },
                    { 2, new DateTime(1898, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Brzechwa" },
                    { 3, new DateTime(1923, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wisława", "Szymborska" },
                    { 4, new DateTime(1921, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stanisław", "Lem" },
                    { 5, new DateTime(1966, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marek", "Krajweski" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "ContactNumber", "DateOfBirth", "Email", "FirstName", "LastName", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Gdańsk", "888333222", new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan@kowalksi.pl", "Jan", "Kowalski", "80-110", "Grunwaldzka" },
                    { 2, "Gdynia", "333444555", new DateTime(1994, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "pawel@kowalksi.pl", "Paweł", "Lelek", "81-110", "Grunwaldzka" },
                    { 3, "Sopot", "888111222", new DateTime(1974, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "piotr@kowalksi.pl", "Piotr", "Kaminski", "82-110", "Grunwaldzka" },
                    { 4, "Rumia", "888336666", new DateTime(1954, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan@sss.pl", "Wiesław", "XXX", "85-110", "Grunwaldzka" },
                    { 5, "Żukowo", "888333231", new DateTime(1934, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan@kfff.pl", "Olek", "Misztal", "86-110", "Grunwaldzka" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jest to fraszka napisana na zdrowie i dla zdrowia wszystkich", "Na zdrowie" },
                    { 2, 1, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jest to pieśń o Sobótce", "Pieśń świętojańska o Sobótce" },
                    { 3, 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bajka dla dzieci o leniu co nić nie robi cały dzień", "Leń" },
                    { 4, 2, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bardzo zabawna rymowanka o nieistniejących wyspach", "Na wyspach Bergamutach" },
                    { 5, 3, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Najpopularniejszym chyba wierszem", "Nic dwa razy się nie zdarza/ i nie zdarzy" },
                    { 6, 4, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "To najsłynniejsza powieść Stanisława Lema", "Solaris" },
                    { 7, 5, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zbiór opowiadań o komisarzu Popielskim", "Erynie" },
                    { 8, 5, new DateTime(1999, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zbiór opowiadań o komisarzu Mocku", "Śmierć w Breslau" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
