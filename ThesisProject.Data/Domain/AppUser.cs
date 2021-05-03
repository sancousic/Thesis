using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain
{
    public class AppUser : IdentityUser
    {
        public DateTimeOffset RegistrationDate { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public Contacts Contacts { get; set; }
    }
}
