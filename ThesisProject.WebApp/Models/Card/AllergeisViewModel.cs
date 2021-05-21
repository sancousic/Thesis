using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class AllergeisViewModel
    {
        public string returnUrl { get; set; }
        public IEnumerable<Allergy> Allergies { get; set; }
        public string PacientId { get; set; }
        public int CardId { get; set; }
        public string Search { get; set; }
    }
}
