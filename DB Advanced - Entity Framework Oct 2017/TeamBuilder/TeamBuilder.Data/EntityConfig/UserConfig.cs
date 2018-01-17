namespace TeamBuilder.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamBuilder.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Username)
                .IsUnique(true);

            builder.Property(u => u.Username)
                .HasMaxLength(25)
                .IsRequired()
                .IsUnicode();

            builder.Property(u => u.FirstName)
                .HasMaxLength(25)
                .IsRequired(false)
                .IsUnicode();

            builder.Property(u => u.LastName)
                .HasMaxLength(25)
                .IsRequired(false)
                .IsUnicode();

            builder.Property(u => u.Password)
                .IsRequired()
                .IsUnicode();

            builder.Property(u => u.Gender)
                .IsRequired();

            builder.Property(u => u.Age);

            builder.Property(u => u.IsDeleted)
                .IsRequired(true)
                .HasDefaultValue(false);
        }
    }
}
