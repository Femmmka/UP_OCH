using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uchot.Classes.Common;
using uchot.Model;

namespace uchot.Classes
{
    public class UsersContext : User
    {
        public UsersContext(int id, string login, string password, string role, string email, string lastName, string firstName, string middleName, string phone)
            : base(id, login, password, role, email, lastName, firstName, middleName, phone) { }

        public static List<UsersContext> Select()
        {
            List<UsersContext> allUsers = new List<UsersContext>();
            string sql = "SELECT * FROM `User`";
            MySqlConnection connection = Connection.OpenConnection();
            MySqlDataReader data = Connection.Query(sql, connection);
            while (data.Read())
            {
                allUsers.Add(new UsersContext(
                    data.GetInt32(0),
                    data.GetString(1),
                    data.GetString(2),
                    data.GetString(3),
                    data.GetString(4),
                    data.GetString(5),
                    data.GetString(6),
                    data.GetString(7),
                    data.GetString(8)
                   ));
            }
            Connection.CloseConnection(connection);
            return allUsers;
        }   

        public void Add()
        {
            string sql = $"INSERT INTO `User` (`login`, `password`, `role`, `email`, `last_name`, `first_name`, `middle_name`, `phone`) " +
                         $"VALUES ('{this.Login}', '{this.Password}', '{this.Role}', '{this.Email}', '{this.LastName}', '{this.FirstName}', '{this.MiddleName}', '{this.Phone}')";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }

        public void Update()
        {
            string sql = $"UPDATE `User` " +
                         $"SET `login` = '{this.Login}', `password` = '{this.Password}', `role` = '{this.Role}', `email` = '{this.Email}', " +
                         $"`last_name` = '{this.LastName}', `first_name` = '{this.FirstName}', `middle_name` = '{this.MiddleName}', `phone` = '{this.Phone}' " +
                         $"WHERE `id` = {this.Id}";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }

        public void Delete()
        {
            string sql = $"DELETE FROM `User` WHERE `id` = {this.Id}";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
    }
}