namespace BusTickets.Data.EntityConfig
{
    using BusTickets.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class BankAccountConfig : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(b => b.BankAccountId);

            builder
                .HasOne(c => c.Customer)
                .WithOne(b => b.BankAccount)
                .HasForeignKey<Customer>(b => b.BankAccountId);
        }
    }
}
