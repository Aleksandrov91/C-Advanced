namespace TeamBuilder.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;

    internal class EventTeamConfig : IEntityTypeConfiguration<EventTeam>
    {
        public void Configure(EntityTypeBuilder<EventTeam> builder)
        {
            builder
                .HasOne(et => et.Team)
                .WithMany(t => t.Events)
                .HasForeignKey(et => et.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(et => et.Event)
                .WithMany(t => t.Teams)
                .HasForeignKey(et => et.EventId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasKey(et => new { et.EventId, et.TeamId });
        }
    }
}
