using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSincretic
{
    class DBConnexion
    {
        public static MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=sincretic;Uid=root;Pwd=;");
    }
}
