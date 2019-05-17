using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayMan.Data.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [StringLength(35)]
        public string Name { get; set; }

        public ICollection<Account> Accounts { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
