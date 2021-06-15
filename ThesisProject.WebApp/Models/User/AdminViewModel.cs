using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.User
{
    public class AdminViewModel
    {
        public AppUser User { get; set; }
        public  string ReturnUrl { get; set; }
    }
}
