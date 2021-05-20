using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class Allergy
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Дата установления")]
        public DateTime DateOfIssue { get; set; }
        public Card Card { get; set; }
    }
}
