using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Home
{
    public class HomeDoctorsViewModel
    {
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}
