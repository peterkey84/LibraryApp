﻿using LibraryApp.Entities;

namespace LibraryApp.Repositories.Interfaces
{
    public interface IBookRepository: IBaseRepository<Book>
    {

        Task<IEnumerable<Book>> GetAvailabilityBooks();
    }
}
