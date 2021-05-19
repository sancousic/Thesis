using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Services;
using ThesisProject.WebApp.Models;
using ThesisProject.WebApp.Models.Pacients;

namespace ThesisProject.WebApp.Controllers
{
    public class PacientsController : Controller
    {
        private readonly IPacientService _pacientService;
        private readonly UserManager<AppUser> _userManager;

        public PacientsController(IPacientService pacientService,
            UserManager<AppUser> userManager)
        {
            _pacientService = pacientService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int? page)
        {
            page ??= 1;
            var vm = new PacientIndexViewModel();
            var count = await _pacientService.GetPacients().CountAsync();
            vm.PageViewModel = new PageViewModel(page.Value, 10, count);
            var skip = (page.Value - 1) * vm.PageViewModel.PageSize;
            if (skip > count)
            {
                return NotFound();
            }
            vm.PageViewModel = new PageViewModel(page.Value, 10, count);

            vm.Pacients = _pacientService
                .GetPacients(skip, vm.PageViewModel.PageSize).Include(x=>x.Card);
            vm.Search = new PacientSearchViewModel();
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Index(int? page, PacientSearchViewModel Search)
        {
            page ??= 1;
            var vm = new PacientIndexViewModel { Search = Search };

            var query = _pacientService.SearchPacient(Search.Name,
                Search.CardNumber, Search.Address);

            var count = await query.CountAsync();
            var pvm = new PageViewModel(page.Value, 10, count);
            
            var skip = (page.Value - 1) * pvm.PageSize;
            query = _pacientService.SearchPacient(Search.Name,
                Search.CardNumber, Search.Address, skip, pvm.PageSize);
            if (skip > count)
            {
                return NotFound();
            }

            return View("Index", new PacientIndexViewModel
            {
                Pacients = await query.Include(x => x.Card)
                .Include(x=>x.Address).ToListAsync(),
                PageViewModel = pvm,
                Search = Search
            });
        }
    }
}
