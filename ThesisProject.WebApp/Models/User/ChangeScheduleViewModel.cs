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
        [DataType(DataType.Date)]
        public DayOfWeek Day { get; set; }
        public DateTime Time { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
