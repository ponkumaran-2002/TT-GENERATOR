using Microsoft.EntityFrameworkCore;
using TTGenerator.Models.Domain;

namespace TTGenerator.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Login_credentials> Login_credentials { get; set; }
        public DbSet<clg_tt_level> clg_tt_level { get; set; }
       // public object Login { get; internal set; }
    }
}
