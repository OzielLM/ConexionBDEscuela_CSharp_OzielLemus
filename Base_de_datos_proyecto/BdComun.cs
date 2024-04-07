using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Base_de_datos_proyecto
{
    public class BdComun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; port=3306; user id = root; password = root; database = IOPIM;");

            conectar.Open();

            return conectar;
        }
    }
}
