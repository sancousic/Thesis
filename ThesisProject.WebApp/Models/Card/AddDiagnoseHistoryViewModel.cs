using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class AddDiagnoseHistoryViewModel
    {
        public string ReturnUrl { get; set; }
        public int DiagnoseId { get; set; }
        public DiagnoseHistory History { get; set; }
    }
}
