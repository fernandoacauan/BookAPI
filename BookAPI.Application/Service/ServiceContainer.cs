using System;
using AutoMapper;
using BookAPI.Application.Mapping.Author;
using BookAPI.Application.Mapping.Book;
using BookAPI.Application.UseCaseImplementation;
using BookAPI.Application.UseCaseInterface;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace BookAPI.Application.Service;

public static class ServiceContainer
{
    public static IServiceCollection AddApplication(this IServiceCollection service, string logPath)
    {
        Log.Logger = new LoggerConfiguration()
                         .MinimumLevel.Information()
                         .WriteTo.Debug()
                         .WriteTo.Console()
                         .WriteTo.File(
                            path: logPath,
                            rollingInterval: RollingInterval.Day,
                            restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information
                         ).CreateLogger();

        service.AddValidatorsFromAssembly(typeof(ServiceContainer).Assembly);
        service.AddFluentValidationAutoValidation();
        service.AddFluentValidationClientsideAdapters();

        service.AddAutoMapper(config =>
        {
            config.AddProfile<AuthorMapping>();
            config.AddProfile<BookMapping>();
        }, typeof(ServiceContainer).Assembly);

        service.AddScoped<IAuthorUseCase, AuthorUseCase>();
        service.AddScoped<IBookUseCase, BookUseCase>();
        
        return service;       
    }
}
