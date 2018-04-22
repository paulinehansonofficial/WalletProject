using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace DigWalProj.Models
{
    public class AccountContext : IdentityDbContext<ApplicationUser>
    {
        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options)
        {
        }

        public DbSet<DigWalProj.Models.Accounts> Account { get; set; } 
    }
}
