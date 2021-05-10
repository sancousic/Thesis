using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisProject.Data.Domain.Address
{
    public class Addresses
    {
        [Key]
        public int Id { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public District District { get; set; }
        public Town Town { get; set; }
        public TownType TownType { get; set; }
        public Street Street { get; set; }
        public StreetType StreetType { get; set; }
        public int HomeNumber { get; set; }
        public char HomeIndex { get; set; }
        public int Corpus { get; set; }
        public int ApartmentNumber { get; set; }
        public char ApartmentIndex { get; set; }
        public int PostalCode { get; set; }
    }
    public enum TownType
    {
        Town,
        AgroTown,
        Village
    }
    public enum StreetType
    {
        Avenue,
        Alley,
        Boulevard,       
        Street,
        Square
    }
}
