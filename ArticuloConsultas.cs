using DocumentFormat.OpenXml.Presentation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchUP
{
    internal class ArticuloConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Articulo> mArticulos;

        public ArticuloConsultas()
        {
         conexionMySql = new ConexionMySql();
         mArticulos = new List<Articulo>();
        }

        public List<Articulo> getProductos(string filtro)
        {
            string QUERY = "SELECT * FROM Maestro_Articulos";
            MySqlDataReader mReader = null;

            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "Id LIKE '%" + filtro + "%' OR " +
                        "Puesto LIKE '%" + filtro + "%' OR " +
                        "Marca LIKE '%" + filtro + "%' OR " +
                        "Modelo LIKE '%" + filtro + "%' OR " +
                        "Placa LIKE '%" + filtro + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();
                
                Articulo mArticulo = null;
                
                while (mReader.Read())
                {
                    mArticulo = new Articulo();
                    mArticulo.Id = mReader.GetInt32("Id");
                    mArticulo.Puesto = mReader.GetString("Puesto");
                    mArticulo.Marca = mReader.GetString("Marca");
                    mArticulo.Modelo = mReader.GetString("Modelo");
                    mArticulo.Placa = mReader.GetString("Placa");
                    mArticulo.Imagen = (byte[])mReader.GetValue(5);
                    mArticulos.Add(mArticulo);
                }
                
                mReader.Close();
            
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha realizar la consulta. Por favor, reintente nuevamente", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mArticulos;
            
        }

        public List<Articulo> getProductosPuesto(string filtro)
        {
            string QUERY = "SELECT * FROM Maestro_Articulos";
            MySqlDataReader mReader = null;

            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "Puesto LIKE '%" + filtro + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                Articulo mArticulo = null;

                while (mReader.Read())
                {
                    mArticulo = new Articulo();
                    mArticulo.Id = mReader.GetInt32("Id");
                    mArticulo.Puesto = mReader.GetString("Puesto");
                    mArticulo.Marca = mReader.GetString("Marca");
                    mArticulo.Modelo = mReader.GetString("Modelo");
                    mArticulo.Placa = mReader.GetString("Placa");
                    mArticulo.Imagen = (byte[])mReader.GetValue(5);
                    mArticulos.Add(mArticulo);
                }

                mReader.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return mArticulos;

        }

        public List<Articulo> getProductosPuestoMarca(string filtroPuesto, string filtroMarca)
        {
            string QUERY = "SELECT * FROM Maestro_Articulos";
            MySqlDataReader mReader = null;

            try
            {
                if (filtroPuesto != "" && filtroMarca != "")
                {
                    QUERY += " WHERE " +
                        "Puesto LIKE '%" + filtroPuesto + "%' OR " +
                        "Marca LIKE '%" + filtroMarca + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                Articulo mArticulo = null;

                while (mReader.Read())
                {
                    mArticulo = new Articulo();
                    mArticulo.Id = mReader.GetInt32("Id");
                    mArticulo.Puesto = mReader.GetString("Puesto");
                    mArticulo.Marca = mReader.GetString("Marca");
                    mArticulo.Modelo = mReader.GetString("Modelo");
                    mArticulo.Placa = mReader.GetString("Placa");
                    mArticulo.Imagen = (byte[])mReader.GetValue(5);
                    mArticulos.Add(mArticulo);
                }

                mReader.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return mArticulos;

        }

        public List<Articulo> getProductosMarca(string filtro)
        {
            string QUERY = "SELECT * FROM Maestro_Articulos";
            MySqlDataReader mReader = null;

            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "Marca LIKE '%" + filtro + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                Articulo mArticulo = null;

                while (mReader.Read())
                {
                    mArticulo = new Articulo();
                    mArticulo.Id = mReader.GetInt32("Id");
                    mArticulo.Puesto = mReader.GetString("Puesto");
                    mArticulo.Marca = mReader.GetString("Marca");
                    mArticulo.Modelo = mReader.GetString("Modelo");
                    mArticulo.Placa = mReader.GetString("Placa");
                    mArticulo.Imagen = (byte[])mReader.GetValue(5);
                    mArticulos.Add(mArticulo);
                }

                mReader.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return mArticulos;

        }

        internal bool insertarProducto(Articulo mArticulo)
        {
            string INSERT = "INSERT INTO Maestro_Articulos (Puesto, Marca, Modelo, Placa, Imagen) VALUES (@Puesto, @Marca, @Modelo, @Placa, @Imagen)";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySql.getConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Puesto", mArticulo.Puesto));
            mCommand.Parameters.Add(new MySqlParameter("@Marca", mArticulo.Marca));
            mCommand.Parameters.Add(new MySqlParameter("@Modelo", mArticulo.Modelo));
            mCommand.Parameters.Add(new MySqlParameter("@Placa", mArticulo.Placa));
            mCommand.Parameters.Add(new MySqlParameter("@Imagen", mArticulo.Imagen));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public void modificarProducto(Articulo mArticulo)
        {
            string UPDATE = "UPDATE Maestro_Articulos SET Puesto = @Puesto, Marca = @Marca, Modelo = @Modelo, Placa = @Placa, Imagen = @Imagen WHERE Id = @Id";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySql.getConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Id", mArticulo.Id));
            mCommand.Parameters.Add(new MySqlParameter("@Puesto", mArticulo.Puesto));
            mCommand.Parameters.Add(new MySqlParameter("@Marca", mArticulo.Marca));
            mCommand.Parameters.Add(new MySqlParameter("@Modelo", mArticulo.Modelo));
            mCommand.Parameters.Add(new MySqlParameter("@Placa", mArticulo.Placa));
            mCommand.Parameters.Add(new MySqlParameter("@Imagen", mArticulo.Imagen));

            mCommand.ExecuteNonQuery();
        }

        public void eliminarProducto(Articulo mArticulo)
        {
            string DELETE = "DELETE FROM Maestro_Articulos WHERE Id = @Id";

            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySql.getConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Id", mArticulo.Id));

            mCommand.ExecuteNonQuery();
        }

        public void extraerColumnaPuesto(Articulo mArticulo)
        {
            string QUERY = "SELECT Puesto FROM Maestro_Articulos WHERE Puesto = @Puesto";

            MySqlCommand mCommand = new MySqlCommand(QUERY, conexionMySql.getConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Puesto", mArticulo.Puesto));

            mCommand.ExecuteNonQuery();
        }

        public void refrescarDataGrid()
        {
            string QUERY = "SELECT * FROM Maestro_Articulos";

            MySqlCommand mCommand = new MySqlCommand(QUERY, conexionMySql.getConnection());

            mCommand.ExecuteNonQuery();
        }

        public void ContarCantPlacasPorPuesto()
        {
            string QUERY = "SELECT COUNT(Placa) FROM Maestro_Articulos GROUP BY Puesto";

            MySqlCommand mCommand = new MySqlCommand(QUERY, conexionMySql.getConnection());

            mCommand.ExecuteNonQuery();
        }
    }
}

// Compare this snippet from ConexionMySql.cs:
// using MySql.Data.MySqlClient;