using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Pacients
{
    public class PacientInfoViewModel
    {
        public string returnUrl { get; set; }
        public Pacient Pacient { get; set; }
    }
}
