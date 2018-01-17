namespace P03_SalesDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder
                .HasKey(s => s.StoreId);

            builder
                .Property(s => s.Name)
                .HasMaxLength(80);

            builder
                .HasMany(s => s.Sales)
                .WithOne(st => st.Store)
                .HasForeignKey(st => st.StoreId);
        }
    }
}
