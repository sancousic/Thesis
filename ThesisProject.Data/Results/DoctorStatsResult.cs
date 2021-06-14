using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Results
{
    public class DoctorStatsResult
    {
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalTickets { get; set; }
        public int TotalSchedules { get; set; }
        public TimeSpan AvgTicketTime { get; set; }
        public IEnumerable<DoctorStatsResultItem> DayStats { get; set; }
    }
    public class DoctorStatsResultItem
    {
        public DateTime Date { get; set; }
        public int TicketsCout { get; set; }
        public int ScheduleCount { get; set; }
    }
}
