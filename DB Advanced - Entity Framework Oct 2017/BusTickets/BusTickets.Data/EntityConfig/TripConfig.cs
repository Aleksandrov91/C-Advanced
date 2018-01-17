namespace BusTickets.Data.EntityConfig
{
    using BusTickets.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(t => t.TripId);

            builder
                .HasOne(os => os.OriginStation)
                .WithMany(t => t.OriginTrips)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(os => os.DestinationStation)
                .WithMany(t => t.DestinationTrips)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Company)
                .WithMany(t => t.Trips);
        }
    }
}
