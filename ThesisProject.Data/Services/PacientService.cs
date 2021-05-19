using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Domain.Address;

namespace ThesisProject.Data.Services
{
    public class PacientService : IPacientService
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public PacientService(AppDbContext dbContext, UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public async Task<Pacient> GetPacientByIdAsync(string Id)
        {
            return await _dbContext.Pacients.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public IQueryable<Pacient> GetPacients(bool includeCard)
        {
            var query = _dbContext.Pacients.AsQueryable();
            if(includeCard)
            {
                query = query.Include(x => x.Card);
            }
            return query;
        }
        public async Task<Addresses> GetPacientAddress(string pacientId)
        {
            return await _dbContext.Addresses.Where(x => x.User.Id == pacientId).FirstOrDefaultAsync();
        }
    }
}
