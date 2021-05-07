using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
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
                .Where(HasName(name))
                .Select(x => x)
                .Include(x => x.Branch)
                .Include(x => x.Speciality);
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
        private Expression<Func<Doctor, bool>> HasName(string name)
        {
            var predicate = PredicateBuilder.New<Doctor>(true);

            if (!string.IsNullOrEmpty(name))
            {
                var names = name.Trim().ToLower().Split(' ');

                foreach (var n in names)
                {
                    predicate.Or(c => c.Name1.ToLower().Contains(n.ToLower()));
                    predicate.Or(c => c.Name2.ToLower().Contains(n.ToLower()));
                    predicate.Or(c => c.Name3.ToLower().Contains(n.ToLower()));
                }
            }
            
            return predicate;
        }

        public Branch GetBranch(string name) => _dbContext.Branches.FirstOrDefault(x => x.Name == name);

        public Speciality GetSpeciality(string name) => _dbContext.Specialities.FirstOrDefault(x => x.Name == name);
    }
}
