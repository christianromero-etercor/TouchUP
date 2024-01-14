using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchUP.Visores.operario;
using MySql.Data.MySqlClient;

namespace TouchUP
{
    public partial class OperarioInicio : Form
    {

        ConexionMySql conexionMySql = new ConexionMySql();
        ArticuloConsultas mArticulosConsultas = new ArticuloConsultas();
        Articulo mArticulo = new Articulo();

        public OperarioInicio(string Usuario)
        {
            InitializeComponent();

            // Deseleccionar botones
            BtnAA.FlatAppearance.BorderSize = 0;
            BtnTV.FlatAppearance.BorderSize = 0;

            if (Application.ProductVersion.Length > 3)
            {
                this.Text = "TouchUP" + " v" + Application.ProductVersion.Substring(0, 3) + " - Inicio (Operario)";
            }

            this.LblMensajePie.Text = "Modulo de selección Puesto de trabajo - " + "(" + Usuario + ")";
        }

        public void queryCantidadPlacasAA()
        {
            // Query para saber si hay placas disponibles para el puesto AA
            ConexionMySql conexionMySql = new ConexionMySql();
            ArticuloConsultas mArticulosConsultas = new ArticuloConsultas();
            Articulo mArticulo = new Articulo();
            string QUERY = "SELECT COUNT(Placa) FROM Maestro_Articulos WHERE Puesto = 'AA'";
            MySqlDataReader mReader = null;

            // Get
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMySql.getConnection();
            mReader = mComando.ExecuteReader();

            // If
            while (mReader.Read())
            {
                if (mReader.GetInt32("COUNT(Placa)") == 0) // Si no hay placas disponibles para el puesto TV se muestra un mensaje
                {
                    Cursor.Current = Cursors.WaitCursor;
                    MessageBox.Show("No hay placas disponibles para ingresar al módulo de selección de Placas de AA. Para habilitar esta pantalla deberá cargar su base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else // Si hay placas disponibles para el puesto TV se abre la pantalla de selectores de placas AA
                {
                    Cursor.Current = Cursors.WaitCursor;
                    TouchUP.Visores.operario.DisplayOperarioAA displayOperarioAA = new TouchUP.Visores.operario.DisplayOperarioAA();
                    this.Hide();
                    displayOperarioAA.ShowDialog();
                }
            }

        }

        public void queryCantidadPlacasTV()
        {
            // Query para saber si hay placas disponibles para el puesto TV
            ConexionMySql conexionMySql = new ConexionMySql();
            ArticuloConsultas mArticulosConsultas = new ArticuloConsultas();
            Articulo mArticulo = new Articulo();
            string QUERY = "SELECT COUNT(Placa) FROM Maestro_Articulos WHERE Puesto = 'TV'";
            MySqlDataReader mReader = null;

            // Get
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMySql.getConnection();
            mReader = mComando.ExecuteReader();

            // If
            while (mReader.Read())
            {
                if (mReader.GetInt32("COUNT(Placa)") == 0) // Si no hay placas disponibles para el puesto TV se muestra un mensaje
                {
                    MessageBox.Show("No hay placas disponibles para ingresar al módulo de selección de Placas de TV. Para habilitar esta pantalla deberá cargar su base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else // Si hay placas disponibles para el puesto TV se abre la pantalla de selectores de placas TV
                {
                    TouchUP.Visores.operario.DisplayOperarioTV displayOperarioTV = new TouchUP.Visores.operario.DisplayOperarioTV();
                    this.Hide();
                    displayOperarioTV.ShowDialog();
                }
            }

        }

        private void OperarioInicio_Load(object sender, EventArgs e)
        {

        }

        private void BtnAA_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            queryCantidadPlacasAA();
            
        }

        private void BtnTV_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            queryCantidadPlacasTV();

        }

        private void timerCopyright_Tick(object sender, EventArgs e)
        {
            TxtCopyright.Text = DateTime.Now.ToString("yyyy") + " Ⓒ Solnik SA - Proyectos y tecnología";
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Default;

        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}