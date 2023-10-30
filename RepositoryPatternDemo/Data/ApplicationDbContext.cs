using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Data
{

    public class ApplicationDbContext : DbContext
    {
        //Dbcontextoption is used to override configuration --connection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<EmployeeEF> Employees { get; set; }

        public static implicit operator ApplicationBuilder(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
      
    }




 
}
