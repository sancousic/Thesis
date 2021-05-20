using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.WebApp.Models.User;

namespace ThesisProject.WebApp.Models.Doctors
{
    public class DoctorEditViewModel
    {
        public string ReturnUrl { get; set; }
        public EditUserViewModel EditModel { get; set; }
    }
}
