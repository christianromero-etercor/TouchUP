using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TouchUP
{
    internal class Conexion
    {
        protected string Server = "65.181.111.156";
        protected string Database = "solnik_touchup";
        protected string User = "solnik_admin";
        protected string Password = "i3DAGDAZ";
        protected string Port = "3306";
    }
}

// Compare this snippet from ConexionMySql.cs: 