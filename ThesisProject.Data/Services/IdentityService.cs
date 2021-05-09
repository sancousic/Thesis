using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Results;

namespace ThesisProject.Data.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _dbContext;
        private ILogger<IdentityService> _logger;

        public IdentityService(UserManager<AppUser> userManager, AppDbContext dbContext, ILogger<IdentityService> logger)
        {
            _userManager = userManager;
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IdentityResult> CreateUser<T>(string mail, string password, string role) where T : AppUser, new()
        {
            var user = new T() { UserName = mail, Email = mail };
            
            var res = await _userManager.CreateAsync(user, password);
            if(res.Succeeded)
            {
                var a = await _userManager.AddToRoleAsync(user, role);
                _logger.LogInformation("User created a new account with password.");
            }
            return res;
        }

        public IQueryable<GetUserResult> GetUsers()
        {
            var users = (from user in _userManager.Users
                         join role in _dbContext.UserRoles on user.Id equals role.UserId
                         select new GetUserResult
                         {
                             Email = user.Email,
                             Id = user.Id,
                             Name1 = user.Name1,
                             Name2 = user.Name2,
                             Name3 = user.Name3,
                             Role = _dbContext.Roles.FirstOrDefault(x => x.Id == role.RoleId).Name
                         });

            return users;
        }

    }
}
