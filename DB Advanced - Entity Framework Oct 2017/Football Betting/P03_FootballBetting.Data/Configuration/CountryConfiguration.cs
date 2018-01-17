namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .HasKey(c => c.CountryId);

            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
