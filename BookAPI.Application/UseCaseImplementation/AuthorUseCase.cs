using System;
using AutoMapper;
using BookAPI.Application.DTOs.Author;
using BookAPI.Application.Responses;
using BookAPI.Domain.Entities.Author;
using BookAPI.Domain.Interfaces.Author;

namespace BookAPI.Application.UseCaseImplementation;

public class AuthorUseCase : IAuthorUseCase
{
    private readonly IAuthorRepository _repository;
    private readonly IMapper _mapping;

    public AuthorUseCase(IAuthorRepository repository, IMapper mapping)
    {
        _repository = repository;
        _mapping = mapping;
    }

    public async Task<ServiceResponse<bool>> CreateAuthorAsync(CreateAuthorDto author)
    {
        var result = await _repository.CreateAuthorAsync(_mapping.Map<AuthorEntity>(author));

        if(!result)
        {
            return new (false, "Erro ao criar autor", false);
        }

        return new (true, "Autor criado com sucesso", true);
    }

    public async Task<ServiceResponse<bool>> DeleteAsync(int id)
    {
        var result = await _repository.DeleteAsync(id);

        if(!result)
        {
            return new (false, "Erro ao deletar autor", false);
        }

        return new (true, "Autor deletado com sucesso.", true);
    }

    public async Task<ServiceResponse<IEnumerable<AuthorDto>>> GetAllAsync()
    {
        var result = await _repository.GetAllAsync();

        if(result == null)
        {
            return new (null, "Erro ao encontrar autores", false);
        }

        return new ( _mapping.Map<IEnumerable<AuthorDto>>(result), "Autores encontrados com sucesso", true);
    }

    public async Task<ServiceResponse<AuthorDto>> GetByIdAsync(int id)
    {
        var result = await _repository.GetByIdAsync(id);

        if(result == null)
        {
            return new (null, "Autor inexistente", false);
        }

        return new (_mapping.Map<AuthorDto>(result), "Autor encontrado com sucesso", true);
    }

    public async Task<ServiceResponse<bool>> UpdateAuthorAsync(UpdateAuthorDto author)
    {
        var result = await _repository.UpdateAuthorAsync(_mapping.Map<AuthorEntity>(author));

        if(!result)
        {
            return new (false, "Erro ao atualizar autor", false);
        }

        return new (true, "Autor atualizado com sucesso", true);
    }
}
