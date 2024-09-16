using LibraryApp.Enums;

namespace LibraryApp.Entities
{
    public class BookCopy
    {
        public int Id { get; set; }
        public string EAN { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public bool IsAvailable { get; set; }
        public BookStatus Status { get; set; }
        public string? RepairComment { get; set; }
        ICollection<Rental> Rentals { get; set; }
    }
}
