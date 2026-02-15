using Microsoft.EntityFrameworkCore;

namespace PensionSystem.Database
{
    public class AppDBConnection : DbContext
    {
        public AppDBConnection(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        DbSet <Person> Persons { get; set; }
    }
}
