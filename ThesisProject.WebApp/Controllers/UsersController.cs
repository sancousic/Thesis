using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;
using ThesisProject.Data.Services;
using ThesisProject.Data.Domain;
using ThesisProject.Data;
using Microsoft.AspNetCore.Authorization;
using System.Linq.Dynamic.Core;
using System.Threading;
using ThesisProject.WebApp.Models.User;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThesisProject.WebApp.Models.AddressModels;
using ThesisProject.WebApp.Models.Home;

namespace ThesisProject.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly IIdentityService _identityService;
        private readonly IUserStore<AppUser> _userStore;
        private readonly AppDbContext _dbContext;
        private ILogger<UsersController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IDoctorService _doctorService;
        private readonly IUserService _userService;

        public UsersController(IIdentityService identityService, IUserStore<AppUser> userStore,
            AppDbContext dbContext, ILogger<UsersController> logger, UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager,
            IDoctorService doctorService, IUserService userService)
        {
            _identityService = identityService;
            _userStore = userStore;
            _dbContext = dbContext;
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _doctorService = doctorService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> LoadUsers()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                var start = HttpContext.Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault()
                    + "][name]"].FirstOrDefault();

                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();

                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                var pageSize = length != null ? Convert.ToInt32(length) : 0;
                var skip = start != null ? Convert.ToInt32(start) : 0;

                var recordsTotal = 0;

                var data = _identityService.GetUsers();

                var debugg = await data.ToListAsync();

                if (!(string.IsNullOrEmpty(sortColumn)) && !(string.IsNullOrEmpty(sortColumnDirection)))
                {
                    data = data.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    data = data.Where(m => (m.Email.Contains(searchValue) || m.Role.Contains(searchValue)));
                }

                recordsTotal = data.Count();

                var result = await data.Skip(skip).Take(pageSize).ToListAsync();
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = result });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                throw;
            }
        }
        public async Task<IActionResult> Create(string returnUrl = null)
        {
            var vm = new CreateUserModel { ReturnUrl = returnUrl };
            vm.Roles = await GetRoles();

            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserModel viewModel)
        {
            viewModel.ReturnUrl ??= Url.Content("~/");
            if(ModelState.IsValid)
            {
                IdentityResult identityResult = null;
                if (viewModel.Role == "Admin")
                    identityResult = await _identityService.CreateUser<AppUser>(viewModel.Email, viewModel.Password, viewModel.Role);
                else if (viewModel.Role == "Doctor")
                    identityResult = await _identityService.CreateUser<Doctor>(viewModel.Email, viewModel.Password, viewModel.Role);
                else if (viewModel.Role == "Pacient")
                    identityResult = await _identityService.CreateUser<Pacient>(viewModel.Email, viewModel.Password, viewModel.Role);
                if (identityResult.Succeeded)
                {
                    return LocalRedirect(viewModel.ReturnUrl);
                }
                viewModel.Roles = await GetRoles();
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(viewModel);
        }
        public async Task<IActionResult> Edit(string Id, string returnUrl)
        {
            var user = await _userManager.FindByIdAsync(Id);
            var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
            EditUserViewModel vm = null;
            if(role == "Admin")
            {
                vm = new EditUserViewModel(user, role);
            }
            if(role == "Doctor")
            {
                var doc = await _doctorService.GetDoctorByIdAsync(Id);
                var specs = await _doctorService.GetSpecialities()
                    .Select(x => x.Name).ToListAsync();
                var branches = await _doctorService.GetBranches()
                    .Select(x => x.Name).ToListAsync();
                vm = new EditUserViewModel(doc, role, branches, specs);
                vm.returnUrl = returnUrl;
            }
            if (!(role == "Pacient"))
                return View(vm);
            return RedirectToAction("Edit", "Pacients", new {id = Id, returnUrl = returnUrl});
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            
            if (viewModel.Role == "Admin")
            {
                var user = await _userManager.FindByIdAsync(viewModel.Id);

                user.Name1 = viewModel.Name1;
                user.Name2 = viewModel.Name2;
                user.Name3 = viewModel.Name3;

                var result = await _userStore.UpdateAsync(user, CancellationToken.None);
                if (!result.Succeeded)
                {
                    foreach(var e in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, e.Description);
                    }
                    return View(viewModel);
                }
            }
            if(viewModel.Role == "Doctor")
            {
                await _doctorService.UpdateAsync(viewModel.Id, viewModel.Name1, viewModel.Name2,
                    viewModel.Name3, viewModel.Branch, viewModel.Speciality, viewModel.ContactEmail,
                    viewModel.ContactPhoneNumber, viewModel.CabinetNumber);
            }
            if (!string.IsNullOrEmpty(viewModel.returnUrl))
                return LocalRedirect(viewModel.returnUrl);
            return RedirectToAction(nameof(Index));
        }
        [AllowAnonymous]
        public async Task<IActionResult> ChangeSchedule(string id, string returnUrl)
        {
            if (string.IsNullOrEmpty(id))
                id = _userManager.GetUserId(User);
            var viewModel = new ChangeScheduleViewModel
            {
                ReturnUrl = returnUrl,
                DoctorId = id
            };
            viewModel.Schedules = await _doctorService.GetScheduleByDocId(id).ToArrayAsync();
            viewModel.Doctor = await _doctorService.GetDoctorByIdAsync(id);
            return View(viewModel);
        }
        public async Task<IActionResult> AddSchedule(string docId, Schedule schedule, string returnUrl)
        {
            await _doctorService.AddToSchedules(docId, schedule);
            return RedirectToAction(nameof(ChangeSchedule), new { id = docId, returnUrl = returnUrl });
        }
        public async Task<IActionResult> EditSchedule(int id, string docId, string returnUrl)
        {
            var vm = new EditScheduleViewModel
            {
                DocId = docId,
                returnUrl = returnUrl,
                Schedule = await _doctorService.GetScheduleById(id)
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> EditSchedule(EditScheduleViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            await _doctorService.UpdateSchedule(viewModel.Schedule);
            return LocalRedirect(viewModel.returnUrl);
        }
        public async Task<IActionResult> DeleteSchedule(int id, string docId, string returnUrl)
        {
            await _doctorService.DeleteScheduleAsync(id);
            return RedirectToAction(nameof(ChangeSchedule), new { id = docId, returnUrl = returnUrl });
        }
        public async Task<IActionResult> Remove(string Id)
        {
            var user = await _userStore.FindByIdAsync(Id, CancellationToken.None);
            if(user != null && user.Email != "admin@account.by")
            {
                var count = await _dbContext.UserTokens.Where(f => f.UserId == Id).CountAsync();
                _logger.LogDebug($"Count tokens with Id {Id}: {count}");
                _dbContext.UserTokens.RemoveRange(_dbContext.UserTokens.Where(f => f.UserId == Id));
                // TODO Удалять все данные связанные с пользюком
                IdentityResult result;
                if(await _userManager.IsInRoleAsync(user, "Pacient"))
                {
                    result = await _userService.DeletePacient(user);
                }
                else if (await _userManager.IsInRoleAsync(user, "Doctor"))
                {
                    result = await _userService.DeleteDoctor(user);
                }
                else
                {
                    result = await _userService.DeleteAdmin(user);
                }
                if (!result.Succeeded)
                    return Json(new { status = "error", errors = result.Errors, message = "Cannot delete user" });
            }
            return Ok(new { status = "success" });
        }
        [HttpGet]
        public async Task<IActionResult> ChangeAddress(string Id, string returnUrl)
        {
            var address = await _userService.GetUserAddress(Id);
            var vm = new AddressViewModel
            {
                UserId = Id,
                returnUrl = returnUrl,
                Country = address.Country?.FullName,
                ApartmentNumber = address?.ApartmentNumber,
                District = address?.District?.Name,
                HomeNumber = address?.HomeNumber,
                PostalCode = address?.PostalCode,
                Region = address?.Region?.Name,
                Street = address?.Street?.Name,
                Town = address?.Street?.Name
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> ChangeAddress(AddressViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            await _userService.EditUserAddress(viewModel.UserId, viewModel.ApartmentNumber, viewModel.Country,
                viewModel.District, viewModel.HomeNumber, viewModel.PostalCode, viewModel.Region,
                viewModel.Street, viewModel.Town);
            return LocalRedirect(viewModel.returnUrl);
        }
        private async Task<List<SelectListItem>> GetRoles() => await _roleManager.Roles.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToListAsync();

        public async Task<IActionResult> Details(string Id, string returnUrl)
        {
            if (string.IsNullOrEmpty(Id))
                Id = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(Id);
            if (await _userManager.IsInRoleAsync(user, "Pacient"))
                return RedirectToAction("Details", "Pacients", new {id = Id, returnUrl = returnUrl});
            if (await _userManager.IsInRoleAsync(user, "Doctor"))
                return RedirectToAction("Details", "Doctors", new { id = Id, returnUrl = returnUrl } );
            return View(new AdminViewModel
            {
                User = user,
                ReturnUrl = returnUrl
            });
        }
    }
}
