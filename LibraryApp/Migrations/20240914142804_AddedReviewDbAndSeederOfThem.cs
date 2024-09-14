using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedReviewDbAndSeederOfThem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ReviewContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Rating", "ReviewContent", "ReviewerName" },
                values: new object[,]
                {
                    { 1, 1, 3, "Książka mi się podoba, ale jakoś nie super", "Wiesiek" },
                    { 2, 1, 4, "Mi tam się to podobało, całkiem przyjemne", "Wiesia" },
                    { 3, 2, 5, "Piękna książka, wprowadza w magiczny klimat", "Kasia" },
                    { 4, 2, 3, "Trochę nużąca, ale zakończenie rewelacyjne", "Andrzej" },
                    { 5, 3, 5, "Leń to mój ulubiony bohater! Świetna bajka", "Bartek" },
                    { 6, 3, 4, "Dzieci uwielbiają, ale ja jako rodzic trochę się nudziłem", "Monika" },
                    { 7, 4, 3, "Rymowanka wpada w ucho, ale fabuła mogłaby być lepsza", "Łukasz" },
                    { 8, 4, 5, "Cudownie się czytało, Bergamuty to moje marzenie", "Alicja" },
                    { 9, 5, 5, "Głęboki i przemyślany wiersz, Szymborska jak zawsze świetna", "Anna" },
                    { 10, 5, 4, "Nic dwa razy – coś w tym jest, polecam każdemu", "Jan" },
                    { 11, 6, 5, "Solaris to klasyk! Czasem zawiła, ale bardzo wartościowa", "Piotr" },
                    { 12, 6, 3, "Niektóre fragmenty trudne do zrozumienia, ale ogólnie OK", "Marcin" },
                    { 13, 7, 5, "Erynie to mocna powieść, wciągnęła mnie od pierwszych stron", "Karol" },
                    { 14, 7, 4, "Mroczna atmosfera, nie dla każdego, ale mi się podobało", "Zofia" },
                    { 15, 8, 5, "Śmierć w Breslau to świetny kryminał, pełen zwrotów akcji", "Robert" },
                    { 16, 8, 3, "Dobrze napisane, choć momentami przewidywalne", "Marta" },
                    { 17, 4, 5, "Zabawna i lekka, świetna na relaks", "Paweł" },
                    { 18, 2, 4, "Sobótka ma w sobie coś magicznego, polecam", "Agnieszka" },
                    { 19, 3, 5, "Leń to idealna książka na wieczorne czytanie z dziećmi", "Tomek" },
                    { 20, 6, 3, "Solaris jest dla mnie zbyt trudne, ale doceniam pomysł", "Ewa" },
                    { 21, 1, 3, "Niezbyt wciągająca, ale cenię klasykę", "Adam" },
                    { 22, 1, 4, "Zdecydowanie warta przeczytania, mimo że trochę krótka", "Ewelina" },
                    { 23, 1, 2, "Nie do końca rozumiem przesłanie", "Tomasz" },
                    { 24, 1, 4, "Podobało mi się podejście do tematu zdrowia", "Julia" },
                    { 25, 1, 5, "Lekka i przyjemna lektura na wieczór", "Ola" },
                    { 26, 2, 5, "Wspaniała atmosfera, bardzo klimatyczna książka", "Kinga" },
                    { 27, 2, 5, "Magia Sobótki jest nie do opisania", "Michał" },
                    { 28, 2, 3, "Ciekawe, ale momentami zbyt rozwlekłe", "Grzegorz" },
                    { 29, 2, 4, "Bardzo mi się podobała, choć końcówka mogłaby być lepsza", "Patrycja" },
                    { 30, 2, 5, "Arcydzieło w swoim rodzaju", "Barbara" },
                    { 31, 3, 5, "Moje dzieci uwielbiają tę książkę, śmiejemy się za każdym razem", "Katarzyna" },
                    { 32, 3, 4, "Świetna zabawa dla najmłodszych, dużo humoru", "Artur" },
                    { 33, 3, 3, "Sympatyczna bajka, ale bez większych rewelacji", "Paweł" },
                    { 34, 3, 5, "Prosta i urocza historia o leniu, który nic nie robi", "Natalia" },
                    { 35, 3, 3, "Przyjemna, ale szybko się nudzi", "Robert" },
                    { 36, 4, 5, "Fantastyczna podróż do wysp, których nie ma!", "Piotr" },
                    { 37, 4, 4, "Idealna na relaks, pełna rymowanek i zabawy", "Karolina" },
                    { 38, 4, 3, "Trochę przesadzona, ale dzieciom się spodobała", "Magdalena" },
                    { 39, 4, 5, "Klasyka polskiej literatury dla dzieci, bez wątpienia", "Dawid" },
                    { 40, 4, 3, "Dla mnie zbyt dziecinna, ale dla maluchów super", "Anna" },
                    { 41, 5, 5, "Wspaniały wiersz, poruszający do głębi", "Marta" },
                    { 42, 5, 5, "Każde słowo ma swoje miejsce, nic dodać, nic ująć", "Aleksander" },
                    { 43, 5, 4, "Trochę melancholijny, ale piękny", "Dorota" },
                    { 44, 5, 5, "Chwytający za serce, zawsze mnie porusza", "Ewa" },
                    { 45, 5, 5, "Zawsze wracam do tego wiersza, jest wyjątkowy", "Jacek" },
                    { 46, 6, 5, "Złożona, ale genialna powieść, klasyk science fiction", "Łukasz" },
                    { 47, 6, 4, "Niesamowite opisy świata, choć fabuła niełatwa", "Mateusz" },
                    { 48, 6, 4, "Solaris jest niezwykła, ale trzeba się wczytać", "Iwona" },
                    { 49, 6, 5, "Dla fanów Lema to lektura obowiązkowa", "Bartek" },
                    { 50, 6, 5, "Zaskakująca i oryginalna, nie da się zapomnieć", "Joanna" },
                    { 51, 7, 5, "Świetny kryminał, Krajewski to mistrz", "Dominik" },
                    { 52, 7, 5, "Atmosfera Lwowa wciąga, mroczna i niepokojąca", "Zuzanna" },
                    { 53, 7, 3, "Dobrze napisane, choć momentami przewidywalne", "Kamil" },
                    { 54, 7, 4, "Nie dla każdego, ale mi się podobało", "Emilia" },
                    { 55, 7, 5, "Trzyma w napięciu od początku do końca", "Marek" },
                    { 56, 8, 5, "Rewelacyjny kryminał, pełen zwrotów akcji", "Natalia" },
                    { 57, 8, 5, "Zaskakujący, mroczny i wciągający", "Daniel" },
                    { 58, 8, 5, "Czytałem jednym tchem, trudno się oderwać", "Artur" },
                    { 59, 8, 4, "Styl autora trochę zbyt ciężki, ale fabuła świetna", "Kasia" },
                    { 60, 8, 5, "Uwielbiam takie klimaty, Breslau ma niesamowity urok", "Tomasz" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfLoan",
                value: new DateTime(2024, 9, 12, 20, 56, 18, 333, DateTimeKind.Local).AddTicks(7933));
        }
    }
}
