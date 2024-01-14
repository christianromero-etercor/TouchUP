using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchUP.Visores.operario;
using MySql.Data.MySqlClient;
using DocumentFormat.OpenXml.Spreadsheet;
using MySqlX.XDevAPI.Relational;
using TouchUP.Visores.supervisor;
using System.Threading;
using DocumentFormat.OpenXml.Drawing;

namespace TouchUP.Visores
{
    public partial class DisplaySupervisor : Form
    {

        private List<RegistroFallas> mRegistroFallas;
        private RegistroFallasConsultas mRegistroFallasConsultas;

        public string Usuario { get; private set; }

        public DisplaySupervisor(string Usuario)
        {
            InitializeComponent();

            using (Loader form = new Loader(SaveData))
            {
                form.ShowDialog(this);
            }


            mRegistroFallas = new List<RegistroFallas>();
            mRegistroFallasConsultas = new RegistroFallasConsultas();

            DoubleBufferedListBox(listBoxFallasAA);
            
            Cursor = Cursors.Arrow;

            this.LblUsuario.Text = Usuario;
        }

        private void DisplaySupervisor_Load(object sender, EventArgs e)
        {
            if (Application.ProductVersion.Length > 3)
            {
                this.Text = "TouchUP" + " v" + Application.ProductVersion.Substring(0, 3) + " - Alertas de Fallas (Supervisor)";
            }
        }

        // Loader
        void SaveData()
        {
            for (int i = 0; i <= 125; i++)
            {
                Thread.Sleep(10);//Loader
            }
        }

        public void DoubleBufferedListBox(ListBox listBox)
        {
            // DoubleBuffered para ListBox
            typeof(ListBox).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, listBox, new object[] { true });
        }

        public void llenarListBoxQueryFallasSupervisorAA()
        {
            ConexionMySql conexionMySql = new ConexionMySql();
            conexionMySql.getConnection();

            MySqlCommand command = new MySqlCommand("SELECT CONCAT(Placa, ' » ', Componente, ' » ', Falla, ' (', Cantidad,')') as Pendiente FROM Registros_Visor_Count WHERE Cantidad >=3 AND Puesto = 'AA' ORDER BY Cantidad DESC;", conexionMySql.getConnection());
            command.CommandType = CommandType.Text;

            MySqlDataReader reader = command.ExecuteReader();

            listBoxFallasAA.Items.Clear();

            while (reader.Read())
            {
                listBoxFallasAA.Items.Add(reader.GetString(0));

            }

            conexionMySql.closeConnection();
        }

        public void llenarListBoxQueryFallasSupervisorTV()
        {
            ConexionMySql conexionMySql = new ConexionMySql();
            conexionMySql.getConnection();

            MySqlCommand command = new MySqlCommand("SELECT CONCAT(Placa, ' » ', Componente, ' » ', Falla, ' (', Cantidad,')') as Pendiente FROM Registros_Visor_Count WHERE Cantidad >=3 AND Puesto = 'TV' ORDER BY Cantidad DESC;", conexionMySql.getConnection());
            command.CommandType = CommandType.Text;

            MySqlDataReader reader = command.ExecuteReader();

            listBoxFallasTV.Items.Clear();

            while (reader.Read())
            {
                listBoxFallasTV.Items.Add(reader.GetString(0));

            }

            conexionMySql.closeConnection();
        }

        private void BtnLoginSupervisor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            LoginSupervisor loginSupervisor = new LoginSupervisor();
            loginSupervisor.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Application.Exit();
        }

        private void timerUpdateBD_Tick(object sender, EventArgs e)
        {
            llenarListBoxQueryFallasSupervisorAA();
            llenarListBoxQueryFallasSupervisorTV();

            LblHeaderAA.Text = "  Puesto AA (Alarmas activas: " + listBoxFallasAA.Items.Count + ")";
            LblHeaderTV.Text = "  Puesto TV (Alarmas activas: " + listBoxFallasTV.Items.Count + ")";

            // ListBoxFallasAA.Control
            if(listBoxFallasAA.Items.Count > 0)
            {
                listBoxFallasAA.BackColor = ColorTranslator.FromHtml("#e80927");
                listBoxFallasAA.ForeColor = ColorTranslator.FromHtml("#fff");
                LblNoRegAA.Visible = false;
                panelHeaderAA.BackColor = ColorTranslator.FromHtml("#e80927");
                LblHeaderAA.BackColor = ColorTranslator.FromHtml("#e80927");
            }
            else
            {
                listBoxFallasAA.BackColor = System.Drawing.Color.DodgerBlue;
                listBoxFallasAA.ForeColor = ColorTranslator.FromHtml("#fff");
                LblNoRegAA.Visible = true;
                panelHeaderAA.BackColor = ColorTranslator.FromHtml("#51abff");
                LblHeaderAA.BackColor = ColorTranslator.FromHtml("#51abff");
            }

            // ListBoxFallasTV.Control
            if (listBoxFallasTV.Items.Count > 0)
            {
                listBoxFallasTV.BackColor = ColorTranslator.FromHtml("#e80927");
                listBoxFallasTV.ForeColor = ColorTranslator.FromHtml("#fff");
                LblNoRegTV.Visible = false;
                panelHeaderTV.BackColor = ColorTranslator.FromHtml("#e80927");
                LblHeaderTV.BackColor = ColorTranslator.FromHtml("#e80927");
            }
            else
            {
                listBoxFallasTV.BackColor = System.Drawing.Color.MediumTurquoise;
                listBoxFallasTV.ForeColor = ColorTranslator.FromHtml("#fff");
                LblNoRegTV.Visible = true;
                panelHeaderTV.BackColor = System.Drawing.Color.Turquoise;
                LblHeaderTV.BackColor = System.Drawing.Color.Turquoise;
            }

            // Status Alarma

            if (listBoxFallasAA.Items.Count > 0 || listBoxFallasTV.Items.Count > 0)
            {
                lblStatusAlarm.Image = global::TouchUP.Properties.Resources.alarm50;
                lblStatusAlarm.Text = "La alarma se encuentra encendida";
                lblStatusAlarm.ForeColor = ColorTranslator.FromHtml("#e80927");
            }
            else
            {
                lblStatusAlarm.Text = "La alarma se encuentra apagada";
                lblStatusAlarm.ForeColor = System.Drawing.Color.Silver;
                lblStatusAlarm.Image = null;
            }


        }

        private void BtnDataAA_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDataAA_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnDataTV_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDataTV_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnInicio_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnInicio_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnInicio_Click(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        private void BtnSalir_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void listBoxFallas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // abrir pantalla para eliminar registro en Registro_Fallas

            Cursor = Cursors.Hand;

            // AA
            if (listBoxFallasAA.Items.Count > 0 && listBoxFallasAA.SelectedItem != null)
            {
                // Obtener string Placa, Componente, Falla
                string Placa = listBoxFallasAA.SelectedItem.ToString().Split('»')[0].Trim();
                string Componente = listBoxFallasAA.SelectedItem.ToString().Split('»')[1].Trim();
                string Falla = listBoxFallasAA.SelectedItem.ToString().Split('»')[2].Split('(')[0].Trim();

                string Usuario = LblUsuario.Text;

                // Abrir EliminarRegistroFallas y enviar string Placa, Componente, Falla
                EliminarRegistroFallas eliminarRegistroFallas = new EliminarRegistroFallas(Placa, Componente, Falla, Usuario);
                eliminarRegistroFallas.ShowDialog(LblUsuario);
            }

            // TV
            if (listBoxFallasTV.Items.Count > 0 && listBoxFallasTV.SelectedItem != null)
            {
                // Obtener string Placa, Componente, Falla
                string Placa = listBoxFallasTV.SelectedItem.ToString().Split('»')[0].Trim();
                string Componente = listBoxFallasTV.SelectedItem.ToString().Split('»')[1].Trim();
                string Falla = listBoxFallasTV.SelectedItem.ToString().Split('»')[2].Split('(')[0].Trim();

                string Usuario = LblUsuario.Text;

                // Abrir EliminarRegistroFallas y enviar string Placa, Componente, Falla
                EliminarRegistroFallas eliminarRegistroFallas = new EliminarRegistroFallas(Placa, Componente, Falla, Usuario);
                eliminarRegistroFallas.ShowDialog();
            }
        }

        private void fullHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir VisorTouchFHD

            Cursor.Current = Cursors.WaitCursor;

            VisorTouchFHD visorTouchFHD = new VisorTouchFHD();
            visorTouchFHD.Show();
            this.Close();
        }

        private void wXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir VisorTouchWXGA

            Cursor.Current = Cursors.WaitCursor;

            VisorTouchWXGA visorTouchWXGA = new VisorTouchWXGA();
            visorTouchWXGA.Show();
            this.Close();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerrar sesión y volver a Login

            Cursor.Current = Cursors.WaitCursor;

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void BtnHistoricoFallas_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            HistoricoRegistroFallas historicoRegistroFallas = new HistoricoRegistroFallas();
            historicoRegistroFallas.Show();
        }
    }

}
