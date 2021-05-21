using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class DiagnoseHistoryViewModel
    {
        public string ReturnUrl { get; set; }
        public string PacientId { get; set; }
        public int? DiagnoseId { get; set; }
        public Diagnose Diagnose { get; set; }
        public string Search { get; set; }
        public IEnumerable<DiagnoseHistory> History { get; set; }
    }
}
