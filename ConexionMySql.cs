using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchUP
{
    public class ConexionMySql
    {
        MySqlConnection conexion = new MySqlConnection("Server=190.193.48.41;PORT=3306;DataBase=solnik_touchup;UID=solnik_admin;PASSWORD:i3DAGDAZ");
        public void Conectar()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto: " + ex.ToString());
            }
        }
    }
}
