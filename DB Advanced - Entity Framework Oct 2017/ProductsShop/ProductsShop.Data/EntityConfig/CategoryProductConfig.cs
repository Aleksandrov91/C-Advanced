namespace ProductsShop.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    internal class CategoryProductConfig : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CategoryProducts)
                .HasForeignKey(cp => cp.ProductId);

            builder
                .HasOne(cp => cp.Category)
                .WithMany(c => c.CategoryProducts)
                .HasForeignKey(cp => cp.CategoryId);

            builder.HasKey(cp => new { cp.CategoryId, cp.ProductId });
        }
    }
}
