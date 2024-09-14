using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.EntitiesConfiguration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {

            builder.HasData(

                new Review { Id = 1, BookId = 1, ReviewContent = "Książka mi się podoba, ale jakoś nie super", Rating = 3, ReviewerName = "Wiesiek" },
                new Review { Id = 2, BookId = 1, ReviewContent = "Mi tam się to podobało, całkiem przyjemne", Rating = 4, ReviewerName = "Wiesia" },
                new Review { Id = 3, BookId = 2, ReviewContent = "Piękna książka, wprowadza w magiczny klimat", Rating = 5, ReviewerName = "Kasia" },
                new Review { Id = 4, BookId = 2, ReviewContent = "Trochę nużąca, ale zakończenie rewelacyjne", Rating = 3, ReviewerName = "Andrzej" },
                new Review { Id = 5, BookId = 3, ReviewContent = "Leń to mój ulubiony bohater! Świetna bajka", Rating = 5, ReviewerName = "Bartek" },
                new Review { Id = 6, BookId = 3, ReviewContent = "Dzieci uwielbiają, ale ja jako rodzic trochę się nudziłem", Rating = 4, ReviewerName = "Monika" },
                new Review { Id = 7, BookId = 4, ReviewContent = "Rymowanka wpada w ucho, ale fabuła mogłaby być lepsza", Rating = 3, ReviewerName = "Łukasz" },
                new Review { Id = 8, BookId = 4, ReviewContent = "Cudownie się czytało, Bergamuty to moje marzenie", Rating = 5, ReviewerName = "Alicja" },
                new Review { Id = 9, BookId = 5, ReviewContent = "Głęboki i przemyślany wiersz, Szymborska jak zawsze świetna", Rating = 5, ReviewerName = "Anna" },
                new Review { Id = 10, BookId = 5, ReviewContent = "Nic dwa razy – coś w tym jest, polecam każdemu", Rating = 4, ReviewerName = "Jan" },
                new Review { Id = 11, BookId = 6, ReviewContent = "Solaris to klasyk! Czasem zawiła, ale bardzo wartościowa", Rating = 5, ReviewerName = "Piotr" },
                new Review { Id = 12, BookId = 6, ReviewContent = "Niektóre fragmenty trudne do zrozumienia, ale ogólnie OK", Rating = 3, ReviewerName = "Marcin" },
                new Review { Id = 13, BookId = 7, ReviewContent = "Erynie to mocna powieść, wciągnęła mnie od pierwszych stron", Rating = 5, ReviewerName = "Karol" },
                new Review { Id = 14, BookId = 7, ReviewContent = "Mroczna atmosfera, nie dla każdego, ale mi się podobało", Rating = 4, ReviewerName = "Zofia" },
                new Review { Id = 15, BookId = 8, ReviewContent = "Śmierć w Breslau to świetny kryminał, pełen zwrotów akcji", Rating = 5, ReviewerName = "Robert" },
                new Review { Id = 16, BookId = 8, ReviewContent = "Dobrze napisane, choć momentami przewidywalne", Rating = 3, ReviewerName = "Marta" },
                new Review { Id = 17, BookId = 4, ReviewContent = "Zabawna i lekka, świetna na relaks", Rating = 5, ReviewerName = "Paweł" },
                new Review { Id = 18, BookId = 2, ReviewContent = "Sobótka ma w sobie coś magicznego, polecam", Rating = 4, ReviewerName = "Agnieszka" },
                new Review { Id = 19, BookId = 3, ReviewContent = "Leń to idealna książka na wieczorne czytanie z dziećmi", Rating = 5, ReviewerName = "Tomek" },
                new Review { Id = 20, BookId = 6, ReviewContent = "Solaris jest dla mnie zbyt trudne, ale doceniam pomysł", Rating = 3, ReviewerName = "Ewa" },
                new Review { Id = 21, BookId = 1, ReviewContent = "Niezbyt wciągająca, ale cenię klasykę", Rating = 3, ReviewerName = "Adam" },
new Review { Id = 22, BookId = 1, ReviewContent = "Zdecydowanie warta przeczytania, mimo że trochę krótka", Rating = 4, ReviewerName = "Ewelina" },
new Review { Id = 23, BookId = 1, ReviewContent = "Nie do końca rozumiem przesłanie", Rating = 2, ReviewerName = "Tomasz" },
new Review { Id = 24, BookId = 1, ReviewContent = "Podobało mi się podejście do tematu zdrowia", Rating = 4, ReviewerName = "Julia" },
new Review { Id = 25, BookId = 1, ReviewContent = "Lekka i przyjemna lektura na wieczór", Rating = 5, ReviewerName = "Ola" },
new Review { Id = 26, BookId = 2, ReviewContent = "Wspaniała atmosfera, bardzo klimatyczna książka", Rating = 5, ReviewerName = "Kinga" },
new Review { Id = 27, BookId = 2, ReviewContent = "Magia Sobótki jest nie do opisania", Rating = 5, ReviewerName = "Michał" },
new Review { Id = 28, BookId = 2, ReviewContent = "Ciekawe, ale momentami zbyt rozwlekłe", Rating = 3, ReviewerName = "Grzegorz" },
new Review { Id = 29, BookId = 2, ReviewContent = "Bardzo mi się podobała, choć końcówka mogłaby być lepsza", Rating = 4, ReviewerName = "Patrycja" },
new Review { Id = 30, BookId = 2, ReviewContent = "Arcydzieło w swoim rodzaju", Rating = 5, ReviewerName = "Barbara" },
new Review { Id = 31, BookId = 3, ReviewContent = "Moje dzieci uwielbiają tę książkę, śmiejemy się za każdym razem", Rating = 5, ReviewerName = "Katarzyna" },
new Review { Id = 32, BookId = 3, ReviewContent = "Świetna zabawa dla najmłodszych, dużo humoru", Rating = 4, ReviewerName = "Artur" },
new Review { Id = 33, BookId = 3, ReviewContent = "Sympatyczna bajka, ale bez większych rewelacji", Rating = 3, ReviewerName = "Paweł" },
new Review { Id = 34, BookId = 3, ReviewContent = "Prosta i urocza historia o leniu, który nic nie robi", Rating = 5, ReviewerName = "Natalia" },
new Review { Id = 35, BookId = 3, ReviewContent = "Przyjemna, ale szybko się nudzi", Rating = 3, ReviewerName = "Robert" },
new Review { Id = 36, BookId = 4, ReviewContent = "Fantastyczna podróż do wysp, których nie ma!", Rating = 5, ReviewerName = "Piotr" },
new Review { Id = 37, BookId = 4, ReviewContent = "Idealna na relaks, pełna rymowanek i zabawy", Rating = 4, ReviewerName = "Karolina" },
new Review { Id = 38, BookId = 4, ReviewContent = "Trochę przesadzona, ale dzieciom się spodobała", Rating = 3, ReviewerName = "Magdalena" },
new Review { Id = 39, BookId = 4, ReviewContent = "Klasyka polskiej literatury dla dzieci, bez wątpienia", Rating = 5, ReviewerName = "Dawid" },
new Review { Id = 40, BookId = 4, ReviewContent = "Dla mnie zbyt dziecinna, ale dla maluchów super", Rating = 3, ReviewerName = "Anna" },
new Review { Id = 41, BookId = 5, ReviewContent = "Wspaniały wiersz, poruszający do głębi", Rating = 5, ReviewerName = "Marta" },
new Review { Id = 42, BookId = 5, ReviewContent = "Każde słowo ma swoje miejsce, nic dodać, nic ująć", Rating = 5, ReviewerName = "Aleksander" },
new Review { Id = 43, BookId = 5, ReviewContent = "Trochę melancholijny, ale piękny", Rating = 4, ReviewerName = "Dorota" },
new Review { Id = 44, BookId = 5, ReviewContent = "Chwytający za serce, zawsze mnie porusza", Rating = 5, ReviewerName = "Ewa" },
new Review { Id = 45, BookId = 5, ReviewContent = "Zawsze wracam do tego wiersza, jest wyjątkowy", Rating = 5, ReviewerName = "Jacek" },
new Review { Id = 46, BookId = 6, ReviewContent = "Złożona, ale genialna powieść, klasyk science fiction", Rating = 5, ReviewerName = "Łukasz" },
new Review { Id = 47, BookId = 6, ReviewContent = "Niesamowite opisy świata, choć fabuła niełatwa", Rating = 4, ReviewerName = "Mateusz" },
new Review { Id = 48, BookId = 6, ReviewContent = "Solaris jest niezwykła, ale trzeba się wczytać", Rating = 4, ReviewerName = "Iwona" },
new Review { Id = 49, BookId = 6, ReviewContent = "Dla fanów Lema to lektura obowiązkowa", Rating = 5, ReviewerName = "Bartek" },
new Review { Id = 50, BookId = 6, ReviewContent = "Zaskakująca i oryginalna, nie da się zapomnieć", Rating = 5, ReviewerName = "Joanna" },
new Review { Id = 51, BookId = 7, ReviewContent = "Świetny kryminał, Krajewski to mistrz", Rating = 5, ReviewerName = "Dominik" },
new Review { Id = 52, BookId = 7, ReviewContent = "Atmosfera Lwowa wciąga, mroczna i niepokojąca", Rating = 5, ReviewerName = "Zuzanna" },
new Review { Id = 53, BookId = 7, ReviewContent = "Dobrze napisane, choć momentami przewidywalne", Rating = 3, ReviewerName = "Kamil" },
new Review { Id = 54, BookId = 7, ReviewContent = "Nie dla każdego, ale mi się podobało", Rating = 4, ReviewerName = "Emilia" },
new Review { Id = 55, BookId = 7, ReviewContent = "Trzyma w napięciu od początku do końca", Rating = 5, ReviewerName = "Marek" },
new Review { Id = 56, BookId = 8, ReviewContent = "Rewelacyjny kryminał, pełen zwrotów akcji", Rating = 5, ReviewerName = "Natalia" },
new Review { Id = 57, BookId = 8, ReviewContent = "Zaskakujący, mroczny i wciągający", Rating = 5, ReviewerName = "Daniel" },
new Review { Id = 58, BookId = 8, ReviewContent = "Czytałem jednym tchem, trudno się oderwać", Rating = 5, ReviewerName = "Artur" },
new Review { Id = 59, BookId = 8, ReviewContent = "Styl autora trochę zbyt ciężki, ale fabuła świetna", Rating = 4, ReviewerName = "Kasia" },
new Review { Id = 60, BookId = 8, ReviewContent = "Uwielbiam takie klimaty, Breslau ma niesamowity urok", Rating = 5, ReviewerName = "Tomasz" }

                );

        }
    }
}
