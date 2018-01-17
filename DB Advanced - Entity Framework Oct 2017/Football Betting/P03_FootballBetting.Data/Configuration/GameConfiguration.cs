namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data.Models;

    internal class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Game> builder)
        {
            builder
                .HasKey(g => g.GameId);

            builder
                .HasOne(t => t.HomeTeam)
                .WithMany(g => g.HomeGames)
                .HasForeignKey(t => t.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.AwayTeam)
                .WithMany(g => g.AwayGames)
                .HasForeignKey(t => t.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
