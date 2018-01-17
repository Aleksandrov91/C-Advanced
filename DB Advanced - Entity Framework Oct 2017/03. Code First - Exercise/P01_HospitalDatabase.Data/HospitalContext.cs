namespace P01_HospitalDatabase.Data
{
    using Microsoft.EntityFrameworkCore;
    using P01_HospitalDatabase.Data.Models;
    using P01_HospitalDatabase.Data.Models.Configurations;

    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Diagnose> Diagnoses { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<Visitation> Visitations { get; set; }

        public DbSet<PatientMedicament> PatientsMedicaments { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);

            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(Configuration.Connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PatientConfiguration());

            builder.ApplyConfiguration(new DiagnoseConfiguration());

            builder.ApplyConfiguration(new MedicamentConfiguration());

            builder.ApplyConfiguration(new VisitationConfiguration());

            builder.ApplyConfiguration(new PatientMedicamentConfiguration());

            builder.ApplyConfiguration(new DoctorConfiguration());
        }
    }
}
