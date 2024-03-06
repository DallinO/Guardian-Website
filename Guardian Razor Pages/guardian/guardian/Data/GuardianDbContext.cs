using Microsoft.EntityFrameworkCore;
using guardian.Models;
using System.Numerics;


namespace guardian.Data
{
    public class GuardianDbContext : DbContext
    {
        public GuardianDbContext(DbContextOptions<GuardianDbContext> options)
        : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
    }
}
