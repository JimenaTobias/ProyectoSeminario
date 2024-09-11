using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoSeminario.Models.Dao
{
    public class Connection
    {
        public MySqlConnection conn;

        public Connection()
        {
            string stringConnetion = "server=localhost;user=root;database=tienda_accesorios_joyeria;password=Jimena12345;";
            this.conn = new MySqlConnection(stringConnetion);
        }
    }
}
