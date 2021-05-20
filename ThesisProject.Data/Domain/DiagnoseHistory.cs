using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class DiagnoseHistory
    {
        public int Id { get; set; }
        [Display(Name = "Заключение")]
        public string Conclusion { get; set; }
        [Display(Name = "Дата")]
        public DateTime ConclusionDate { get; set; }
    }
}
