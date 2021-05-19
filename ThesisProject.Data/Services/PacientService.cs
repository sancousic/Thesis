using LinqKit;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Domain.Address;

namespace ThesisProject.Data.Services
{
    public class PacientService : IPacientService
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public PacientService(AppDbContext dbContext, UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public async Task<Pacient> GetPacientByIdAsync(string Id)
        {
            return await _dbContext.Pacients.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public IQueryable<Pacient> GetPacients(int skip = -1, int take = -1)
        {
            var query = _dbContext.Pacients.AsQueryable();
            if (skip > 0)
            {
                query = query.Skip(skip);
            }
            if (take > 0)
            {
                query = query.Take(take);
            }
            //if (includeCard)
            //{
            //    query = query.Include(x => x.Card).Select(x=>x);
            //}
            //if(includeAddress)
            //{
            //    query = query.Include(x => x.Address)
            //        .Include(x => x.Address.Country)
            //        .Include(x => x.Address.Region)
            //        .Include(x => x.Address.District)
            //        .Include(x => x.Address.Street)
            //        .Include(x => x.Address.Town);
            //}
            return query;
        }
        public async Task<Addresses> GetPacientAddress(string pacientId)
        {
            return await _dbContext.Addresses.Where(x => x.User.Id == pacientId).FirstOrDefaultAsync();
        }
        public IQueryable<Pacient> SearchPacient(string name, string cardNumber, string address,
            int skip = -1, int take = -1)
        {
            var query = _dbContext.Pacients.Select(x => x);
            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(HasName(name));
            }
            if(!string.IsNullOrEmpty(cardNumber))
            {
                query = query.Where(x => x.Card.Number.ToString().StartsWith(cardNumber));
            }
            if(!string.IsNullOrEmpty(address))
            {
                query = query.Where(HasAddress(address));
            }
            if(skip > 0)
            {
                query = query.Skip(skip);
            }
            if(take > 0)
            {
                query = query.Take(take);
            }
            //query = query.Select(x => x);
            //if(inclideCard)
            //{
            //    query = query.Include(x => x.Card);
            //}
            //if(includeAddress)
            //{
            //    query = query.Include(x => x.Address)
            //        .Include(x => x.Address.Country)
            //        .Include(x => x.Address.District)
            //        .Include(x => x.Address.Region)
            //        .Include(x => x.Address.Street)
            //        .Include(x => x.Address.Town);
            //}
            return query.Select(x => x);
        }
        private Expression<Func<Pacient, bool>> HasName(string name)
        {
            var predicate = PredicateBuilder.New<Pacient>(true);

            if (!string.IsNullOrEmpty(name))
            {
                var names = name.Trim().ToLower().Split(' ');

                foreach (var n in names)
                {
                    predicate.Or(c => c.Name1.ToLower().Contains(n));
                    predicate.Or(c => c.Name2.ToLower().Contains(n));
                    predicate.Or(c => c.Name3.ToLower().Contains(n));
                }
            }

            return predicate;
        }
        private Expression<Func<Pacient, bool>> HasAddress(string address)
        {
            var predicate = PredicateBuilder.New<Pacient>(true);

            var addresses = address.Trim().ToLower().Split(' ');

            foreach(var ad in addresses)
            {
                predicate.Or(x => x.Address.Country.FullName.Contains(ad));
                predicate.Or(x => x.Address.District.Name.Contains(ad));
                predicate.Or(x => x.Address.District.Name.Contains(ad));
                predicate.Or(x => x.Address.Region.Name.Contains(ad));
                predicate.Or(x => x.Address.Street.Name.Contains(ad));
                predicate.Or(x => x.Address.Town.Name.Contains(ad));
                predicate.Or(x => x.Address.HomeNumber.ToString().Contains(ad));
            }
            return predicate;
        }
    }
}
