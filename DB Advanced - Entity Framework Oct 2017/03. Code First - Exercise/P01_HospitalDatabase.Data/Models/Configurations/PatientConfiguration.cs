namespace P01_HospitalDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder
                .HasKey(p => p.PatientId);

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(50);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(50);

            builder
                .Property(p => p.Address)
                .HasMaxLength(250);

            builder
                .Property(p => p.Email)
                .HasMaxLength(80);

            builder
                .Property(p => p.HasInsurance)
                .HasDefaultValue(true);

            builder
                .HasMany(p => p.Prescriptions);
        }
    }
}
