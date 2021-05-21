﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.Data.Services
{
    public class CardService : ICardService
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public CardService(AppDbContext dbContext, UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public IQueryable<Allergy> GetAllergies(int cardId)
        {
            return _dbContext.Allergies.Where(x => x.Card.Id == cardId);
        }

        public async Task<Card> GetCardByIdAsync(string userId)
        {
            return await _dbContext.Cards.Where(x => x.PacientId == userId).FirstOrDefaultAsync();
        }

        public IQueryable<DiagnoseHistory> GetDiagnoseHistories(int cardId)
        {
            return _dbContext.DiagnoseHistories.Where(x => x.Diagnose.Card.Id == cardId);
        }
        public IQueryable<DiagnoseHistory> GetDiagnosesHistories(int diagnoseId)
        {
            return _dbContext.DiagnoseHistories.Where(x => x.Diagnose.Id == diagnoseId);
        }
        public IQueryable<Diagnose> GetDiagnoses(int cardId)
        {
            return _dbContext.Diagnoses.Where(x => x.Card.Id == cardId);
        }

        public IQueryable<Examination> GetExaminations(int cardId)
        {
            return _dbContext.Examinations.Where(x => x.Card.Id == cardId);
        }

        public IQueryable<PacientVaccination> GetPacientVaccinations(int cardId)
        {
            return _dbContext.PacientVaccinations.Where(x => x.Card.Id == cardId);
        }

        public IQueryable<Vaccination> GetVaccinations()
        {
            return _dbContext.Vaccinations.AsQueryable();
        }

        public IQueryable<Allergy> SearchAllergies(int cardId, string search)
        {
            return GetAllergies(cardId).Where(x => x.Type.Contains(search));
        }

        public IQueryable<Diagnose> SearchDiagnoses(int cardId, string search)
        {
            return GetDiagnoses(cardId).Where(x => x.Name.Contains(search));
        }

        public IQueryable<DiagnoseHistory> SearchDiagnoseHistories(int cardId, string search)
        {
            return GetDiagnoseHistories(cardId)
                .Where(x => x.Diagnose.Name.Contains(search) || x.Conclusion.Contains(search));
        }

        public IQueryable<DiagnoseHistory> SearchDiagnosesHistories(int diagnoseId, string search)
        {
            return GetDiagnosesHistories(diagnoseId).Where(x => x.Conclusion.Contains(search)
                || x.Diagnose.Name == search);
        }

        public IQueryable<Examination> SearchExaminations(int cardId, string search)
        {
            return GetExaminations(cardId).Where(x => x.Type.Contains(search) || x.Result.Contains(search));
        }

        public IQueryable<PacientVaccination> SearchPacientVaccinations(int cardId, string search)
        {
            return GetPacientVaccinations(cardId).Where(x => x.Vaccination.Type.Contains(search)
                || x.Result.Contains(search));
        }

        public async Task AddAllergy(string pacientId, Allergy allergy)
        {
            allergy.Card = await _dbContext.Cards.Where(x => x.Pacient.Id == pacientId).FirstOrDefaultAsync();
            allergy.DateOfIssue = DateTime.Now;
            _dbContext.Allergies.Add(allergy);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddVaccine(string pacientId, Vaccination vaccination, DateTime date, string result)
        {
            var card = await GetCardByIdAsync(pacientId);
            var pv = new PacientVaccination
            {
                Card = card,
                Date = date,
                Result = result,
                Vaccination = vaccination,
            };
            _dbContext.PacientVaccinations.Add(pv);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Vaccination> GetVaccineById(int vaccination)
        {
            return await _dbContext.Vaccinations.Where(x => x.Id == vaccination).FirstOrDefaultAsync();
        }
    }
}