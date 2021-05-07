﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThesisProject.Data;

namespace ThesisProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210503151750_ticket")]
    partial class ticket
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Address.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<string>("ShortName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Allergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<int?>("ContactsId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset>("LastLoginDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name1")
                        .HasColumnType("longtext");

                    b.Property<string>("Name2")
                        .HasColumnType("longtext");

                    b.Property<string>("Name3")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ContactsId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Cabinet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cabinets");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Contacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Diagnose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ConfirmDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DoctorConfirmId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DoctorEstablisheId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("EstablisheDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DoctorConfirmId");

                    b.HasIndex("DoctorEstablisheId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.DiagnoseHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Conclusion")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ConclusionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DiagnoseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiagnoseId");

                    b.ToTable("DiagnoseHistories");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Examination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("ExaminationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Result")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Examinations");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.PacientVaccination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasColumnType("longtext");

                    b.Property<int?>("VaccinationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("VaccinationId");

                    b.ToTable("PacientVaccinations");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Passport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Authority")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Identity")
                        .HasColumnType("longtext");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Passports");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time(6)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("PacientId")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TicketDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("PacientId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Vaccination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Vaccinations");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Doctor", b =>
                {
                    b.HasBaseType("ThesisProject.Data.Domain.AppUser");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("SpecialityId")
                        .HasColumnType("int");

                    b.HasIndex("BranchId");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Pacient", b =>
                {
                    b.HasBaseType("ThesisProject.Data.Domain.AppUser");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("SomeData")
                        .HasColumnType("longtext");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("Pacients");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThesisProject.Data.Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Allergy", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Card", "Card")
                        .WithMany("Allergies")
                        .HasForeignKey("CardId");

                    b.Navigation("Card");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.AppUser", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Contacts", "Contacts")
                        .WithMany()
                        .HasForeignKey("ContactsId");

                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Diagnose", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Doctor", "DoctorConfirm")
                        .WithMany()
                        .HasForeignKey("DoctorConfirmId");

                    b.HasOne("ThesisProject.Data.Domain.Doctor", "DoctorEstablishe")
                        .WithMany()
                        .HasForeignKey("DoctorEstablisheId");

                    b.Navigation("DoctorConfirm");

                    b.Navigation("DoctorEstablishe");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.DiagnoseHistory", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Diagnose", null)
                        .WithMany("DiagnoseHistorie")
                        .HasForeignKey("DiagnoseId");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Examination", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Card", null)
                        .WithMany("Examinations")
                        .HasForeignKey("CardId");

                    b.HasOne("ThesisProject.Data.Domain.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.PacientVaccination", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Card", "Card")
                        .WithMany("Vaccinations")
                        .HasForeignKey("CardId");

                    b.HasOne("ThesisProject.Data.Domain.Vaccination", "Vaccination")
                        .WithMany()
                        .HasForeignKey("VaccinationId");

                    b.Navigation("Card");

                    b.Navigation("Vaccination");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Passport", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Address.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Ticket", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Card", null)
                        .WithMany("Tickets")
                        .HasForeignKey("CardId");

                    b.HasOne("ThesisProject.Data.Domain.Pacient", "Pacient")
                        .WithMany()
                        .HasForeignKey("PacientId");

                    b.HasOne("ThesisProject.Data.Domain.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.Navigation("Pacient");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Doctor", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("ThesisProject.Data.Domain.AppUser", null)
                        .WithOne()
                        .HasForeignKey("ThesisProject.Data.Domain.Doctor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThesisProject.Data.Domain.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId");

                    b.Navigation("Branch");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Pacient", b =>
                {
                    b.HasOne("ThesisProject.Data.Domain.Card", "Card")
                        .WithOne("Pacient")
                        .HasForeignKey("ThesisProject.Data.Domain.Pacient", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThesisProject.Data.Domain.AppUser", null)
                        .WithOne()
                        .HasForeignKey("ThesisProject.Data.Domain.Pacient", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Card", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("Examinations");

                    b.Navigation("Pacient");

                    b.Navigation("Tickets");

                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("ThesisProject.Data.Domain.Diagnose", b =>
                {
                    b.Navigation("DiagnoseHistorie");
                });
#pragma warning restore 612, 618
        }
    }
}