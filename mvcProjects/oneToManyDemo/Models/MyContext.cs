using Microsoft.EntityFrameworkCore;
namespace oneToManyDemo.Models
{ 

    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}