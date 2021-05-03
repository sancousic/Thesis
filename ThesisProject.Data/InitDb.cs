using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.Data
{
    public class InitDb
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var userRoleName = "Pacient";
            var userRole = await roleManager.FindByNameAsync(userRoleName);
            if (userRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole(userRoleName));
            }
            userRoleName = "Doctor";
            userRole = await roleManager.FindByNameAsync(userRoleName);
            if (userRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole(userRoleName));
            }

            var adminRoleName = "Admin";
            var adminRole = await roleManager.FindByNameAsync(adminRoleName);
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole(adminRoleName));
            }

            
            var adminUserEmail = "admin@account.by";
            var adminUserPassword = "12345";

            var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
            if (adminUser == null)
            {
                adminUser = new AppUser()
                {
                    Email = adminUserEmail,
                    Name1 = "Admin",
                    Name2 = "Account",
                    UserName = adminUserEmail,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(adminUser, adminUserPassword);
                await userManager.AddToRoleAsync(adminUser, adminRoleName);
            }
        }
    }
}
