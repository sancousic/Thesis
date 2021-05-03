using Microsoft.AspNetCore.Identity;
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

        public IdentityService(UserManager<AppUser> userManager, AppDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
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
