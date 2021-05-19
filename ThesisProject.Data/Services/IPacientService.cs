﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Domain.Address;

namespace ThesisProject.Data.Services
{
    public interface IPacientService
    {
        Task<Pacient> GetPacientByIdAsync(string Id);
        IQueryable<Pacient> GetPacients(int skip = -1, int take = -1);
        Task<Addresses> GetPacientAddress(string pacientId);
        IQueryable<Pacient> SearchPacient(string name, string cardNumber, string address, int skip = -1, int take = -1);
    }
}
