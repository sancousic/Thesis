﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain.Address
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
    }
}
