using System;
using BookAPI.Domain.Entities.Book;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAPI.Infrastructure.Configuration.Book;

public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
{
    public void Configure(EntityTypeBuilder<BookEntity> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Title).HasMaxLength(255).IsRequired();
        builder.Property(b => b.ReleaseDate).IsRequired();
        builder.HasOne(b => b.Author)
               .WithMany(a => a.Books)
               .HasForeignKey(b => b.AuthorId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Books");
    }
}
