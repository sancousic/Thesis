﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain.Address;

namespace ThesisProject.Data.Domain
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "Дата регистрации")]
        public DateTime RegistrationDate { get; set; }
        [Display(Name = "Последний вход")]
        public DateTime LastLoginDate { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string Name1 { get; set; }
        [Required]
        [Display(Name = "Фмалилия")]
        public string Name2 { get; set; }
        [Display(Name = "Отчество")]
        public string Name3 { get; set; }
        [Display(Name = "Пол")]
        public Gender Male { get; set; }
        public int? AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Addresses Address { get; set; }
        public Contacts Contacts { get; set; }
    }
}
