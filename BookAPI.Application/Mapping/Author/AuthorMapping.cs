using System;
using AutoMapper;
using BookAPI.Application.DTOs.Author;
using BookAPI.Domain.Entities.Author;

namespace BookAPI.Application.Mapping.Author;

public class AuthorMapping : Profile
{
    public AuthorMapping()
    {
        CreateMap<CreateAuthorDto, AuthorEntity>();
        CreateMap<UpdateAuthorDto, AuthorEntity>();
        CreateMap<AuthorEntity, AuthorDto>();
    }
}
