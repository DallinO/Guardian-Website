using Microsoft.EntityFrameworkCore;
using guardian.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace guardian.Data
{
    public class GuardianDbContext : IdentityDbContext<ApplicationUser>
    {
        public GuardianDbContext(DbContextOptions<GuardianDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>();
        }
    }
}