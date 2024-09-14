namespace LibraryApp.Entities
{
    public class Review
    {

        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string ReviewContent { get; set; }
        public int Rating { get; set; }
        public string ReviewerName { get; set; }
    }
}
