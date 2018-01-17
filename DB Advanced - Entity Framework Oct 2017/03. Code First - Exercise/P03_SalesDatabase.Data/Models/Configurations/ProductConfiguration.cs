namespace P03_SalesDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(p => p.ProductId);

            builder
                .Property(p => p.Name)
                .HasMaxLength(100);

            builder
                .Property(p => p.Description)
                .HasMaxLength(250)
                .HasDefaultValue("No Description");

            builder
                .HasMany(s => s.Sales)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
