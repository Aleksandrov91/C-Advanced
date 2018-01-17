namespace P01_HospitalDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DiagnoseConfiguration : IEntityTypeConfiguration<Diagnose>
    {
        public void Configure(EntityTypeBuilder<Diagnose> builder)
        {
            builder
                .Property(d => d.Name)
                .HasMaxLength(50);

            builder
                .Property(d => d.Comments)
                .HasMaxLength(250);

            builder
                .HasOne(p => p.Patient)
                .WithMany(d => d.Diagnoses);

            builder
                .HasKey(d => d.DiagnoseId);
        }
    }
}
