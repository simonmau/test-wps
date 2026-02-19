using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WartungsplanerClone.Infrastructure.Data
{
    public class WartungsplanerContextFactory : IDesignTimeDbContextFactory<WartungsplanerContext>
    {
        public WartungsplanerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WartungsplanerContext>();
            
            // Use SQLite for migrations
            optionsBuilder.UseSqlite("Data Source=wartungsplaner.db");
            
            return new WartungsplanerContext(optionsBuilder.Options);
        }
    }
}