namespace P01_HospitalDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder
                .HasKey(d => d.DoctorId);

            builder
                .Property(d => d.Name)
                .HasMaxLength(100);

            builder
                .Property(s => s.Specialty)
                .HasMaxLength(100);

            builder
                .HasMany(v => v.Visitations)
                .WithOne(d => d.Doctor);
        }
    }
}
