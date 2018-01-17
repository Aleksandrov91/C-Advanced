namespace P01_HospitalDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class VisitationConfiguration : IEntityTypeConfiguration<Visitation>
    {
        public void Configure(EntityTypeBuilder<Visitation> builder)
        {
            builder
                .HasKey(v => v.VisitationId);

            builder
                .Property(v => v.Comments)
                .HasMaxLength(250);

            builder
                .HasOne(v => v.Patient)
                .WithMany(v => v.Visitations);

            builder
                .HasOne(d => d.Doctor)
                .WithMany(v => v.Visitations)
                .HasForeignKey(d => d.DoctorId);
        }
    }
}
