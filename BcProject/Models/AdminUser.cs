using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BcProject.Models
{
    public class AdminUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        [Required]
        public string Mail { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Adress { get; set; }

    }
}