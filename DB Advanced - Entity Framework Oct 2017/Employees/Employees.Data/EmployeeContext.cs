namespace Employees.Data
{
    using Employees.Data.EntityConfig;
    using Employees.Model;
    using Microsoft.EntityFrameworkCore;

    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

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

            modelBuilder.ApplyConfiguration(new EmployeeConfig());
        }
    }
}
