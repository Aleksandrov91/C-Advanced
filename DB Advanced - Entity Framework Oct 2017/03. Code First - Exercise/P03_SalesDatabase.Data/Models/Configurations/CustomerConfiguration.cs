namespace P03_SalesDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(c => c.CustomerId);

            builder
                .Property(c => c.Name)
                .HasMaxLength(100);

            builder
                .Property(c => c.Email)
                .HasMaxLength(80);

            builder
                .HasMany(s => s.Sales)
                .WithOne(c => c.Customer)
                .HasForeignKey(c => c.CustomerId);
        }
    }
}
