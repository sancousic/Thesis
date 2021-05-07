using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.Data.Services
{
    public interface IDoctorService
    {
        IQueryable<Doctor> GetDoctorsBySpec(Speciality speciality);
        IQueryable<Speciality> GetSpecialities();
        IQueryable<Doctor> GetDoctors(string name = null, string spec = null, string branch = null);
        IQueryable<Branch> GetBranches();
        IQueryable<Vaccination> GetVaccinations();
        Branch GetBranch(string name);
        Speciality GetSpeciality(string name);
        Task<Doctor> GetDoctorByIdAsync(string Id);
        Task<bool> DeleteAsync(string Id);
        Task<bool> UpdateAsync(Doctor doctor);
    }
}
