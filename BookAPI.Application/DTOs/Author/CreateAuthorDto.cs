using System;

namespace BookAPI.Application.DTOs.Author;

public class CreateAuthorDto
{
    public required string Name { get; set; }
    public required string Surname { get; set; }
}
