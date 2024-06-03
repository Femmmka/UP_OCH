using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchot.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }


        public User(int id, string login, string password, string role, string email, string lastName, string firstName, string middleName, string phone)
        {
            this.Id = id;
            this.Login= login;
            this.Password = password;
            this.Role = role;
            this.Email = email;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.Phone = phone;
        }
    }
}


