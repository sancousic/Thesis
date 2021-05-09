using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.User
{
    public class EditUserViewModel
    {
        public EditUserViewModel(AppUser user, string role)
        {
            Role = role;
            Name1 = user.Name1;
            Name2 = user.Name2;
            Name3 = user.Name3;
        }
        public EditUserViewModel(Doctor doc, string role, IEnumerable<string> branches,
            IEnumerable<string> specs) : this(doc as AppUser, role)
        {
            Branch = doc.Branch.Name;
            Speciality = doc.Speciality.Name;
            Branches = branches;
            Specialities = specs;
            CabinetNumber = doc.Cabinet.Number;
        }
        public string Role { get; set; }
        [Required]
        public string Name1 { get; set; }
        [Required]
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string ContactPhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string ContactEmail { get; set; }
        public string Branch { get; set; }
        public IEnumerable<string> Branches { set; get; }
        public string Speciality { get; set; }
        public IEnumerable<string> Specialities { get; set; }
        public int CabinetNumber { get; set; }
    }
}
