namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using P01_BillsPaymentSystem.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder
                .HasKey(cc => cc.CreditCardId);

            builder
                .Ignore(cc => cc.LimitLeft);
        }
    }
}
