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
    public class EquipmentContext:Equipment
    {
        public EquipmentContext(int id, string name, string photo, int inventory_number, int auditorium_id, int responsible_user_id, decimal cost, int status_id) : base(id, name, photo, inventory_number, auditorium_id, responsible_user_id, cost, status_id) { }
        public static List<EquipmentContext> Select()
        {
            List<EquipmentContext> allEquipment = new List<EquipmentContext>();
            string sql = "SELECT * FROM `Equipment`";
            MySqlConnection connection = Connection.OpenConnection();
            MySqlDataReader data = Connection.Query(sql, connection);
            while (data.Read())
            {
                allEquipment.Add(new EquipmentContext(
                    data.GetInt32(0),
                    data.GetString(1),
                    data.GetString(2),
                    data.GetInt32(3),
                    data.GetInt32(4),
                    data.GetInt32(5),
                    data.GetInt32(6),
                    data.GetInt32(7)
                   ));
            }
            Connection.CloseConnection(connection);
            return allEquipment;
        }
        public void Add()
        {
            string sql = $"INSERT INTO `Equipment`(`name`, `photo`, `inventory_number`, `auditorium_id`, `responsible_user_id`, `cost`, `status_id`) VALUES ('{this.name}','{this.photo}','{this.inventory_number}','{this.auditorium_id}','{this.responsible_user_id}','{this.cost}','{this.status_id}')";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
        public void Update()
        {
            string sql = $"UPDATE `Equipment` SET `name`='{this.name}',`photo`='{this.photo}',`inventory_number`='{this.inventory_number}',`auditorium_id`='{this.auditorium_id}',`responsible_user_id`='{this.responsible_user_id}',`cost`='{this.cost}',`status_id`='{this.status_id}' WHERE `id`='{this.id}'";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
        public void Delete()
        {
            string sql = $"DELETE FROM `Equipment` WHERE `id` = {this.id}";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(sql, connection);
            Connection.CloseConnection(connection);
        }
    }
}
   