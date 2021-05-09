using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.Data.Services
{
    public interface IPacientService
    {
        Task<Pacient> GetPacientByIdAsync(string Id);
    }
}
