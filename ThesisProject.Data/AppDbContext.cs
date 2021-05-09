using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThesisProject.Data.Domain;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Extensions;
using System;

namespace ThesisProject.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));

            options.UseMySql(config.GetConnectionString("DefaultConnection"), serverVersion);
        }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<DiagnoseHistory> DiagnoseHistories { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<PacientVaccination> PacientVaccinations { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
