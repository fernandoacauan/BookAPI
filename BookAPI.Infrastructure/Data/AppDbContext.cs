using System;
using BookAPI.Domain.Entities.Author;
using BookAPI.Domain.Entities.Book;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<BookEntity> Books { get; set; }
    public DbSet<AuthorEntity> Authors { get; set; }
    public AppDbContext(DbContextOptions options) : base(options) {}

    protected AppDbContext() {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
