using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayMan.Data.Models
{
    public class Banner
    {
        [Key]
        public int BannerId { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required]
        public string URL { get; set; }

        public DateTime StartValidity { get; set; }

        public DateTime EndValidity { get; set; }
    }
}
