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

        // Should display as currency doesn't seem to work, however
        // but it has a symbol, just not a dollar sign
        // [DisplayFormat(DataFormatString ="{0:C0}")]
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

    }
}