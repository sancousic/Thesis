using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class AddDiagnoseHistory
    {
        public string ReurnUrl { get; set; }
        public int DiagnoseId { get; set; }
        public string PacientId { get; set; }
        public DiagnoseHistory History { get; set; }
    }
}
