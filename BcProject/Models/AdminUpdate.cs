using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BcProject.Models
{
    public class AdminUpdate
    {
        public int Id { get; set; }

        [Display(Name ="Kullanıcı Adı")]

        [Required]
        public string UserName { get; set; }
        [Display(Name = " Şifre")]
        [Required]
        [MinLength(5,ErrorMessage ="En az 5 karakter içermeli!!")]
        public string Password { get; set; }

        [Required]
        public string Mail { get; set; }
        [Required]
        [Display(Name = " Numara")]
        public string Number { get; set; }
        [Required]
        public string Adress { get; set; }
    }
}