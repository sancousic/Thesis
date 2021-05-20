using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Home
{
    public class EditScheduleViewModel
    {
        public string DocId { get; set; }
        public string returnUrl { get; set; }
        public Schedule Schedule { get; set; }
    }
}
