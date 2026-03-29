using System;

namespace BookAPI.Application.DTOs.Book;

public class UpdateBookDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
}
