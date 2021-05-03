using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class Examination
    {
        [Key]
        public int Id { get; set; }
        public DateTime ExaminationDate { get; set; }
        public Doctor Doctor { get; set; }
        public string Type { get; set; }
        public string Result { get; set; }
    }
}
