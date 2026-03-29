using System;
using BookAPI.Application.DTOs.Book;
using BookAPI.Application.Responses;

namespace BookAPI.Application.UseCaseInterface;

public interface IBookUseCase
{
    Task<ServiceResponse<BookDto>>                      GetByIdAsync(int id);
    Task<ServiceResponse<IEnumerable<BookDto>>>         GetAllAsync();
    Task<ServiceResponse<bool>>                         CreateBookAsync(CreateBookDto book);
    Task<ServiceResponse<bool>>                         UpdateBookAsync(UpdateBookDto book);
    Task<ServiceResponse<bool>>                         DeleteAsync(int id);
}
