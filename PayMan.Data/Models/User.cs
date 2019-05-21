using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PayMan.Data.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(35)]
        public string FullName { get; set; }

        [Required]
        [StringLength(16)]
        public string UserName { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        public ICollection<UsersAccounts> UsersAccounts { get; set; }

        public ICollection<UsersClients> UsersClients { get; set; }
    }
}
