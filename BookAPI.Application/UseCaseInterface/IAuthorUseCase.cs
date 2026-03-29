using System;
using BookAPI.Application.DTOs.Author;
using BookAPI.Application.Responses;

namespace BookAPI.Application.UseCaseImplementation;

public interface IAuthorUseCase
{
    Task<ServiceResponse<AuthorDto>>                    GetByIdAsync(int id);
    Task<ServiceResponse<IEnumerable<AuthorDto>>>       GetAllAsync();
    Task<ServiceResponse<bool>>                         CreateAuthorAsync(CreateAuthorDto author);
    Task<ServiceResponse<bool>>                         UpdateAuthorAsync(UpdateAuthorDto author);
    Task<ServiceResponse<bool>>                         DeleteAsync(int id);
}
