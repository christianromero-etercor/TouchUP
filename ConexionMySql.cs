using DocumentFormat.OpenXml.Drawing.Diagrams;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchUP
{
    internal class ConexionMySql : Conexion
    {
        public MySqlConnection connection; // Conexión
        public string cadenaConexion; // Cadena de conexión

        public ConexionMySql() // Constructor
        {
            cadenaConexion = "SERVER=" + Server + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";PORT=" + Port + ";";
            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection getConnection() // Obtener la conexión
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open(); // Abrir la conexión
                }
            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("No se ha podido conectar con el servidor. Por favor reintente nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
            return connection;
        }

        public void closeConnection() // Cerrar la conexión
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void RefrescarDataGrid(DataGridView dataGridView, string query) // Refrescar un DataGridView con los datos de la tabla
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(query);
                mComando.Connection = new ConexionMySql().getConnection();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(mComando);
                System.Data.DataTable dt = new System.Data.DataTable();
                mDataAdapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarArticulo(string Id) // Eliminar un registro de la tabla
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM Maestro_Articulos WHERE Id = '{0}'", Id), getConnection());
                mComando.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarUsuario(string Id) // Eliminar un registro de la tabla
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM Usuarios WHERE Id = '{0}'", Id), getConnection());
                mComando.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modificarUsuario(string Id, string Usuario, string Password, string Role) // Modificar un registro de la tabla
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE Usuarios SET Usuario = '{0}', Password = '{1}', Perfil = '{2}' WHERE Id = '{3}'",
                                                                                                Usuario, Password, Role, Id), getConnection());
                mComando.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
