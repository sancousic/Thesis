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
        public async Task<IActionResult> Details(string id, string returnUrl)
        {
            var doc = await _doctorService.GetDoctorByIdAsync(id);
            var vm = new DetailsDoctorViewModel
            {
                Doctor = doc,
                ReturnUrl = returnUrl
            };
            return View(vm);
        }
        public async Task<IActionResult> Edit(string Id, string returnUrl)
        {
            var vm = new DoctorEditViewModel();
            vm.ReturnUrl = returnUrl;
            var doc = await _doctorService.GetDoctorByIdAsync(Id);
            var specs = await _doctorService.GetSpecialities()
                    .Select(x => x.Name).ToListAsync();
            var branches = await _doctorService.GetBranches()
                .Select(x => x.Name).ToListAsync();
            vm.EditModel = new Models.User.EditUserViewModel(doc, "Doctor", branches, specs);
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(DoctorEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            var docModel = viewModel.EditModel;
            await _doctorService.UpdateAsync(docModel.Id, docModel.Name1, docModel.Name2,
                    docModel.Name3, docModel.Branch, docModel.Speciality, docModel.ContactEmail,
                    docModel.ContactPhoneNumber, docModel.CabinetNumber);
            if(!string.IsNullOrEmpty(viewModel.ReturnUrl))
            {
                return LocalRedirect(viewModel.ReturnUrl);
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Stats(string Id)
        {
            return View();
        }
    }
}
