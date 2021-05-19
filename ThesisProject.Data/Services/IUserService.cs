using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain.Address;

namespace ThesisProject.Data.Services
{
    public interface IUserService
    {
        Task<Addresses> GetUserAddress(string userId);
    }
}
