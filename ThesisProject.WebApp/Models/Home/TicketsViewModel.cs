using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ThesisProject.Data.Domain;

namespace ThesisProject.WebApp.Models.Home
{
    public class TicketsViewModel
    {
        public string userId { get; set; }
        public string ReturnUrl { get; set; }

        public string Header { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public bool IsError { get; set; }

        public StatusModel StatusModel => new StatusModel()
        {
            StatusMessage = this.StatusMessage,
            IsError = this.IsError
        };
    }
}

