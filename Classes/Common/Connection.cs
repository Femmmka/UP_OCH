using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchot.Classes.Common
{
    public class Connection
    {
        public static readonly string config = "server=localhost;port=3306;database=uchot_oborud;uid=root;pwd=;";
        public static MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(config);
            connection.Open();
            return connection;
        }
        public static MySqlDataReader Query(string SQL, MySqlConnection connection)
        {
            return new MySqlCommand(SQL, connection).ExecuteReader();
        }
        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);

        }
    }
}
