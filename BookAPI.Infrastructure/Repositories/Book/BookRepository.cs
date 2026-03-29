using System;
using BookAPI.Domain.Entities.Book;
using BookAPI.Domain.Interfaces.Book;
using BookAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Infrastructure.Repositories.Book;

public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;

    public BookRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateBookAsync(BookEntity book)
    {
        await _context.Books.AddAsync(book);

        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _context.Books.Where(b => b.Id == id).ExecuteDeleteAsync() > 0;
    }

    public async Task<IEnumerable<BookEntity>> GetAllAsync()
    {
        return await _context.Books.AsNoTracking().Include(b => b.Author).ToListAsync();
    }

    public async Task<BookEntity> GetByIdAsync(int id)
    {
        return await _context.Books.FindAsync(id) ?? throw new InvalidOperationException("Book not found");
    }

    public async Task<bool> UpdateBookAsync(BookEntity book)
    {
        return await _context.Books.Where(b => b.Id == book.Id).ExecuteUpdateAsync(setter =>
            setter.SetProperty(b=> b.Title, book.Title)
                  .SetProperty(b => b.ReleaseDate, book.ReleaseDate)) > 0;
    }
}
