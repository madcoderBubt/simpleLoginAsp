using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginWeb.Models
{
    public class LogModel
    {
        [Display(Name = "User Name")]
        public string userName { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "Roles")]
        public string roles { get; set; }

    }
}