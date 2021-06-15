using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Services;
using ThesisProject.WebApp.Models.Stats;

namespace ThesisProject.WebApp.Controllers
{
    public class StatsController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IStatsService _statsService;
        private readonly UserManager<AppUser> _userManager;

        public StatsController(ILogger<UsersController> logger, IStatsService statsService, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _statsService = statsService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DiagnoseStats(string returnUrl)
        {
            var now = DateTime.Now;
            var vm = new DiagnoseStatsViewModel
            {
                Start = new DateTime(now.Year, now.Month, 1),
                End = now.Date,
                ReturnUrl = returnUrl
            };
            vm.Stats = await _statsService.GetIssueStats(vm.Start, vm.End);
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> DiagnoseStats(DiagnoseStatsViewModel viewModel)
        {
            viewModel.Stats = await _statsService.GetIssueStats(viewModel.Start, viewModel.End);
            return View(viewModel);
        }

    }
}
