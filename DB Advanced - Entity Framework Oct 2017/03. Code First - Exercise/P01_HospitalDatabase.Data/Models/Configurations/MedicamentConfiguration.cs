namespace P01_HospitalDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MedicamentConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder
                .HasKey(m => m.MedicamentId);

            builder
                .Property(m => m.Name)
                .HasMaxLength(50);

            builder
                .HasMany(m => m.Prescriptions);
        }
    }
}
