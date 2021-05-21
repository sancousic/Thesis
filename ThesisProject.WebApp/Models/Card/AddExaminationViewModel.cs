using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class AddExaminationViewModel
    {
        public Examination Examination { get; set; }
        public string ReturnUrl { get; set; }
        public string PacientId { get; set; }
    }
}
