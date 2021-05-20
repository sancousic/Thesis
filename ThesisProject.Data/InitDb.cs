using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Domain.Address;

namespace ThesisProject.Data
{
    public class InitDb
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            await SeedRoles(roleManager);
            await SeedBranches(context);
            await SeedSpecs(context);
            await SeedAdmin(userManager);
            await SeedDoctor(context, userManager);
            await SeedPacient(userManager);
        }
        private static async Task SeedDoctor(AppDbContext context, UserManager<AppUser> userManager)
        {
            var doctorEmail = "doctor@account.by";
            var doctorPassword = "12345";

            var docUser = await userManager.FindByEmailAsync(doctorEmail) as Doctor;
            if(docUser == null)
            {
                docUser = new Doctor()
                {
                    Email = doctorEmail,
                    Name1 = "Doc",
                    Name2 = "Ai",
                    Name3 = "Bolit",
                    UserName = doctorEmail,
                    EmailConfirmed = true,
                    RegistrationDate = DateTime.UtcNow,
                    Contacts = new Contacts(),
                    Male = Gender.Female,
                    Address = new Addresses()
                };
                await userManager.CreateAsync(docUser, doctorPassword);
                await userManager.AddToRoleAsync(docUser, "Doctor");

                docUser.Speciality = context.Specialities.FirstOrDefault();
                docUser.Branch = context.Branches.FirstOrDefault();
                docUser.Address = new Addresses();
                context.Update(docUser);
                await context.SaveChangesAsync();
            } 
        }
        private static async Task SeedAdmin(UserManager<AppUser> userManager)
        {
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
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
        private static async Task SeedPacient(UserManager<AppUser> userManager)
        {
            var pacientEmail = "pacient@account.by";
            var pacientPassword = "12345";
            var user = (await userManager.FindByEmailAsync(pacientEmail)) as Pacient;
            if (user == null)
            {
                user = new Pacient
                {
                    Email = pacientEmail,
                    Name1 = "Pacient",
                    Name2 = "Account",
                    UserName = pacientEmail,
                    EmailConfirmed = true,
                    Card = new Card()
                    {
                        Number = 123,
                        DateOfIssue = DateTime.Now
                    },
                    SomeData = "data",
                    Address = new Addresses(),
                    Contacts = new Contacts()
                };
                await userManager.CreateAsync(user, pacientPassword);
                await userManager.AddToRoleAsync(user, "Pacient");
            }
        }
        private static async Task SeedBranches(AppDbContext context)
        {
            if (!(context.Branches.Count() > 0))
            {
                var branches = new List<Branch>() {
                        new Branch() { Name = "Branch1", Description = "Branch1 descr" },
                        new Branch() { Name = "Branch2", Description = "Branch2 descr" }
                    };
                await context.Branches.AddRangeAsync(branches);
                await context.SaveChangesAsync();
            }
        }
        private static async Task SeedSpecs(AppDbContext context)
        {
            if (!(context.Specialities.Count() > 0))
            {
                var specs = new List<Speciality>() {
                    new Speciality() { Name = "Spec1", Description = "Spec1 descr" },
                    new Speciality() { Name = "Spec2", Description = "Spec1 descr" }
                };
                await context.Specialities.AddRangeAsync(specs);
                await context.SaveChangesAsync();
            }
        }
        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
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
        }
        
        
    }
    public class A<T> where T: System.IComparable
    {
        
    }
}
