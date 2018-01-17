namespace P03_SalesDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder
                .HasKey(s => s.SaleId);

            builder
                .Property(s => s.Date)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
