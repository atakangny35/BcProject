using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BcProject.Models
{
    public class ProjectUpdateModel
    {
        public int Id { get; set; }
        [Display(Name = "Baslık")]
        [Required(ErrorMessage ="Bu alan boş olamaz!")]
        public string Title { get; set; }


        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Kapak fotoğrafı olacak fotoğraf")]
        public string MenuPicture { get; set; }
    }
}