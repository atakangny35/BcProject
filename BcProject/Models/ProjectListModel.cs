using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BcProject.Models
{
    public class ProjectListModel
    {
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        [Required]
        public string Title { get; set; }

        public bool MenüControl { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        
        
    }
}