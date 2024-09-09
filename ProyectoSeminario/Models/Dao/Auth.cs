using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoSeminario.Models.Dao
{
    public class Auth
    {
        public static bool Login(string username, string password)
        {
            Connection conn = new Connection();
            conn.conn.Open();
            string sql = "select * from users where username='" + username + "' and password='" + password + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool exist = reader.Read() ? true : false;
            conn.conn.Close();
            return exist;
        }
    }
}
