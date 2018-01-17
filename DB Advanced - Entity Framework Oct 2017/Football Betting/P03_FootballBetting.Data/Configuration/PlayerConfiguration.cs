namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder
                .HasKey(p => p.PlayerId);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode();

            builder
                .Property(p => p.SquadNumber)
                .IsRequired();

            builder
                .Property(p => p.IsInjured)
                .HasDefaultValue(false);

            builder
                .HasOne(t => t.Team)
                .WithMany(p => p.Players);

            builder
                .HasOne(p => p.Position)
                .WithMany(p => p.Players);
        }
    }
}
