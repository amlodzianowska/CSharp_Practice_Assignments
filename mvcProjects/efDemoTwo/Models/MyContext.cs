using Microsoft.EntityFrameworkCore;
namespace efDemoTwo.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Animals" table name will come from the DbSet variable name
        public DbSet<Animal> Animals { get; set; }
    }
}