using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BcProject.Models
{
    public class ProjectAddModel
    {
        public int Id { get; set; }
        [Display(Name = "Baslık")]
        [Required(ErrorMessage ="Başlık girilmek zorundadır")]
        public string Title { get; set; }


        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Kapak Fotoğrafı")]
        public string MenuPicture { get; set; }
    }
}