using LinqKit;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;

        public DoctorService(AppDbContext dbContext, Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public IQueryable<Doctor> GetDoctors(string name = null, string spec = null, string branch = null)
        {
            var query = _dbContext.Doctors
                .Where(HasName(name))
                .Include(x => x.Branch)
                .Where(x => string.IsNullOrEmpty(branch) || x.Branch.Name.Contains(branch))
                .Include(x => x.Speciality)
                .Where(x => string.IsNullOrEmpty(spec) || x.Speciality.Name.Contains(spec))
                .Select(x => x);
            return query;
        }

        public IQueryable<Doctor> GetDoctorsBySpec(int id)
        {
            var query = _dbContext.Doctors.Include(x => x.Speciality).Where(x => x.Speciality.Id == id)
                .Include(x => x.Cabinet).Select(x => x);
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

        public async Task<Doctor> GetDoctorByIdAsync(string Id)
        {
            var doc = await _dbContext.Doctors
                .Where(x => x.Id == Id)
                .Include(x => x.Branch)
                .Include(x => x.Speciality)
                .Include(x => x.Cabinet)
                .Include(x => x.Contacts)
                .FirstOrDefaultAsync();
            return doc;
        }

        public Task<bool> DeleteAsync(string Id)
        {
            throw new NotImplementedException(); //TODO delete
        }

        public Task<bool> UpdateAsync(Doctor doctor)
        {
            throw new NotImplementedException(); //TODO update
        }
    }
}
