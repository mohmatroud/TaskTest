using Microsoft.EntityFrameworkCore;

namespace TaskTest
{
    public class DBContext: DbContext
    {
      
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<Library> libraries { get; set; }
        public DbSet<Book> books { get; set; }
    
    }
}
