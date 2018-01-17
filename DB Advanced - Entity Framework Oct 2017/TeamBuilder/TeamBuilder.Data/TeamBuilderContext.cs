namespace TeamBuilder.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using TeamBuilder.Data.EntityConfig;
    using TeamBuilder.Models;

    public class TeamBuilderContext : DbContext
    {
        public TeamBuilderContext()
        {
        }

        public TeamBuilderContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventTeam> EventTeams { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new TeamConfig());
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new InvitationConfig());
            modelBuilder.ApplyConfiguration(new UserTeamConfig());
            modelBuilder.ApplyConfiguration(new EventTeamConfig());
        }
    }
}
