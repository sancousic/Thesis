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

        public UsersController(IIdentityService identityService, IUserStore<AppUser> userStore,
            AppDbContext dbContext, ILogger<UsersController> logger, SignInManager<AppUser> signInManager,
            UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IDoctorService doctorService)
        {
            _identityService = identityService;
            _userStore = userStore;
            _dbContext = dbContext;
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _doctorService = doctorService;
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
        public async Task<IActionResult> Edit(string Id)
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
            }
            //if(role == "Pacient")
            //{
            //    var vm = new EditUserViewModel();
            //    return View("EditPacient", vm);
            //}
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel viewModel)
        {
            if (ModelState.IsValid)
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
            
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ChangeSchedule(string id, string returnUrl)
        {
            var viewModel = new ChangeScheduleViewModel
            {
                ReturnUrl = returnUrl,
                DoctorId = id
            };
            viewModel.Schedules = await _doctorService.GetScheduleByDocId(id).ToArrayAsync();
            viewModel.Doctor = await _doctorService.GetDoctorByIdAsync(id);
            return View(viewModel);
        }
        public async Task<IActionResult> AddSchedule(string docId, Schedule schedule)
        {
            await _doctorService.AddToSchedules(docId, schedule);
            return RedirectToAction(nameof(ChangeSchedule), new { id = docId });
        }
        public async Task<IActionResult> EditSchedule(int id, string docId, string returnUrl)
        {
            ViewBag.Id = docId;
            ViewBag.returnUrl = returnUrl;
            var schedule = await _doctorService.GetScheduleById(id);
            return View(schedule);
        }
        [HttpPost]
        public async Task<IActionResult> EditSchedule(Schedule schedule, string docId, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(schedule);

            await _doctorService.UpdateSchedule(schedule);
            return RedirectToAction(nameof(ChangeSchedule), new { id = docId, returnUrl = returnUrl });
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
                var result = await _userStore.DeleteAsync(user, CancellationToken.None);
                if (!result.Succeeded)
                    return Json(new { status = "error", errors = result.Errors, message = "Cannot delete user" });
            }

            return Ok();
        }
        private async Task<List<SelectListItem>> GetRoles() => await _roleManager.Roles.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToListAsync();
        
    }
}
