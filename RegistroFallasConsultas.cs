using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TouchUP
{
    internal class RegistroFallasConsultas
    {
        private ConexionMySql conexionMySql;
        private List<RegistroFallas> mRegistroFallas;

        public RegistroFallasConsultas()
        {
            conexionMySql = new ConexionMySql();
            mRegistroFallas = new List<RegistroFallas>();
        }

        public ConexionMySql GetConexionMySql()
        {
            return conexionMySql;
        }

        public List<RegistroFallas> getRegistrosFallas(string fallas)
        {
            string QUERY = "SELECT * FROM Registro_Fallas";
            MySqlDataReader mReader = null;

            try
            {
                if (fallas != "")
                {
                    QUERY += " WHERE " +
                        "FechaHora LIKE '%" + fallas + "%' OR " +
                        "Modelo LIKE '%" + fallas + "%' OR " +
                        "Placa LIKE '%" + fallas + "%' OR " +
                        "Componente LIKE '%" + fallas + "%' OR " +
                        "Falla LIKE '%" + fallas + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                RegistroFallas mRegistroFalla = null;

                while (mReader.Read())
                {
                    mRegistroFalla = new RegistroFallas();
                    mRegistroFalla.FechaHora = mReader.GetDateTime("FechaHora");
                    mRegistroFalla.Modelo = mReader.GetString("Modelo");
                    mRegistroFalla.Placa = mReader.GetString("Placa");
                    mRegistroFalla.Componente = mReader.GetString("Componente");
                    mRegistroFalla.Falla = mReader.GetString("Falla");
                    mRegistroFallas.Add(mRegistroFalla);
                }

                mReader.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return mRegistroFallas;
        }

        public List<RegistroFallas> getRegistrosFallasPorPlaca(string fallas, string Placa)
        {
            string QUERY = "SELECT * FROM Registro_Fallas WHERE Placa = @Placa";
            MySqlDataReader mReader = null;

            try
            {
                if (fallas != "")
                {
                    QUERY += " AND " +
                        "FechaHora LIKE '%" + fallas + "%' OR " +
                        "Modelo LIKE '%" + fallas + "%' OR " +
                        "Placa LIKE '%" + fallas + "%' OR " +
                        "Componente LIKE '%" + fallas + "%' OR " +
                        "Falla LIKE '%" + fallas + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Parameters.AddWithValue("@Placa", Placa);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                RegistroFallas mRegistroFalla = null;

                while (mReader.Read())
                {
                    mRegistroFalla = new RegistroFallas();
                    mRegistroFalla.FechaHora = mReader.GetDateTime("FechaHora");
                    mRegistroFalla.Modelo = mReader.GetString("Modelo");
                    mRegistroFalla.Placa = mReader.GetString("Placa");
                    mRegistroFalla.Componente = mReader.GetString("Componente");
                    mRegistroFalla.Falla = mReader.GetString("Falla");
                    mRegistroFallas.Add(mRegistroFalla);
                }

                mReader.Close();
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mRegistroFallas;

        }

        public void agregarRegistroFalla(RegistroFallas registroFallas)
        {
            string QUERY = "INSERT INTO Registro_Fallas (FechaHora, Modelo, Placa, Componente, Falla) VALUES (CONVERT_TZ(CURRENT_TIMESTAMP, '+00:00', '-03:00'), @Modelo, @Placa, @Componente, @Falla)";


            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Parameters.AddWithValue("@FechaHora", registroFallas.FechaHora);
                mComando.Parameters.AddWithValue("@Modelo", registroFallas.Modelo);
                mComando.Parameters.AddWithValue("@Placa", registroFallas.Placa);
                mComando.Parameters.AddWithValue("@Componente", registroFallas.Componente);
                mComando.Parameters.AddWithValue("@Falla", registroFallas.Falla);
                mComando.Connection = conexionMySql.getConnection();
                mComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modificarRegistroFalla(RegistroFallas registroFallas)
        {

            string QUERY = "UPDATE Registro_Fallas SET FechaHora = @FechaHora, Modelo = @Modelo, Placa = @Placa, Componente = @Componente, Falla = @Falla";

            try
            {

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Parameters.AddWithValue("@FechaHora", registroFallas.FechaHora);
                mComando.Parameters.AddWithValue("@Modelo", registroFallas.Modelo);
                mComando.Parameters.AddWithValue("@Placa", registroFallas.Placa);
                mComando.Parameters.AddWithValue("@Componente", registroFallas.Componente);
                mComando.Parameters.AddWithValue("@Falla", registroFallas.Falla);
                mComando.Connection = conexionMySql.getConnection();
                mComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarRegistroFalla(string FechaHora)
        {
            string QUERY = "DELETE FROM Registro_Fallas WHERE FechaHora = @FechaHora";

            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Parameters.AddWithValue("@FechaHora", FechaHora);
                mComando.Connection = conexionMySql.getConnection();
                mComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setTimezone()
        {
            string QUERY = "SET time_zone = '-3:00';";

            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mComando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void queryInnerRegistroMaestro()
        {
            string QUERY = "SELECT * FROM Registro_Fallas INNER JOIN Maestro_Articulos ON Registro_Fallas.Modelo = Maestro_Articulos.Modelo";

            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<RegistroFallas> queryVisorAA(string fallas)
        {
            string QUERY = "SELECT * FROM Registros_Visor_AA_Count";

            MySqlDataReader mReader = null;

            try
            {
                if (fallas != "")
                {
                    QUERY += " WHERE " +
                        "FechaHora LIKE '%" + fallas + "%' OR " +
                        "Puesto LIKE '%" + fallas + "%' OR " +
                        "Marca LIKE '%" + fallas + "%' OR " +
                        "Modelo LIKE '%" + fallas + "%' OR " +
                        "Placa LIKE '%" + fallas + "%' OR " +
                        "Componente LIKE '%" + fallas + "%' OR " +
                        "Falla LIKE '%" + fallas + "%' OR " +
                        "Cantidad LIKE '%" + fallas + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                RegistroFallas mRegistroFalla = null;

                while (mReader.Read())
                {
                    mRegistroFalla = new RegistroFallas();
                    mRegistroFalla.FechaHora = mReader.GetDateTime("FechaHora");
                    mRegistroFalla.Modelo = mReader.GetString("Modelo");
                    mRegistroFalla.Placa = mReader.GetString("Placa");
                    mRegistroFalla.Componente = mReader.GetString("Componente");
                    mRegistroFalla.Falla = mReader.GetString("Falla");
                    mRegistroFalla.Cantidad = mReader.GetInt32("Cantidad");
                    mRegistroFallas.Add(mRegistroFalla);
                }

                mReader.Close();
            }
            catch (Exception)
            {

                Application.Restart();
            }

            return mRegistroFallas;
        }

        public List<RegistroFallas> queryVisorTV(string fallas)
        {
            string QUERY = "SELECT * FROM Registros_Visor_TV_Count";

            MySqlDataReader mReader = null;

            try
            {
                if (fallas != "")
                {
                    QUERY += " WHERE " +
                        "FechaHora LIKE '%" + fallas + "%' OR " +
                        "Puesto LIKE '%" + fallas + "%' OR " +
                        "Marca LIKE '%" + fallas + "%' OR " +
                        "Modelo LIKE '%" + fallas + "%' OR " +
                        "Placa LIKE '%" + fallas + "%' OR " +
                        "Componente LIKE '%" + fallas + "%' OR " +
                        "Falla LIKE '%" + fallas + "%' OR " +
                        "Cantidad LIKE '%" + fallas + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                RegistroFallas mRegistroFalla = null;

                while (mReader.Read())
                {
                    mRegistroFalla = new RegistroFallas();
                    mRegistroFalla.FechaHora = mReader.GetDateTime("FechaHora");
                    mRegistroFalla.Modelo = mReader.GetString("Modelo");
                    mRegistroFalla.Placa = mReader.GetString("Placa");
                    mRegistroFalla.Componente = mReader.GetString("Componente");
                    mRegistroFalla.Falla = mReader.GetString("Falla");
                    mRegistroFalla.Cantidad = mReader.GetInt32("Cantidad");
                    mRegistroFallas.Add(mRegistroFalla);
                }

                mReader.Close();
            }
            catch (Exception)
            {

                Application.Restart();
            }

            return mRegistroFallas;
        }

        // LLenarListBox con columna Fallas donde sean >=3

        public List<RegistroFallas> QueryFallasSupervisor(string fallas)
        {
            string QUERY = "SELECT * FROM Registros_Visor_Count WHERE Cantidad >= 3";

            MySqlDataReader mReader = null;

            try
            {
                if (fallas != "")
                {
                    QUERY += " AND " +
                        "FechaHora LIKE '%" + fallas + "%' OR " +
                        "Puesto LIKE '%" + fallas + "%' OR " +
                        "Marca LIKE '%" + fallas + "%' OR " +
                        "Modelo LIKE '%" + fallas + "%' OR " +
                        "Placa LIKE '%" + fallas + "%' OR " +
                        "Componente LIKE '%" + fallas + "%' OR " +
                        "Falla LIKE '%" + fallas + "%' OR " +
                        "Cantidad LIKE '%" + fallas + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                RegistroFallas mRegistroFalla = null;

                while (mReader.Read())
                {
                    mRegistroFalla = new RegistroFallas();
                    mRegistroFalla.FechaHora = mReader.GetDateTime("FechaHora");
                    mRegistroFalla.Modelo = mReader.GetString("Modelo");
                    mRegistroFalla.Placa = mReader.GetString("Placa");
                    mRegistroFalla.Componente = mReader.GetString("Componente");
                    mRegistroFalla.Falla = mReader.GetString("Falla");
                    mRegistroFalla.Cantidad = mReader.GetInt32("Cantidad");
                    mRegistroFallas.Add(mRegistroFalla);
                }

                mReader.Close();
            }
            catch (Exception)
            {

                Application.Restart();
            }

            return mRegistroFallas;
        }


        // Obtener RegistroFallas segun strings recibidos de DisplaySupervisor.cs

        public List<RegistroFallas> RegistroFallasSelected(string Placa, string Componente, string Falla)
        {
            string QUERY = "SELECT * FROM Registro_Fallas WHERE Placa = @Placa AND Componente = @Componente AND Falla = @Falla";

            MySqlDataReader mReader = null;

            try
            {
                if (Placa != "" && Componente != "" && Falla != "")
                {
                    QUERY += " AND " +
                        "Placa LIKE '%" + Placa + "%' AND " +
                        "Componente LIKE '%" + Componente + "%' AND " +
                        "Falla LIKE '%" + Falla + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);

                mComando.Parameters.AddWithValue("@Placa", Placa);
                mComando.Parameters.AddWithValue("@Componente", Componente);
                mComando.Parameters.AddWithValue("@Falla", Falla);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                RegistroFallas mRegistroFalla = null;

                while (mReader.Read())
                {
                    mRegistroFalla = new RegistroFallas();
                    mRegistroFalla.FechaHora = mReader.GetDateTime("FechaHora");
                    mRegistroFalla.Modelo = mReader.GetString("Modelo");
                    mRegistroFalla.Placa = mReader.GetString("Placa");
                    mRegistroFalla.Componente = mReader.GetString("Componente");
                    mRegistroFalla.Falla = mReader.GetString("Falla");
                    mRegistroFallas.Add(mRegistroFalla);
                }

                mReader.Close();
            }

            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mRegistroFallas;
        }

        public void EliminarRegistroFallasSelected(string Placa, string Componente, string Falla)
        {
            string QUERY = "DELETE FROM Registro_Fallas WHERE Placa = @Placa AND Componente = @Componente AND Falla = @Falla";

            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY);

                mComando.Parameters.AddWithValue("@Placa", Placa);
                mComando.Parameters.AddWithValue("@Componente", Componente);
                mComando.Parameters.AddWithValue("@Falla", Falla);
                mComando.Connection = conexionMySql.getConnection();
                mComando.ExecuteNonQuery();
            }

            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AlmacenarRegistroFallas(string FechaHora, string Modelo, string Placa, string Componente, int Cantidad, string Falla, string Comentarios, string Usuario)
        {
            string QUERY = "INSERT INTO Registro_Fallas_Acciones (FechaHora, Modelo, Placa, Componente, Cantidad, Falla, Comentarios, Usuario) VALUES (CONVERT_TZ(CURRENT_TIMESTAMP, '+00:00', '-03:00'), @Modelo, @Placa, @Componente, @Cantidad, @Falla, @Comentarios, @Usuario)";

            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY);

                mComando.Parameters.AddWithValue("@FechaHora", FechaHora);
                mComando.Parameters.AddWithValue("@Modelo", Modelo);
                mComando.Parameters.AddWithValue("@Placa", Placa);
                mComando.Parameters.AddWithValue("@Componente", Componente);
                mComando.Parameters.AddWithValue("@Cantidad", Cantidad);
                mComando.Parameters.AddWithValue("@Falla", Falla);
                mComando.Parameters.AddWithValue("@Comentarios", Comentarios);
                mComando.Parameters.AddWithValue("@Usuario", Usuario);
                mComando.Connection = conexionMySql.getConnection();
                mComando.ExecuteNonQuery();
            }

            catch (Exception)
            {
                Application.Restart();
                MessageBox.Show("Se ha perdido la conexión con el servidor. Por favor, reingrese nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Obtener Registro_Fallas_Acciones segun strings recibidos de DisplaySupervisor.cs

        public List<RegistroFallas> ObtenerRegistroFallasAcciones()
        {
            string QUERY = "SELECT * FROM Registro_Fallas_Acciones";

            MySqlDataReader mReader = null;

            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                RegistroFallas mRegistroFalla = null;

                while (mReader.Read())
                {
                    mRegistroFalla = new RegistroFallas();
                    mRegistroFalla.FechaHora = mReader.GetDateTime("FechaHora");
                    mRegistroFalla.Modelo = mReader.GetString("Modelo");
                    mRegistroFalla.Placa = mReader.GetString("Placa");
                    mRegistroFalla.Componente = mReader.GetString("Componente");
                    mRegistroFalla.Falla = mReader.GetString("Falla");
                    mRegistroFalla.Cantidad = mReader.GetInt32("Cantidad");
                    mRegistroFalla.Comentarios = mReader.GetString("Comentarios");
                    mRegistroFalla.Usuario = mReader.GetString("Usuario");
                    mRegistroFallas.Add(mRegistroFalla);
                }

                mReader.Close();
            }

            catch (Exception)
            {
                Application.Restart();
            }

            return mRegistroFallas;
        }

        public List<RegistroFallas> ObtenerRegistroFallasAccionesPorFecha(string FechaHora)
        {
            string QUERY = "SELECT * FROM Registro_Fallas_Acciones WHERE FechaHora = @FechaHora";

            MySqlDataReader mReader = null;

            try
            {
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Parameters.AddWithValue("@FechaHora", FechaHora);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                RegistroFallas mRegistroFalla = null;

                while (mReader.Read())
                {
                    mRegistroFalla = new RegistroFallas();
                    mRegistroFalla.FechaHora = mReader.GetDateTime("FechaHora");
                    mRegistroFalla.Modelo = mReader.GetString("Modelo");
                    mRegistroFalla.Placa = mReader.GetString("Placa");
                    mRegistroFalla.Componente = mReader.GetString("Componente");
                    mRegistroFalla.Falla = mReader.GetString("Falla");
                    mRegistroFalla.Cantidad = mReader.GetInt32("Cantidad");
                    mRegistroFalla.Comentarios = mReader.GetString("Comentarios");
                    mRegistroFalla.Usuario = mReader.GetString("Usuario");
                    mRegistroFallas.Add(mRegistroFalla);
                }

                mReader.Close();
            }

            catch (Exception)
            {
                Application.Restart();
            }

            return mRegistroFallas;
        }

    }
}
