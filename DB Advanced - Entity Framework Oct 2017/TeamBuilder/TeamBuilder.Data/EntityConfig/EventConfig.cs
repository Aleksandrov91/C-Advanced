namespace TeamBuilder.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamBuilder.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .HasMaxLength(25)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Description)
                .HasMaxLength(250)
                .IsRequired(false)
                .IsUnicode();

            builder.Property(e => e.StartDate)
                .IsRequired(false);

            builder.Property(e => e.EndDate)
                .IsRequired(false);

            builder
                .HasOne(e => e.Creator)
                .WithMany(u => u.CreatedEvents)
                .HasForeignKey(e => e.CreatorId);
        }
    }
}
