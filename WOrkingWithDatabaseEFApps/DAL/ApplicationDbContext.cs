using System.Data.Entity;
using WOrkingWithDatabaseEFApps.DAL.Model;

namespace WOrkingWithDatabaseEFApps.DAL
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("WindowsFormsDb")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
    }
}
