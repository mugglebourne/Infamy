using Infamy.ServiceDefaults.Models;
using Microsoft.EntityFrameworkCore;

namespace Infamy.ApiService.DataModels
{
    public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
    {
        public DbSet<Tool> Tools { get; init; }
        public DbSet<Developer> Developers { get; init; }
    }
}
