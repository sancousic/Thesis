using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class AddDiagnoseViewModel
    {
        public string ReturnUrl { get; set; }
        public Diagnose Diagnose { get; set; }
        public string PacientId { get; set; }
        public DiagnoseHistory History { get; set; }
    }
}
