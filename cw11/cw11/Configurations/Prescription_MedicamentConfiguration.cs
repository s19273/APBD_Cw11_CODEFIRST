using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class Prescription_MedicamentConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder.HasKey(key => new { key.IdMedicament, key.IdPrescription });
            builder.HasOne(e => e.Prescription).WithMany().HasForeignKey(e => e.IdPrescription);
            builder.HasOne(e => e.Medicament).WithMany().HasForeignKey(e => e.IdMedicament);
            builder.Property(e => e.Dose).IsRequired();
            builder.Property(e => e.Details).HasMaxLength(100);

            var list = new List<Prescription_Medicament>();
            list.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 15, Details = "uzywac na noc" });
            list.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 25, Details = "uzywac w dzien" });
            list.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 1, Dose = 22, Details = "uzywac codziennie" });
            list.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 3, Dose = 11, Details = "uzywac na noc" });
            list.Add(new Prescription_Medicament { IdMedicament = 3, IdPrescription = 3, Dose = 13, Details = "uzywac rano" });
            

            builder.HasData(list);
        }
    }
}
