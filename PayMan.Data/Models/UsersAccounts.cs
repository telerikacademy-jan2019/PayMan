using System;
using System.Collections.Generic;
using System.Text;

namespace PayMan.Data.Models
{
    public class UsersAccounts
    {
        public int UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int AccountId { get; set; }

        public Account Account { get; set; }
    }
}
