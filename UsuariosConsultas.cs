using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using Org.BouncyCastle.Asn1.Mozilla;

namespace TouchUP
{
    internal class UsuariosConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Usuarios> mUsuarios;

        public UsuariosConsultas()
        {
            conexionMySql = new ConexionMySql();
            mUsuarios = new List<Usuarios>();
        }

        // GetConnection
        public MySqlConnection GetConnection()
        {
            return conexionMySql.getConnection();
        }

        // CloseConnection
        public void CloseConnection()
        {
            conexionMySql.closeConnection();
        }

        public List<Usuarios> GetUsuarios(string usuario)
        {
            string QUERY = "SELECT * FROM Usuarios WHERE Perfil >= 1"; // Perfil 1 = Administrador / Perfil 2 = Supervisor / Perfil 3 = Operario
            MySqlDataReader mReader = null;

            try
            {
                if (usuario != "")
                {
                    QUERY += " AND " +
                        "Id LIKE '%" + usuario + "%' OR " +
                        "Usuario LIKE '%" + usuario + "%' OR " +
                        "Password LIKE '%" + usuario + "%' OR " +
                        "Perfil LIKE '%" + usuario + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConnection();
                mReader = mComando.ExecuteReader();

                Usuarios mUsuario = null;

                while (mReader.Read())
                {
                    mUsuario = new Usuarios();
                    mUsuario.Id = mReader.GetInt32("Id");
                    mUsuario.Usuario = mReader.GetString("Usuario");
                    mUsuario.Password = mReader.GetString("Password");
                    mUsuario.Perfil = mReader.GetInt32("Perfil");
                    mUsuarios.Add(mUsuario);
                }

                mReader.Close();
            }
            catch (Exception)
            {
                Application.Restart();
                
            }

            return mUsuarios;
        }

        public void AgregarUsuario(Usuarios usuario)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("INSERT INTO Usuarios (Usuario, Password, Perfil) VALUES ('{0}', '{1}', '{2}')",
                                                          usuario.Usuario, usuario.Password, usuario.Perfil), conexionMySql.getConnection());
                mComando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public void ModificarUsuario(Usuarios usuario)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE Usuarios SET Usuario = '{0}', Password = '{1}', Perfil = '{2}' WHERE Id = '{3}'",
                                                                             usuario.Usuario, usuario.Password, usuario.Perfil, usuario.Id), conexionMySql.getConnection());
                mComando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public void EliminarUsuario(Usuarios usuario)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM Usuarios WHERE Id = '{0}'", usuario.Id), conexionMySql.getConnection());
                mComando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public void LoginUsuario(string usuario, string password)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("SELECT * FROM Usuarios WHERE Usuario = '{0}' AND Password = '{1}'", usuario, password), conexionMySql.getConnection());
                MySqlDataReader mReader = mComando.ExecuteReader();
                mReader.Read();
                mReader.Close();

            }
            catch
            {
                throw;
            }
        }

        public void LoginUsuarioSupervisor(string Password, string Perfil)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("SELECT * FROM Usuarios WHERE Password = '{0}' AND Perfil = '{2}'", Password, Perfil), conexionMySql.getConnection());
                MySqlDataReader mReader = mComando.ExecuteReader();
                mReader.Read();
                mReader.Close();

            }
            catch
            {
                throw;
            }
        }
    }
}
