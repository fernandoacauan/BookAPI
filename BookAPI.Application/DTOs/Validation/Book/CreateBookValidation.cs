using System;
using BookAPI.Application.DTOs.Book;
using FluentValidation;

namespace BookAPI.Application.DTOs.Validation.Book;

public class CreateBookValidation : AbstractValidator<CreateBookDto>
{
    public CreateBookValidation()
    {
        RuleFor(b => b.Title).NotEmpty().MaximumLength(255);
        RuleFor(b => b.ReleaseDate).NotEmpty();
        RuleFor(b => b.AuthorId).NotEmpty();
    }
}
