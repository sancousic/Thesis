using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Results;

namespace ThesisProject.Data.Services
{
    public interface IStatsService
    {
        Task<DoctorStatsResult> GetDoctorStats(string Id, DateTime start, DateTime end);
        Task<IssueStatsResult> GetIssueStats(DateTime start, DateTime end);
    }
}
