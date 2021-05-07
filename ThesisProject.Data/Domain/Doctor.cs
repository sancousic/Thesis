using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    [Table("Doctors")]
    public class Doctor : AppUser
    {
        public Branch Branch { get; set; }
        public Speciality Speciality { get; set; }
        public IEnumerable<Schedule> Schedule { get; set; }
    }
}
