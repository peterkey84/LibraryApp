namespace LibraryApp.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime DateOfLoan { get; set; }
        public DateTime? DateOfReturn { get; set; }
        public decimal Fees { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public BookCopy BookCopy { get; set; }
        public int BookCopyId { get; set; }

    }
}
