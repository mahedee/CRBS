using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRBS_Project.Models
{
    public class GenderInfo
    {
        [Key]
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public ICollection<ApplicationUser> ApplicationUser { get; set; }
    }
}