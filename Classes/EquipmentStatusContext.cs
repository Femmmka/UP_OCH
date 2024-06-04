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
    class EquipmentStatusContext : EquipmentStatus
    {
        public EquipmentStatusContext(int id, string name) : base(id, name) { }
        public static List<EquipmentStatusContext> Select()
        {
            List<EquipmentStatusContext> allEquipme = new List<EquipmentStatusContext>();
            string sql = "SELECT * FROM `EquipmentStatus`";
            MySqlConnection connection = Connection.OpenConnection();
            MySqlDataReader data = Connection.Query(sql, connection);
            while (data.Read())
            {
                allEquipme.Add(new EquipmentStatusContext(
                    data.GetInt32(0),
                    data.GetString(1)
                   ));
            }
            Connection.CloseConnection(connection);
            return allEquipme;
        }
        public void Add()
        {
            string sql = $"INSERT INTO `EquipmentStatus`( `name`) VALUES ('{this.name}')";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
        public void Update()
        {
            string sql = $"UPDATE `EquipmentStatus` SET `name`='[value-2]' WHERE `id`='{this.id}'";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
        public void Delete()
        {
            string sql = $"DELETE FROM `EquipmentStatus` WHERE `id` = {this.id}";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
    }
}