﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    [Table("Doctors")]
    public class Doctor : AppUser
    {
        [Display(Name = "Отделение")]
        public Branch Branch { get; set; }
        [Display(Name = "Специальность")]
        public Speciality Speciality { get; set; }
        [Display(Name = "Кабинет")]
        public Cabinet Cabinet { get; set; }
        public IEnumerable<Schedule> Schedule { get; set; }
    }
}
