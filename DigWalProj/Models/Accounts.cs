using System;

namespace DigWalProj.Models
{
    public class Accounts
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime AccountCreated { get; set; }
        public decimal Balance { get; set; }
    }
}