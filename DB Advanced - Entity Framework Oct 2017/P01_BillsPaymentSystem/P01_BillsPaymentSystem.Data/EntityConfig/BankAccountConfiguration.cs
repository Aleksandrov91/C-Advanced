namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using P01_BillsPaymentSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder
                .HasKey(ba => ba.BankAccountId);

            builder
                .Property(ba => ba.BankName)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder
                .Property(ba => ba.SWIFTCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired(true);
        }
    }
}
