using System;
using AutoMapper;
using BookAPI.Application.DTOs.Book;
using BookAPI.Application.Responses;
using BookAPI.Application.UseCaseInterface;
using BookAPI.Domain.Entities.Book;
using BookAPI.Domain.Interfaces.Book;

namespace BookAPI.Application.UseCaseImplementation;

public class BookUseCase : IBookUseCase
{
    private readonly IBookRepository _repository;
    private readonly IMapper _mapping;

    public BookUseCase(IBookRepository repository, IMapper mapping)
    {
        _repository = repository;
        _mapping = mapping;
    }

    public async Task<ServiceResponse<bool>> CreateBookAsync(CreateBookDto book)
    {
        var result = await _repository.CreateBookAsync(_mapping.Map<BookEntity>(book));

        if (!result)
        {
            return new (false, "Erro ao criar livro", false);
        }

        return new (true, "Livro criado com sucesso", true);
    }

    public async Task<ServiceResponse<bool>> DeleteAsync(int id)
    {
        var result = await _repository.DeleteAsync(id);

        if (!result)
        {
            return new (false, "Erro ao deletar livro", false);
        }

        return new (true, "Livro deletado com sucesso", true);
    }

    public async Task<ServiceResponse<IEnumerable<BookDto>>> GetAllAsync()
    {
        var result = await _repository.GetAllAsync();

        if (result == null)
        {
            return new (null, "Livros inexistentes", false);
        }

        return new (_mapping.Map<IEnumerable<BookDto>>(result), "Livros encontrados com sucesso", true);
    }

    public async Task<ServiceResponse<BookDto>> GetByIdAsync(int id)
    {
        var result = await _repository.GetByIdAsync(id);

        if (result == null)
        {
            return new (null, "Livro inexistente", false);
        }

        return new (_mapping.Map<BookDto>(result), "Livro encontrado com sucesso", true);
    }

    public async Task<ServiceResponse<bool>> UpdateBookAsync(UpdateBookDto book)
    {
        var result = await _repository.UpdateBookAsync(_mapping.Map<BookEntity>(book));

        if (!result)
        {
            return new (false, "Erro ao atualizar livro", false);
        }

        return new (true, "Livro atualizado com sucesso", true);
    }
}
