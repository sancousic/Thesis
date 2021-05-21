using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class CardViewModel
    {
        public string ReturnUrl { get; set; }
        public Data.Domain.Card Card { get; set; }
        public Pacient Pacient { get; set; }
    }
}
