using AutoMapper;
using LibraryApp.DTOs.BookDTO;
using LibraryApp.DTOs.ReviewDTO;
using LibraryApp.Entities;

namespace LibraryApp.AutoMapper

{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            BookMapping();

        }

        private void BookMapping()
        {
            CreateMap<Book, BookViewDto>();
                //.ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.FirstName + " " + src.Author.LastName))
                //.ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.BookCopies.Sum(bc => bc.Quantity)));

            CreateMap<BookViewDto, Book>();

            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.NameOfBook, opt => opt.MapFrom(src => src.Book.Title));
            CreateMap<ReviewDto, Review>();
        }
    }
}
