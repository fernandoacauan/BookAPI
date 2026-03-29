using System;
using BookAPI.Domain.Entities.Book;

namespace BookAPI.Domain.Interfaces.Book;

public interface IBookRepository
{
    Task<BookEntity>                    GetByIdAsync(int id);
    Task<IEnumerable<BookEntity>>       GetAllAsync();
    Task<bool>                          CreateBookAsync(BookEntity book);
    Task<bool>                          UpdateBookAsync(BookEntity book);
    Task<bool>                          DeleteAsync(int id);
}
