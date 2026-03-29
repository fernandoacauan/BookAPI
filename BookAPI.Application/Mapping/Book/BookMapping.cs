using System;
using AutoMapper;
using BookAPI.Application.DTOs.Book;
using BookAPI.Domain.Entities.Book;

namespace BookAPI.Application.Mapping.Book;

public class BookMapping : Profile
{
    public BookMapping()
    {
        CreateMap<CreateBookDto, BookEntity>();
        CreateMap<UpdateBookDto, BookEntity>();
        CreateMap<BookEntity, BookDto>();
    }
}
