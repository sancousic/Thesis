using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class Diagnose
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<DiagnoseHistory> DiagnoseHistorie { get; set; }
        public Doctor DoctorEstablishe { get; set; }
        public DateTime EstablisheDate { get; set; }
        public Doctor DoctorConfirm { get; set; }
        public DateTime ConfirmDate { get; set; }
    }
}
