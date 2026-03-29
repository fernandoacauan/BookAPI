using BookAPI.Domain.Entities.Author;
using BookAPI.Domain.Interfaces.Author;
using BookAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Infrastructure.Repositories.Author;

public class AuthorRepository : IAuthorRepository
{
    private readonly AppDbContext _context;

    public AuthorRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> CreateAuthorAsync(AuthorEntity author)
    {
        await _context.Authors.AddAsync(author);

        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _context.Authors.Where(a => a.Id == id).ExecuteDeleteAsync() > 0;
    }

    public async Task<IEnumerable<AuthorEntity>> GetAllAsync()
    {
        return await _context.Authors.AsNoTracking().ToListAsync();
    }

    public async Task<AuthorEntity> GetByIdAsync(int id)
    {
        return await _context.Authors.FindAsync(id) ?? throw new InvalidOperationException("Author not found");
    }

    public async Task<bool> UpdateAuthorAsync(AuthorEntity author)
    {
        return await _context.Authors.Where(a => a.Id == author.Id).ExecuteUpdateAsync(setter =>
            setter.SetProperty(a => a.Name, author.Name)
                  .SetProperty(a => a.Surname, author.Surname)) > 0;
    }
}
