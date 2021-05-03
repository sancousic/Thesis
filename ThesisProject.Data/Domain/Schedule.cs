using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Time { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
