using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BcProject.Models
{
    public class WorkPictureList
    {
        public int Id { get; set; }
        [Display(Name = "Fotoğraf")]
        public string Picture{ get; set; }

        [Display(Name ="Eklenecek Proje")]
        [Required]
        public int WorksId { get; set; }
        public virtual Works Work { get; set; }
    }
}