using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PayMan.Data.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        [RegularExpression(@"(.{10})")]
        public string AccountNumber { get; set; }

        [Required]
        public string Nickname { get; set; }

        public decimal Balance { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }

        public Client Client { get; set; }

        public ICollection<UsersAccounts> UsersAccounts { get; set; }

        public ICollection<Transaction> SendersTransactions { get; set; }

        public ICollection<Transaction> ReceiversTransactions { get; set; }
    }
}
