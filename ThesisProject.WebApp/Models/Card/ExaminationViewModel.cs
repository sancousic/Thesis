using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class ExaminationViewModel
    {
        public string ReturnUrl { get; set; }
        public string PacientId { get; set; }
        public string Search { get; set; }
        public IEnumerable<Examination> Examinations { get; set; }
    }
}
