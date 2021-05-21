using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Services;

namespace ThesisProject.WebApp.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServicesService _servicesService;

        public ServicesController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Vaccinations()
        {
            var vaccinations = await _servicesService.GetVaccinations(false).ToArrayAsync();
            return View(vaccinations);
        }
        public ActionResult AddVaccination()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddVaccination(Vaccination vaccination)
        {
            if (!ModelState.IsValid)
                return View(vaccination);
            try
            {
                vaccination.Date = DateTime.Now.Date;
                vaccination.IsActive = true;
                await _servicesService.AddVaccination(vaccination);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(vaccination);
            }
            return RedirectToAction(nameof(Vaccinations));
        }
    }
}
