using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.Data.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly AppDbContext _dbContext;

        public DoctorService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Doctor> GetDoctors(string name = null, string spec = null, string branch = null)
        {
            return _dbContext.Doctors
                .Where(x => HasName(name, x))
                .Include(x => x.Branch)
                .Where(x => x.Branch.Name.Equals(branch))
                .Include(x => x.Speciality)
                .Where(x => x.Speciality.Equals(spec));
        }

        public IQueryable<Doctor> GetDoctorsBySpec(Speciality speciality)
        {
            var query = _dbContext.Doctors.Where(x => x.Speciality.Equals(speciality));
            return query;
        }
        public IQueryable<Speciality> GetSpecialities() => _dbContext.Specialities;
        public IQueryable<Branch> GetBranches() => _dbContext.Branches;

        public IQueryable<Vaccination> GetVaccinations()
        {
            return _dbContext.Vaccinations.AsQueryable<Vaccination>();
        }
        private bool HasName(string name, Doctor doctor)
        {
            var names = name.Trim().ToLower().Split(' ');
            foreach(var n in names)
            {
                if (!doctor.Name1.Contains(n) && !doctor.Name2.Contains(n) && !doctor.Name3.Contains(n))
                    return false;
            }
            return true;
        }

        public Branch GetBranch(string name) => _dbContext.Branches.FirstOrDefault(x => x.Name == name);

        public Speciality GetSpeciality(string name) => _dbContext.Specialities.FirstOrDefault(x => x.Name == name);
    }
}
