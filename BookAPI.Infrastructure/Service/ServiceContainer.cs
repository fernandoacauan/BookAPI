using BookAPI.Application.UseCaseImplementation;
using BookAPI.Application.UseCaseInterface;
using BookAPI.Domain.Interfaces.Author;
using BookAPI.Domain.Interfaces.Book;
using BookAPI.Infrastructure.Data;
using BookAPI.Infrastructure.Repositories.Author;
using BookAPI.Infrastructure.Repositories.Book;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookAPI.Infrastructure.Service;

public static class ServiceContainer
{
    public static IServiceCollection ConnectionService(this IServiceCollection service, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("DefaultConnection")
                               ?? throw new InvalidOperationException("Default Connection not found");

        service.AddDbContext<AppDbContext>(op =>
        {
           op.UseSqlServer(connectionString); 
        });

        service.AddScoped<IBookRepository, BookRepository>();
        service.AddScoped<IAuthorRepository, AuthorRepository>();
        service.AddScoped<IAuthorUseCase, AuthorUseCase>();
        service.AddScoped<IBookUseCase, BookUseCase>();

        return service;
    }
}
