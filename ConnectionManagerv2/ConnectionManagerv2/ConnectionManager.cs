using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConnectionManagerv2
{
    internal sealed class ConnectionManager
    {
        public static ConnectionManager manager = new ConnectionManager();
        MySqlConnection conn;
        private ConnectionManager() { }

        public void Connect() {
            string sql = "server=127.0.0.1;uid=root;pwd=;database=database";
            conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Disconnect()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}
