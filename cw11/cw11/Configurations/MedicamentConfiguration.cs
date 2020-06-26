﻿using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class MedicamentConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(key => key.IdMedicament);
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(100);
            builder.Property(e => e.Type).HasMaxLength(100);

            var list = new List<Medicament>();
            list.Add(new Medicament { IdMedicament = 1, Name = "Rutinoskorbin", Description = "Dobry", Type = "jeden" });
            list.Add(new Medicament { IdMedicament = 2, Name = "Haaa", Description = "Slaby", Type = "dwa" });
            list.Add(new Medicament { IdMedicament = 3, Name = "BBBBB", Description = "Na gardlo", Type = "trzy" });
            

            builder.HasData(list);
        }
    }
}
