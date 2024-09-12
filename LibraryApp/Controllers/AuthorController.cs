using LibraryApp.Entities;
using LibraryApp.Servicies.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {

            return await _authorService.GetAllAsync();

        }

        [HttpGet("id")]
        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            return await _authorService.GetByIdAsync(id);
        }

        [HttpDelete("id")]
        public async Task DeleteAuthorByIdA(int id)
        {
            await _authorService.DeleteAsync(id);
        }

        [HttpPost]
        public async Task AddAuthor(Author author)
        {
             await _authorService.AddAsync(author);
        }

        [HttpPut]
        public async Task UpdateAuthor(Author author)
        {
            await _authorService.UpdateAsync(author);
        }


        [HttpGet("books-of-author/{id}")]
        public async Task<IEnumerable<Book>> GetAllBooksFromAuthor(int id)
        {
            return await _authorService.GetAllBooksFromAuthorAsync(id);

        }

        [HttpGet("by-phrase/(phrase)")]
        public async Task<Author> FindAuthorByPhrase(string phrase)
        {
            return await _authorService.FindAuthorByPhraseAsync(phrase);
        }
    }
}
