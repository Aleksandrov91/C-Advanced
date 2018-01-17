namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder
                .HasKey(c => c.ColorId);

            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
