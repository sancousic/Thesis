﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Почта")]
        public string Mail { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
    }
}
