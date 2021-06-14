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
using Microsoft.AspNetCore.Identity;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDoctorService _doctorService;
        private readonly IScheduleService _scheduleService;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ILogger<HomeController> logger, IDoctorService doctorService,
            IScheduleService scheduleService, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _doctorService = doctorService;
            _scheduleService = scheduleService;
            _userManager = userManager;
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
        public async Task<IActionResult> GetEvents(string id, DateTime start, DateTime end)
        {
            var events = await _scheduleService.GetFreeTicketsCount(id, start, end);
            var json = Json(events);
            return json;
        }
        public async Task<IActionResult> Schedule(string Id)
        {
            ViewBag.ID = Id;
            return View();
        }
        public async Task<IActionResult> Tickets(string Id, DateTime date)
        {
            var tickets = (await _scheduleService.GetFreeTickets(Id, date))
                .Select(x => new { Time = x.Time.ToString(@"hh\:mm"), id = x.Id});
            return Json(tickets);
        }
        public async Task<IActionResult> SignTicket(string userName, string docId, int scheduleId, DateTime date)
        {
            var pacient = await _userManager.FindByNameAsync(userName) as Pacient;
            if (await _scheduleService.IsSignedTicket(scheduleId, date))
                return RedirectToAction("PacientTickets", new
                {
                    id = pacient.Id,
                    status = "Талон уже занят.",
                    isError = true
                });
            if (!await _scheduleService.SignTicket(pacient, scheduleId, date))
                return BadRequest();
            var schedule = await _scheduleService.GetScheduleById(scheduleId).Include(x => x.Doctor).FirstOrDefaultAsync();
            return RedirectToAction("PacientTickets", new
            {
                id = pacient.Id,
                status = ("Произведена запись к доктору " + schedule?.Doctor?.Name1 + " " + schedule?.Doctor?.Name2 + string.Format(" {0} {1} {2}", schedule?.Doctor?.Name3, date, schedule.Time))
            });
        }
        public async Task<IActionResult> DoctorTickets(string id, string returnUrl)
        {
            if (id == null)
                id = _userManager.GetUserId(User);
            var tickets = _scheduleService.GetUserTickets(false, docId: id);
            tickets = tickets.Include(x => x.Schedule);
            if (User.IsInRole("Admin"))
            {
                tickets = tickets
                    .Include(x => x.Schedule.Doctor)
                    .Include(x => x.Schedule.Doctor.Cabinet);
            }
            if (User.IsInRole("Admin") || User.IsInRole("Doctor"))
            {
                tickets = tickets.Include(x => x.Pacient);
            }
            return View("Tickets", new TicketsViewModel
            {
                Tickets = await tickets.ToListAsync(),
                ReturnUrl = returnUrl
            });
        }
        public async Task<IActionResult> PacientTickets(string id, string returnUrl, string status, bool isError = false)
        {
            if (string.IsNullOrEmpty(id))
                id = _userManager.GetUserId(User);
            IQueryable<Ticket> source = _scheduleService.GetUserTickets(false, id)
                .Include(x => x.Schedule);
            if (User.IsInRole("Admin") || User.IsInRole("Doctor"))
                source = source.Include(x => x.Pacient);
            if (User.IsInRole("Admin") || User.IsInRole("Pacient"))
                source = source.Include(x => x.Schedule.Doctor)
                    .Include(x => x.Schedule.Doctor.Cabinet);
            TicketsViewModel ticketsViewModel = new TicketsViewModel();
            ticketsViewModel.Tickets = await source.ToListAsync();
            ticketsViewModel.ReturnUrl = returnUrl;
            ticketsViewModel.StatusMessage = status;
            ticketsViewModel.IsError = isError;
            return View("Tickets", ticketsViewModel);
        }
        public async Task<IActionResult> DeleteTicket(int id, string returnUrl)
        {
            returnUrl ??= Url.Content("~/");
            bool res = await _scheduleService.DeleteTicket(id);
            return LocalRedirect(returnUrl);
        }
        public async Task<IActionResult> PacientTicketsHistory(string id)
        {
            return View(nameof(PacientTickets), new { });
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
