﻿namespace LibraryApp.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public ICollection<BookCopy> bookCopies { get; set; }
        

    }
}
