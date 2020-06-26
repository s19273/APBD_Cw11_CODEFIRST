using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public void AddNewDoctor(Doctor doctor);
        public void deleteDoctor(int id);
        public void modifyDoctor(Doctor doctor);
    }
}
