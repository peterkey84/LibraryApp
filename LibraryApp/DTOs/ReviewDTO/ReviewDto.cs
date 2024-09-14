namespace LibraryApp.DTOs.ReviewDTO
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public string NameOfBook { get; set; }
        public string ReviewContent { get; set; }
        public int Rating { get; set; }
        public string ReviewerName { get; set; }
    }
}
