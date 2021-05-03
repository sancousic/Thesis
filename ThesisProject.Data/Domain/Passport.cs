using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisProject.Data.Domain.Address;

namespace ThesisProject.Data.Domain
{
    public class Passport
    {
        [Key]
        public int Id { get; set; }
        public Country Country { get; set; }
        public DateTime Birthday { get; set; }
        public string Number { get; set; }
        public string Authority { get; set; }
        public Gender Gender { get; set; }
        public string Identity { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfExpiry { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}
