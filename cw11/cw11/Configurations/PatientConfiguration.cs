using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(key => key.IdPatient);
            builder.Property(e => e.FirstName).HasMaxLength(100);
            builder.Property(e => e.LastName).HasMaxLength(100);

            var list = new List<Patient>();
            list.Add(new Patient { IdPatient = 1, FirstName = "Zygmunt", LastName = "Trzeci", BirthDate = Convert.ToDateTime("2000-01-01")});
            list.Add(new Patient { IdPatient = 2, FirstName = "Piotr", LastName = "Jan", BirthDate = Convert.ToDateTime("2007-02-12")});
            list.Add(new Patient { IdPatient = 3, FirstName = "Kasia", LastName = "Masia", BirthDate = Convert.ToDateTime("2004-05-11")});
            

            builder.HasData(list);
        }
    }
}
