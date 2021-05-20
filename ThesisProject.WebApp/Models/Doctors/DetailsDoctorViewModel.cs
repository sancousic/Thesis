using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Doctors
{
    public class DetailsDoctorViewModel
    {
        public string ReturnUrl { get; set; }
        public Doctor Doctor { get; set; }
    }
}
