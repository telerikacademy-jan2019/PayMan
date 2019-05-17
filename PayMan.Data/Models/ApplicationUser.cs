using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PayMan.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(35)]
        public string FullName { get; set; }
        //[StringLength(16)] => Username
        //[StringLength(32)] => Password

        public ICollection<UsersAccounts> UsersAccounts { get; set; }

        [ForeignKey(nameof(Client))]
        public int? ClientId { get; set; }

        public Client Client { get; set; }
    }
}
