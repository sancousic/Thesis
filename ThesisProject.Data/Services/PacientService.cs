using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.Data.Services
{
    public class PacientService : IPacientService
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public PacientService(AppDbContext dbContext, Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public async Task<Pacient> GetPacientByIdAsync(string Id)
        {
            return await _dbContext.Pacients.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
    }
}
