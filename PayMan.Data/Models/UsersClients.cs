using System;
using System.Collections.Generic;
using System.Text;

namespace PayMan.Data.Models
{
    public class UsersClients
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}
