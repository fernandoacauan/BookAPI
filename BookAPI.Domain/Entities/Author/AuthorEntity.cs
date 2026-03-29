using System;
using BookAPI.Domain.Entities.Book;

namespace BookAPI.Domain.Entities.Author;

public class AuthorEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public ICollection<BookEntity> Books { get; set; } = new List<BookEntity>();
}
