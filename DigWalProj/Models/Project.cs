using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using DigWalProj.Models;

namespace DigWalProj.Models
{
    public class Project
    {
        [Key]
        public int projId { get; set; }
        public List<Accounts> students { get; set; }

        // Display(Name = "Team")]
        // public Team assignedTeam { get; set; } 

        [Display(Name="Name")]
        public string ProjectName { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime AccountCreated { get; set; }
        [Display(Name = "Date Due")]
        public DateTime DueDate { get; set; }        
        // Should display as currency doesn't seem to work, however
        // but it has a symbol, just not a dollar sign
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}