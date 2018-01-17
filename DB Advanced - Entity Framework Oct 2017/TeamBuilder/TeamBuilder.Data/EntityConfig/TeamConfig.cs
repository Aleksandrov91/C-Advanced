namespace TeamBuilder.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamBuilder.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasIndex(t => t.Name)
                .IsUnique();

            builder.Property(t => t.Name)
                .HasMaxLength(25)
                .IsRequired()
                .IsUnicode();

            builder.Property(t => t.Description)
                .HasMaxLength(32)
                .IsRequired(false)
                .IsUnicode();

            builder.Property(t => t.Acronym)
                .HasColumnType("CHAR(3)")
                .IsRequired()
                .IsUnicode();

            builder
                .HasOne(t => t.Creator)
                .WithMany(u => u.OwnedTeams)
                .HasForeignKey(t => t.CreatorId);
        }
    }
}
