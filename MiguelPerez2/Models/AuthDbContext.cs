using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MiguelPerez2.Models
{
    public class AuthDbContext : IdentityDbContext
    {
        public DbSet<Electrodomestic> Electrodomestics { get; set; }

        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }
    }
}
