namespace TeamBuilder.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamBuilder.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class InvitationConfig : IEntityTypeConfiguration<Invitation>
    {
        public void Configure(EntityTypeBuilder<Invitation> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .HasOne(i => i.InivitedUser)
                .WithMany(u => u.ReceivedInvitations)
                .HasForeignKey(i => i.InvitedUserId);

            builder
                .HasOne(i => i.Team)
                .WithMany(t => t.Invitations)
                .HasForeignKey(i => i.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(i => i.IsActive)
                .IsRequired(true)
                .HasDefaultValue(true);
        }
    }
}
