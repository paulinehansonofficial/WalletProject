using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DigWalProj.Models;


namespace DigWalProj.Data
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<DigWalProj.Models.ApplicationUser> ApplicationUser { get; set; } 
        public DbSet<DigWalProj.Models.Advertisement> Advertisement { get; set; }
        public DbSet<DigWalProj.Models.Project> Project { get; set; }
        public DbSet<DigWalProj.Models.PMTeam> PMTeam { get; set; }
    }
}
