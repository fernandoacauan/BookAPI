using System;
using BookAPI.Domain.Entities.Author;

namespace BookAPI.Domain.Interfaces.Author;

public interface IAuthorRepository
{
    Task<AuthorEntity>                  GetByIdAsync(int id);
    Task<IEnumerable<AuthorEntity>>     GetAllAsync();
    Task<bool>                          CreateAuthorAsync(AuthorEntity author);
    Task<bool>                          UpdateAuthorAsync(AuthorEntity author);
    Task<bool>                          DeleteAsync(int id);
}
