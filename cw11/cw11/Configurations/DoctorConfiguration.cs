using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(key => key.IdDoctor);
            builder.Property(e => e.FirstName).HasMaxLength(100);
            builder.Property(e => e.LastName).HasMaxLength(100);
            builder.Property(e => e.Email).HasMaxLength(100);

            var list = new List<Doctor>();
            list.Add(new Doctor { IdDoctor = 1, FirstName = "Pawel", LastName = "Kijek", Email = "Pawel@kijek.pl" });
            list.Add(new Doctor { IdDoctor = 2, FirstName = "Jan", LastName = "Patyk", Email = "Patyk@kss.pl" });
            list.Add(new Doctor { IdDoctor = 3, FirstName = "Ania", LastName = "Wrr", Email = "ania@kggk.pl" });
            list.Add(new Doctor { IdDoctor = 4, FirstName = "Tadeusz", LastName = "MKM", Email = "allS@wp.pl" });

            builder.HasData(list);
        }
    }
}
