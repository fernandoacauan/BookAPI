using System;

namespace BookAPI.Application.DTOs.Author;

public class AuthorDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
}
