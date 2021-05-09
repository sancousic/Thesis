using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Services;
using ThesisProject.WebApp.Models;
using ThesisProject.WebApp.Models.Home;
using Microsoft.EntityFrameworkCore;

namespace ThesisProject.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDoctorService _doctorService;

        public HomeController(ILogger<HomeController> logger, IDoctorService doctorService)
        {
            _logger = logger;
            _doctorService = doctorService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Specialities()
        {
            var vm = new SpecialitiesViewModel
            {
                Specialities = await _doctorService.GetSpecialities().Select(x => x).ToListAsync()
            };
            return View(vm);
        }
        public async Task<IActionResult> DoctorList(int specId)
        {
            var docs = await _doctorService.GetDoctorsBySpec(specId).ToArrayAsync();

            return View(new HomeDoctorsViewModel { Doctors = docs });
        }
        public async Task<IActionResult> Schedule(string Id)
        {
            return View();
        }
        public async Task<IActionResult> Tickets(string Id)
        {
            return View();
        }
        public async Task<IActionResult> SignTicket()
        {
            return Ok();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
