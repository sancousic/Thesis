using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    [Table("Pacients")]
    public class Pacient : AppUser
    {
        public string SomeData { get; set; }
        [Display(Name = "Карта")]
        public Card Card { get; set; }
        [Display(Name = "Талоны")]
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
