using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThesisProject.WebApp.Models.Home
{
    public class PacientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
