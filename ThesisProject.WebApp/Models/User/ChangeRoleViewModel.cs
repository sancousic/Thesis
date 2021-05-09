using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThesisProject.WebApp.Models.User
{
    // TODO Это вообще нужно?
    public class ChangeRoleViewModel
    {
        public string UserId { get; set; }
        public List<SelectListItem> Roles { get; set; }
        public string Role { get; set; }
    }
}
