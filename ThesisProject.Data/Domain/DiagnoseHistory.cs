using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class DiagnoseHistory
    {
        public int Id { get; set; }
        public string Conclusion { get; set; }
        public DateTime ConclusionDate { get; set; }
    }
}
