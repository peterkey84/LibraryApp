namespace LibraryApp.Entities
{
    public class BookCopy
    {
        public int Id { get; set; }
        public string EAN { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        ICollection<Rental> rentals { get; set; }
    }
}
