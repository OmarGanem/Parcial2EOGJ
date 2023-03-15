using System.Data.Entity;

namespace Parcial2EOGJ.Data
{
    public class DataContext : DbContext
    {
        DbSet<Contact> Contacts { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Rol> Roles { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<User> Users { get; set; }
       
        public DataContext() : base("name = connection")
        {

        }

    }
}
