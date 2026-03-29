using System;
using BookAPI.Domain.Entities.Author;

namespace BookAPI.Domain.Entities.Book;

public class BookEntity
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required DateTime ReleaseDate { get; set; }
    public int AuthorId { get; set; }
    public AuthorEntity Author { get; set; } = null!;
}
