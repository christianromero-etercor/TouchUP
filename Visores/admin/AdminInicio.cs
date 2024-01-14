using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchUP.Visores.supervisor;

namespace TouchUP.Visores.admin
{
    public partial class AdminInicio : Form
    {
        public AdminInicio(string Usuario)
        {
            InitializeComponent();
            LblHeadline.Text = "Hola, " + Usuario;

            if (Application.ProductVersion.Length > 3)
            {
                this.Text = "TouchUP" + " v" + Application.ProductVersion.Substring(0, 3) + " - Módulo de Administración";
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            AbmUsuarios abmUsuarios = new AbmUsuarios();
            abmUsuarios.Show();
            this.Hide();
        }

        private void timerCopyright_Tick(object sender, EventArgs e)
        {
            TxtCopyright.Text = DateTime.Now.ToString("yyyy") + " Ⓒ Solnik SA - Proyectos y tecnología";
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Application.Exit();

        }

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            AbmArticulos abmArticulos = new AbmArticulos();
            abmArticulos.Show();
            this.Hide();
        }

        private void BtnOperario_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string Usuario = "Operario";
            OperarioInicio operarioInicio = new OperarioInicio(Usuario);
            operarioInicio.Show();
        }

        private void fullHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            VisorTouchFHD visorTouchFHD = new VisorTouchFHD();
            visorTouchFHD.Show();
        }

        private void wXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            VisorTouchWXGA visorTouchWXGA = new VisorTouchWXGA();
            visorTouchWXGA.Show();
        }

        private void visorSupervisorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string Usuario = "Supervisor";
            DisplaySupervisor displaySupervisor = new DisplaySupervisor(Usuario);
            displaySupervisor.Show();
        }

        private void BtnSupervisor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string Usuario = "Supervisor";
            DisplaySupervisor displaySupervisor = new DisplaySupervisor(Usuario);
            displaySupervisor.Show();
        }

        private void visorOperarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string Usuario = "Operario";
            OperarioInicio operarioInicio = new OperarioInicio(Usuario);
            operarioInicio.Show();
        }
    }
}