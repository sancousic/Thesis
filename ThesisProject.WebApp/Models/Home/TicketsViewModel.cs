using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Home
{
    public class TicketsViewModel
    {
        public string ReturnUrl { get; set; }
        public string Header { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
