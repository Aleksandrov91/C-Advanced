namespace ProductsShop.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.FirstName)
                .HasMaxLength(30)
                .IsRequired(false)
                .IsUnicode();

            builder.Property(u => u.LastName)
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode();

            builder.Property(u => u.Age)
                .IsRequired(false);
        }
    }
}
