using System;

namespace BookAPI.Application.DTOs.Book;

public class CreateBookDto
{
    public required string Title { get; set; }
    public required DateTime ReleaseDate { get; set; }
    public int AuthorId { get; set; }
}
