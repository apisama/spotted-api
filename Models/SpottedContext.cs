using Microsoft.EntityFrameworkCore;

namespace spotted_api.Models
{
  class SpottedContext: DbContext {
    public SpottedContext(DbContextOptions<SpottedContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Spot> Spots { get; set; }
  }
}