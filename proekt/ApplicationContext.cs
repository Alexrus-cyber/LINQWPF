using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        private static ApplicationContext _context;
        public ApplicationContext() : base("name=itproger") { }

        public static ApplicationContext GetContext()
        {
            if (_context == null)
            {
                _context = new ApplicationContext();
            }
            return _context;
        }
    }
}
