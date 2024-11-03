using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options ): base(options)
        {
            
        }
        public DbSet<Person> Persons {  get; set; }
        
        public DbSet<Estudiante> Estudiantes {  get; set; } 
    }
}
