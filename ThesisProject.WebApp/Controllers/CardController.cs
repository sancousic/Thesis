using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Services;
using ThesisProject.WebApp.Models.Card;

namespace ThesisProject.WebApp.Controllers
{
    public class CardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICardService _cardService;
        private readonly IUserService _userService;
        private readonly IPacientService _pacientService;
        private readonly IServicesService _servicesService;

        public CardController(UserManager<AppUser> userManager, ICardService cardService,
            IUserService userService, IPacientService pacientService, IServicesService servicesService)
        {
            _userManager = userManager;
            _cardService = cardService;
            _userService = userService;
            _pacientService = pacientService;
            _servicesService = servicesService;
        }

        public async Task<IActionResult> Index(string Id, string returnUrl)
        {
            var pacient = await _pacientService.GetPacientByIdAsync(Id, true, true);
            var vm = new CardViewModel
            {
                Pacient = pacient,
                Card = await _cardService.GetCardByIdAsync(Id),
                ReturnUrl = returnUrl
            };
            return View(vm);
        }
        public async Task<IActionResult> Search(string Id, string returnUrl, string search)
        {
            var pacient = await _pacientService.GetPacientByIdAsync(Id, false, false);
            var card = await _cardService.GetCardByIdAsync(Id);
            IQueryable<Allergy> allergy;
            IQueryable<Examination> exam;
            IQueryable<PacientVaccination> vaccinations;
            IQueryable<Diagnose> diagnoses;
            IQueryable<DiagnoseHistory> dHistorys;

            if(string.IsNullOrEmpty(search))
            {
                allergy = _cardService.GetAllergies(card.Id);
                exam = _cardService.GetExaminations(card.Id);
                vaccinations = _cardService.GetPacientVaccinations(card.Id);
                diagnoses = _cardService.GetDiagnoses(card.Id);
                dHistorys = _cardService.GetDiagnoseHistories(card.Id);
            }
            else
            {
                allergy = _cardService.SearchAllergies(card.Id, search);
                exam = _cardService.SearchExaminations(card.Id, search);
                vaccinations = _cardService.SearchPacientVaccinations(card.Id,  search);
                diagnoses = _cardService.SearchDiagnoses(card.Id, search);
                dHistorys = _cardService.SearchDiagnoseHistories(card.Id, search);
            }
            card.Allergies = await allergy.OrderBy(x => x.DateOfIssue).Take(10).ToListAsync();
            card.Examinations = await exam.OrderBy(x => x.ExaminationDate).Take(10).ToListAsync();
            card.Vaccinations = await vaccinations.OrderBy(x => x.Date)
                .Include(x => x.Vaccination).Take(10).ToListAsync();
            card.Diagnoses = await diagnoses.OrderBy(x => x.EstablisheDate).Take(10).ToListAsync();
            var vm = new CardSearchViewModel
            {
                Search = search,
                Pacient = pacient,
                Card = card,
                ReturnUrl = returnUrl,
                AllrgeysCount = await allergy.CountAsync(),
                DiagnoseHistoryCount = await dHistorys.CountAsync(),
                DiggnosesCount = await diagnoses.CountAsync(),
                ExaminationsCount = await exam.CountAsync(),
                VaccinationsCount = await vaccinations.CountAsync()
            };
            vm.DiagnoseHistories = dHistorys.OrderBy(x => x.ConclusionDate).Take(10);

            return View(vm);
        }
        [HttpPost]
        public IActionResult Search(CardSearchViewModel viewModel)
        {
            return RedirectToAction(nameof(Search), new { Id = viewModel.Pacient.Id,
                returnUrl = viewModel.ReturnUrl, search = viewModel.Search });
        }
        public async Task<IActionResult> Allergies(string Id, string returnUrl, string search)
        {
            var card = await _cardService.GetCardByIdAsync(Id);
            var vm = new AllergeisViewModel
            {
                PacientId = Id,
                returnUrl = returnUrl,
                CardId = card.Id,
                Search = search
            };
            if (!string.IsNullOrEmpty(search))
                vm.Allergies = await _cardService.SearchAllergies(card.Id, search)
                    .OrderBy(x => x.DateOfIssue).ToListAsync();
            else
            {
                vm.Allergies = await _cardService.GetAllergies(card.Id)
                    .OrderBy(x => x.DateOfIssue).ToListAsync();
            }
            return View(vm);
        }
        [HttpPost]
        public IActionResult Allergies(AllergeisViewModel viewModel)
        {
            return RedirectToAction(nameof(Allergies), new
            {
                Id = viewModel.PacientId,
                returnUrl = viewModel.returnUrl,
                search = viewModel.Search
            });
        }
        public IActionResult AddAllergy(string Id, int cardId, string returnUrl)
        {
            return View(new AddAlergyViewModel
            {
                CardId = cardId,
                PacientId = Id,
                ReturnUrl = returnUrl,
                Allergy = new Allergy()
            });
        }
        [HttpPost]
        public async Task<IActionResult> AddAllergy(AddAlergyViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            await _cardService.AddAllergy(viewModel.PacientId, viewModel.Allergy);

            return LocalRedirect(viewModel.ReturnUrl);
        }
        public async Task<IActionResult> Vaccinations(string Id, string returnUrl, string search)
        {
            var vm = new VaccinationsViewModel
            {
                PacientId = Id,
                ReturnUrl = returnUrl,
                Search = search
            };
            var card = await _cardService.GetCardByIdAsync(Id);
            if (!string.IsNullOrEmpty(search))
                vm.Vaccinations = await _cardService.SearchPacientVaccinations(card.Id, search)
                    .OrderBy(x => x.Date).Include(x => x.Vaccination).ToListAsync();
            else
            {
                vm.Vaccinations = await _cardService.GetPacientVaccinations(card.Id)
                    .OrderBy(x => x.Date).Include(x =>x.Vaccination).ToListAsync();
            }
            return View(vm);
        }
        [HttpPost]
        public IActionResult Vaccinations(VaccinationsViewModel viewModel)
        {
            return RedirectToAction(nameof(Vaccinations), new
            {
                Id = viewModel.PacientId,
                returnUrl = viewModel.ReturnUrl,
                search = viewModel.Search
            });
        }
        public async Task<IActionResult> AddVaccine(string Id, string returnUrl)
        {
            var vaccinations = await _servicesService.GetVaccinations(false).ToArrayAsync();
            var vm = new AddVaccianationViewModel
            {
                PacientId = Id,
                ReturnUrl = returnUrl,
                Vaccinations = vaccinations,
                Date = DateTime.Now.Date
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddVaccine(AddVaccianationViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            var vaccine = await _cardService.GetVaccineById(viewModel.Vaccination);
            await _cardService.AddVaccine(viewModel.PacientId, vaccine,
                viewModel.Date, viewModel.Result);

            return LocalRedirect(viewModel.ReturnUrl);
        }
        public async Task<IActionResult> Examinations(string Id, string returnUrl, string search)
        {
            var vm = new ExaminationViewModel
            {
                PacientId = Id,
                ReturnUrl = returnUrl,
                Search = search
            };
            var card = await _cardService.GetCardByIdAsync(Id);
            if (!string.IsNullOrEmpty(search))
                vm.Examinations = await _cardService.SearchExaminations(card.Id, search)
                    .OrderBy(x => x.ExaminationDate).ToListAsync();
            else
            {
                vm.Examinations = await _cardService.GetExaminations(card.Id)
                    .OrderBy(x => x.ExaminationDate).ToListAsync();
            }
            return View(vm);
        }
        [HttpPost]
        public IActionResult Examinations(ExaminationViewModel viewModel)
        {
            return RedirectToAction(nameof(Examinations), new { Id = viewModel.PacientId,
                returnUrl = viewModel.ReturnUrl, search = viewModel.Search });
        }
        public IActionResult AddExamination(string Id, string returnUrl)
        {
            var vm = new AddExaminationViewModel
            {
                PacientId = Id,
                ReturnUrl = returnUrl,
                Examination = new Examination()
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddExamination(AddExaminationViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            Doctor doc = null;
            if (User.IsInRole("Doctor"))
                doc = await _userManager.GetUserAsync(User) as Doctor;

            await _cardService.AddExamination(viewModel.PacientId, doc, viewModel.Examination);

            return LocalRedirect(viewModel.ReturnUrl);
        }
        public async Task<IActionResult> Diagnoses()
        {
            return View();
        }
        public async Task<IActionResult> DiagnoseHistory(string userId, int diagnoseId,
            string returnUrl, string search)
        {
            return View();
        }
    }
}
