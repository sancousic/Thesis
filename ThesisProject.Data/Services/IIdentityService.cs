using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Results;

namespace ThesisProject.Data.Services
{
    public interface IIdentityService
    {
        IQueryable<GetUserResult> GetUsers();
    }
}
