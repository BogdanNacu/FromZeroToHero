using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FZTH.MVC.Data
{
    public class Hotel
    {
        public Int32 Id { get; set; }
        [Required]
        [StringLength(50)]
        public String Name { get; set; }
        public String Description { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
        [Required]
        [Range(1,5)]
        public Int32 Rating { get; set; }
    }
}