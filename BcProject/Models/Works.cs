using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BcProject.Models
{
    public class Works
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Baslık")]
        [Required]
        public string Title { get; set; }
        
        
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        public string MenuPicture { get; set; }
        public bool MenüControl { get; set; }
        public List<WorkPictureList> PictureLists { get; set; }

    }
}