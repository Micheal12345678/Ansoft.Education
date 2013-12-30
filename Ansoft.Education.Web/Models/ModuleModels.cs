using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //注释的意思啊

namespace Ansoft.Education.Web.Models
{
    public class ModuleModels
    {
        [Required]
        [Display(Name = "Primary Key")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Moudel Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Sort Index")]
        public int SortId { get; set; }

        [Required]
        [Display(Name = "Parent Id")]
        public int ParentId { get; set; }

        [Required]
        [Display(Name = "Level Code")]
        public int LevelCode { get; set; }


        public string Text { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public List<ModuleModels> Menus { get; set; }
    }
}