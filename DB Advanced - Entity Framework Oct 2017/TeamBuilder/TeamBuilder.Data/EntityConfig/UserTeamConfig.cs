using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamBuilder.Models;

namespace TeamBuilder.Data.EntityConfig
{
    internal class UserTeamConfig : IEntityTypeConfiguration<UserTeam>
    {
        public void Configure(EntityTypeBuilder<UserTeam> builder)
        {
            builder
                .HasOne(ut => ut.User)
                .WithMany(u => u.UserTeams)
                .HasForeignKey(ut => ut.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(ut => ut.Team)
                .WithMany(t => t.Users)
                .HasForeignKey(ut => ut.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasKey(ut => new { ut.TeamId, ut.UserId });
        }
    }
}
