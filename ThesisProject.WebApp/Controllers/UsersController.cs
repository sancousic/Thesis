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

        public UsersController(IIdentityService identityService, IUserStore<AppUser> userStore,
            AppDbContext dbContext, ILogger<UsersController> logger, SignInManager<AppUser> signInManager,
            UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _identityService = identityService;
            _userStore = userStore;
            _dbContext = dbContext;
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
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
        public async Task<IActionResult> CreateDoctor()
        {
            return View();
        }
        public async Task<IActionResult> CreatePacient()
        {
            return View();
        }
        public async Task<IActionResult> Create(string returnUrl = null)
        {
            return View(new CreateUserModel { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserModel createUserModel)
        {
            createUserModel.ReturnUrl ??= Url.Content("~/");
            if(ModelState.IsValid)
            {
                var user = new AppUser { UserName = createUserModel.Email, Email = createUserModel.Email };
                var result = await _userManager.CreateAsync(user, createUserModel.Password);
                if (result.Succeeded)
                {
                    var a = await _userManager.AddToRoleAsync(user, "Pacient");
                    _logger.LogInformation("User created a new account with password.");

                    return LocalRedirect(createUserModel.ReturnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(createUserModel);
        }
        public async Task<IActionResult> ChangeRole()
        {
            return View();
        }
        public async Task<IActionResult> Edit()
        {
            return View();
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
    }
}
