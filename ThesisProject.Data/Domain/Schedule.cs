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
        public TimeSpan Time { get; set; }
        public TimeSpan Duration { get; set; }
        public Doctor Doctor { get; set; }
    }
}
