namespace BusTickets.Data.EntityConfig
{
    using BusTickets.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class BusStationConfig : IEntityTypeConfiguration<BusStation>
    {
        public void Configure(EntityTypeBuilder<BusStation> builder)
        {
            builder.HasKey(bs => bs.StationId);

            builder
                .HasOne(t => t.Town)
                .WithMany(s => s.BusStations);
        }
    }
}
