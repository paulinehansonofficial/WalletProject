using Microsoft.EntityFrameworkCore;

namespace DigWalProj.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<DigWalProj.Models.Projects> Project { get; set; }
    }
}
