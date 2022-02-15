using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    [Table("Clients")]
    public class Client
    {
        public int Id { get; set; }

        private string firstName, middleName,lastName, phone, email;
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        } 
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
       
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Client() { }

        public Client(string FirstName, string MiddleName, string LastName, string Phone , string Email)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;

        }
    }
}
