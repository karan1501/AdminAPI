using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    public class AdminAPIRepoContext :  IdentityDbContext<AdminUser>
    {
        public AdminAPIRepoContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<AdminUser> AdminUser { get; set; }
    }
}
