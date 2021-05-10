using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.User
{
    public class ChangeScheduleViewModel
    {
        public string ReturnUrl { get; set; }
        public IEnumerable<Schedule> Schedules { get; set; }
        public string DoctorId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan Duration { get; set; }
        public Doctor Doctor { get; set; }
    }
}
