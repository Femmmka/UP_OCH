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
    class AuditoriumContext : Auditorium
    {
        public AuditoriumContext(int id, string name, string code) : base(id, name, code) { }
        public static List<AuditoriumContext> Select()
        {
            List<AuditoriumContext> allAuditori = new List<AuditoriumContext>();
            string sql = "SELECT * FROM `Auditorium`";
            MySqlConnection connection = Connection.OpenConnection();
            MySqlDataReader data = Connection.Query(sql, connection);
            while (data.Read())
            {
                allAuditori.Add(new AuditoriumContext(
                    data.GetInt32(0),
                    data.GetString(1),
                    data.GetString(2)
                   ));
            }
            Connection.CloseConnection(connection);
            return allAuditori;
        }
        public void Add()
        {
            string sql = $"INSERT INTO `Auditorium`( `name`, `code`) VALUES ('{this.name}','{this.code}')";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
        public void Update()
        {
            string sql = $"UPDATE `Auditorium` SET `name`='{this.name}',`code`='{this.code}' WHERE `id`='{this.id}'";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
        public void Delete()
        {
            string sql = $"DELETE FROM `Auditorium` WHERE `id` = {this.id}";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
    }
}

