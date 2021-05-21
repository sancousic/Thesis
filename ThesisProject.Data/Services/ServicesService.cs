using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.Data.Services
{
    public class ServicesService : IServicesService
    {
        private readonly AppDbContext _dbContext;

        public ServicesService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddVaccination(Vaccination vaccination)
        {
            var vc = await _dbContext.Vaccinations.Where(x => x.Type == vaccination.Type).FirstOrDefaultAsync();
            if(vc == null)
            {
                _dbContext.Vaccinations.Add(vaccination);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteVaccination(int Id)
        {
            var vc = await _dbContext.Vaccinations.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if(vc != null)
            {
                vc.ExpriationDate = DateTime.Now.Date;
                vc.IsActive = false;
            }
        }
        public IQueryable<Vaccination> GetVaccinations(bool includeAll)
        {
            var query = _dbContext.Vaccinations.AsQueryable();
            if(includeAll)
            {
                return query;
            }
            return query.Where(x => x.IsActive);
        }
    }
}
