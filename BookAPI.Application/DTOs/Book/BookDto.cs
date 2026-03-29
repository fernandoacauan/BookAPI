using System;
using BookAPI.Application.DTOs.Author;

namespace BookAPI.Application.DTOs.Book;

public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public AuthorDto Author { get; set; } = null!;
}
