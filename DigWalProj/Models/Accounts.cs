using System;
using System.ComponentModel.DataAnnotations;

namespace DigWalProj.Models
{
    public class Accounts
    {
        [Display(Name ="Student No.")]
        public int ID { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name="Surname")]
        public string LastName { get; set; }

        [Display(Name = "Member Since")]
        [DataType(DataType.Date)]
        public DateTime AccountCreated { get; set; }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

    }
}