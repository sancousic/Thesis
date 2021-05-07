using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Services;
using ThesisProject.WebApp.Models.Doctors;

namespace ThesisProject.WebApp.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IDoctorService _doctorService;

        public DoctorsController(ILogger<UsersController> logger, IDoctorService doctorService)
        {
            _logger = logger;
            _doctorService = doctorService;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new DoctorSearchViewModel();
            vm.Branches = await _doctorService.GetBranches().Select(x => x.Name).ToListAsync();
            vm.Specialities = await _doctorService.GetSpecialities().Select(x => x.Name).ToListAsync();
            vm.Doctors = await _doctorService.GetDoctors().ToListAsync();
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Index(DoctorSearchViewModel viewModel)
        {
            viewModel.Branches = await _doctorService.GetBranches().Select(x => x.Name).ToListAsync();
            viewModel.Specialities = await _doctorService.GetSpecialities().Select(x => x.Name).ToListAsync();
            viewModel.Doctors = await _doctorService.GetDoctors(viewModel.Name, viewModel.Speciality, viewModel.Branch).ToListAsync();
            return View(viewModel);
        }
        public async Task<IActionResult> Details(string id)
        {
            var doc = await _doctorService.GetDoctorByIdAsync(id);
            return View(doc);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string Id)
        {
            var a = await _doctorService.DeleteAsync(Id);
            return Ok();
        }
        public async Task<IActionResult> Edit(string Id)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(DoctorEditViewModel viewModel)
        {
            return View();
        }
    }
}
