using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Pacient Pacient { get; set; }
        public ICollection<PacientVaccination> Vaccinations { get; set; }
        public ICollection<Examination> Examinations { get; set; }
        public ICollection<Allergy> Allergies { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
