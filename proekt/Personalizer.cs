using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    public class Personalizer
    {
         ApplicationContext db;
        public Personalizer(ApplicationContext db)
        {
            this.db = db;
        }
        public bool Register(string subname, string name, string lastname, string phone)
        {

            bool canRegister = db.Clients.All(p => p.Phone != phone); // Не существует с таким кодом
            if (canRegister)
                db.Clients.Add(new Client { FirstName = subname, MiddleName = name, LastName = lastname, Phone = phone });
            db.SaveChanges();
            return canRegister;

        }
    
       
    }
}
