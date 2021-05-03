using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class PacientVaccination
    {
        [Key]
        public int Id { get; set; }
        public Card Card { get; set; }
        public Vaccination Vaccination { get; set; }
        public string Result { get; set; }
    }
}
