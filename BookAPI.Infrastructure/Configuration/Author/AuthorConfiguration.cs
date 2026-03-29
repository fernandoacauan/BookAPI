using System;
using BookAPI.Domain.Entities.Author;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAPI.Infrastructure.Configuration.Author;

public class AuthorConfiguration : IEntityTypeConfiguration<AuthorEntity>
{
    public void Configure(EntityTypeBuilder<AuthorEntity> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Name).HasMaxLength(100).IsRequired();
        builder.Property(a => a.Surname).HasMaxLength(100).IsRequired();
        
        builder.HasMany(a => a.Books)
               .WithOne(b => b.Author)
               .HasForeignKey(b => b.AuthorId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Authors");
    }
}
