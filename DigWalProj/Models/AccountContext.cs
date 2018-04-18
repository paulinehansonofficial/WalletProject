using Microsoft.EntityFrameworkCore;

namespace DigWalProj.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options)
        {
        }

        public DbSet<DigWalProj.Models.Accounts> Account { get; set; }
    }
}
