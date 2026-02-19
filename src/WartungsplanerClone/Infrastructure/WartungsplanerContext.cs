using Microsoft.EntityFrameworkCore;

namespace WartungsplanerClone.Infrastructure.Data
{
    public class WartungsplanerContext : DbContext
    {
        public WartungsplanerContext(DbContextOptions<WartungsplanerContext> options)
            : base(options) { }

        // DbSets will be added here as entities are defined
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure default schema if needed
            // modelBuilder.HasDefaultSchema("wartungsplaner");
            
            base.OnModelCreating(modelBuilder);
        }
    }
}