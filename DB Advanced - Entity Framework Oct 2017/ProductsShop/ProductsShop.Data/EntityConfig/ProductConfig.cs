namespace ProductsShop.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.Name)
                .IsRequired()
                .IsUnicode();

            builder
                .HasOne(p => p.Seller)
                .WithMany(u => u.SoldProducts)
                .HasForeignKey(p => p.SellerId);

            builder
                .HasOne(p => p.Buyer)
                .WithMany(u => u.BoughtProducts)
                .HasForeignKey(p => p.BuyerId);
        }
    }
}
