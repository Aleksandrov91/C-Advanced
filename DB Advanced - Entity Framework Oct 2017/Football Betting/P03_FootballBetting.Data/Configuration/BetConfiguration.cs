namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data.Models;

    internal class BetConfiguration : IEntityTypeConfiguration<Bet>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Bet> builder)
        {
            builder
                .HasKey(b => b.BetId);

            builder
                .Property(b => b.Amount)
                .IsRequired();

            builder
                .HasOne(g => g.Game)
                .WithMany(b => b.Bets);

            builder
                .HasOne(u => u.User)
                .WithMany(b => b.Bets);
        }
    }
}
