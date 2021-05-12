using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Results;

namespace ThesisProject.Data.Services
{
    public interface IScheduleService
    {
        Task<IEnumerable<FreeTicketsCountResult>> GetFreeTicketsCount(string doctorId, DateTime start, DateTime end);
        Task<IEnumerable<Schedule>> GetFreeTickets(string doctorId, DateTime date);
    }
}
