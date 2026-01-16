using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDbContext(DbContextOptions opt) : DbContext(opt)
    {
        public DbSet<Platform> Platforms { get; set; }
    }
}
