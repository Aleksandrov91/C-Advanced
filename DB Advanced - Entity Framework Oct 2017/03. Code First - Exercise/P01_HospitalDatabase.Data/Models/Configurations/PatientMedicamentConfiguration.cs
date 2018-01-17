namespace P01_HospitalDatabase.Data.Models.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PatientMedicamentConfiguration : IEntityTypeConfiguration<PatientMedicament>
    {
        public void Configure(EntityTypeBuilder<PatientMedicament> builder)
        {
            builder
                .HasKey(p => new { p.MedicamentId, p.PatientId });
        }
    }
}
