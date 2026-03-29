using System;
using BookAPI.Application.DTOs.Author;
using FluentValidation;

namespace BookAPI.Application.DTOs.Validation.Author;

public class CreateAuthorValidation : AbstractValidator<CreateAuthorDto>
{
    public CreateAuthorValidation()
    {
        RuleFor(a => a.Name).NotEmpty().MaximumLength(100);
        RuleFor(a => a.Surname).NotEmpty().MaximumLength(100);
    }
}
