namespace BusTickets.Data.EntityConfig
{
    using BusTickets.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.FirstName)
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode();

            builder.Property(c => c.FirstName)
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode();

            builder.Property(c => c.Gender)
                .HasColumnType("CHAR(1)");

            builder
                .HasOne(c => c.HomeTown)
                .WithOne(t => t.Customer)
                .HasForeignKey<Town>(t => t.CustomerId);

            builder
                .HasMany(r => r.Reviews)
                .WithOne(c => c.Customer);
        }
    }
}
