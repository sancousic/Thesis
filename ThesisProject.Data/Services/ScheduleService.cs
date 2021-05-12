using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Results;

namespace ThesisProject.Data.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly AppDbContext _dbContext;
        public ScheduleService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Schedule>> GetFreeTickets(string doctorId, DateTime date)
        {
            var tikets = _dbContext.Tickets.Where(x => x.TicketDate == date)
                .Where(x => x.Schedule.Doctor.Id == doctorId)
                .Select(x => x.Schedule).ToList();

            var schedules = _dbContext.Schedules
                .Where(x => x.DayOfWeek == date.DayOfWeek)
                .AsEnumerable()
                .Except(tikets).Select(x => x)
                .ToList();

            
            return schedules;
        }

        public async Task<IEnumerable<FreeTicketsCountResult>> GetFreeTicketsCount(string doctorId, DateTime start, DateTime end)
        {
            var schCount = _dbContext.Schedules
                .AsEnumerable()
                .GroupBy(x => x.DayOfWeek)
                .ToDictionary(x => x.Key, y => y.Count());
            //var schCount = await (from sch in _dbContext.Schedules
            //               group sch by sch.DayOfWeek into gr)
            //               .ToDictionaryAsync(x => x.Name, x => x.Count());
            var query = from ticket in _dbContext.Tickets
                        where ticket.TicketDate >= start && ticket.TicketDate <= end
                        group ticket by ticket.TicketDate into gr
                        select new FreeTicketsCountResult { Start = gr.Key, Title = gr.Count() };
            var list = query.ToList();
            var res = new List<FreeTicketsCountResult>();
            for (DateTime i = start; i < end; i += TimeSpan.FromDays(1))
            {
                if (i.Date > DateTime.Now && schCount.ContainsKey(i.DayOfWeek))
                {
                    var daycount = schCount[i.DayOfWeek];
                    var talons1 = query.ToList();
                    var talons = list.Where(x => x.Start.Date == i.Date).Select(x => x.Title).FirstOrDefault();
                    res.Add(new FreeTicketsCountResult
                    {
                        Start = i - (i - i.Date),
                        End = i.Date + TimeSpan.FromHours(1),
                        Title = daycount - talons
                    });
                }

            }
            return res;
        }
    }
}
