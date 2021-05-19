using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Pacients
{
    public class PacientIndexViewModel
    {
        public PacientSearchViewModel Search { get; set; }
        public IEnumerable<Pacient> Pacients { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
    public class PacientSearchViewModel
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
    }
}
