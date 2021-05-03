using System;
using System.Collections.Generic;
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
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
