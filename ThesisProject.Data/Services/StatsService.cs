using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Results;

namespace ThesisProject.Data.Services
{
    public class StatsService: IStatsService
    {
        private readonly AppDbContext _dbContext;

        public StatsService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<DoctorStatsResult> GetDoctorStats(string Id, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<IssueStatsResult> GetIssueStats(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
