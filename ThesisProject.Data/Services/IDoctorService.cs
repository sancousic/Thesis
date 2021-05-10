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
        IQueryable<Doctor> GetDoctorsBySpec(int specId);
        IQueryable<Speciality> GetSpecialities();
        IQueryable<Doctor> GetDoctors(string name = null, string spec = null, string branch = null);
        IQueryable<Branch> GetBranches();
        IQueryable<Vaccination> GetVaccinations();
        Branch GetBranch(string name);
        Speciality GetSpeciality(string name);
        Task<Doctor> GetDoctorByIdAsync(string Id);
        Task<bool> DeleteAsync(string Id);
        Task<bool> UpdateAsync(string Id, string name1, string name2, string name3,
            string branch, string spec, string mail, string phone, int? cabinetNumber);
        IQueryable<Schedule> GetScheduleById(string Id);
    }
}
