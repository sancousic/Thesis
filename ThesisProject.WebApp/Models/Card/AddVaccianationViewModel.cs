using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class AddVaccianationViewModel
    {
        public IEnumerable<Vaccination> Vaccinations { get; set; }
        public string ReturnUrl { get; set; }
        public string PacientId { get; set; }
        public int Vaccination { get; set; }
        [Required]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Результат")]
        public string Result { get; set; }
    }
}
