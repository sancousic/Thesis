using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Card
{
    public class CardSearchViewModel
    {
        public string Search { get; set; }
        public Pacient Pacient { get; set; }
        public Data.Domain.Card Card { get; set; }
        public string ReturnUrl { get; set; }
        public int AllrgeysCount { get; set; }
        public int ExaminationsCount { get; set; }
        public int VaccinationsCount { get; set; }
        public int DiggnosesCount { get; set; }
        public int DiagnoseHistoryCount { get; set; }
        public int ReccomendationsCount { get; set; }
        public IEnumerable<DiagnoseHistory> DiagnoseHistories { get; set; }
    }
}
