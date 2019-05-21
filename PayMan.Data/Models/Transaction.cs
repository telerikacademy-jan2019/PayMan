using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayMan.Data.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public string Description { get; set; }

        [RegularExpression(@"^\d+.?\d{0,2}$")]
        public decimal Amount { get; set; }

        public DateTime TimeStamp { get; set; }

        public bool IsSent { get; set; }

        public int SenderAccountId { get; set; }

        public Account SenderAccount { get; set; }

        public int ReceiverAccountId { get; set; }

        public Account ReceiverAccount { get; set; }
    }
}
