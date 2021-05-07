using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThesisProject.Data.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace ThesisProject.WebApp.Models.Doctors
{
    public class DoctorSearchViewModel
    {
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Отделение")]
        public string Branch { get; set; }
        [Display(Name = "Специальность")]
        public string Speciality { get; set; }
        public ICollection<string> Branches { get; set; }
        public ICollection<string> Specialities { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}
