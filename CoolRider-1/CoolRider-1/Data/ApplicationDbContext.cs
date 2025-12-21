using Microsoft.EntityFrameworkCore;
using CoolRider_1.Models;

namespace CoolRider_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tables mapped to the database
        public DbSet<RegisterModel> Users { get; set; }

        public DbSet<AdminActivationCode> AdminActivationCodes { get; set; }
    }
}
