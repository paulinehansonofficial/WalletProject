using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DigWalProj.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Additional Properties
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name="Second Name")]
        public string LastName { get; set; }
        [Display(Name ="Student Number")]
        public string userID { get; set; }

        // emailAddress and password are a part of identity user
    }
}
