using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DigWalProj.Models
{
    public class PMTeam
    {
        [Key]
        public int teamId { get; set; }
        public string teamName { get; set; }
        public string teamDescription { get; set; }
        public List<ApplicationUser> teamMembers { get; set; }
        public List<Project> teamProjects { get; set; }
        public List<ApplicationUser> resourceMembers { get; set; }
    }
}
