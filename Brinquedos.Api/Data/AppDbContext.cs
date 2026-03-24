using Brinquedos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Brinquedos.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Brinquedo> Brinquedos { get; set; }
    }
}