using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigWalProj.Models
{
    public class ProjManagementTeam
    {
        public int teamID { get; set; }

        public string teamName { get; set; }

        public string teamDescription { get; set; }

        public List<ApplicationUser> teamMembers { get; set; }

        public List<Project> teamProjects { get; set; }

        public List<ApplicationUser> resourceMembers { get; set; }
    }
}
