namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using P01_BillsPaymentSystem.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder
                .HasKey(pm => pm.Id);

            builder
                .HasIndex(pm => new { pm.UserId, pm.BankAccountId, pm.CreditCardId })
                .IsUnique(true);

            builder
                .HasOne(ba => ba.BankAccount)
                .WithOne(pm => pm.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);

            builder
                .HasOne(cc => cc.CreditCard)
                .WithOne(p => p.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);

            builder
                .HasOne(pm => pm.User)
                .WithMany(u => u.PaymentMethods)
                .HasForeignKey(p => p.UserId);
        }
    }
}
