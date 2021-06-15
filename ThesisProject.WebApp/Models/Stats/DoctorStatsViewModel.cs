using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Results;

namespace ThesisProject.WebApp.Models.Stats
{
    public class DoctorStatsViewModel
    {
        public string Id { get; set; }
        public DoctorStatsResult Stats { get; set; }
        public string ReturnUrl { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Начало")]
        public DateTime Start { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Конец")]
        public DateTime End { get; set; }
    }
}
