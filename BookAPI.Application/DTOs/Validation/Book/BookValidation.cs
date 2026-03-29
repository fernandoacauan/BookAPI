using System;
using BookAPI.Application.DTOs.Book;
using FluentValidation;

namespace BookAPI.Application.DTOs.Validation.Book;

public class BookValidation : AbstractValidator<BookDto>
{
    public BookValidation()
    {
        RuleFor(b => b.Id).NotEmpty();
        RuleFor(b => b.Title).NotEmpty().MaximumLength(255);
        RuleFor(b => b.ReleaseDate).NotEmpty();
    }
}
