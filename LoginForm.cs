using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TouchUP.Visores.operario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics.Eventing.Reader;
using TouchUP.Visores;
using TouchUP.Visores.admin;
using MySql.Data.MySqlClient;
using System.CodeDom;
using TouchUP.Placas.AA;
using TouchUP.Visores.supervisor;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace TouchUP
{
    public partial class LoginForm : Form
    {

        private List<Usuarios> mUsuarios;
        private UsuariosConsultas mUsuariosConsultas;

        // Rounded corners

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        // Form

        public LoginForm()
        {
            InitializeComponent();

            mUsuarios = new List<Usuarios>();
            mUsuariosConsultas = new UsuariosConsultas();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            // Version

            if (Application.ProductVersion.Length > 3)
            {
                TxtVersion.Text = TxtVersion.Text.Substring(0, 3);
                this.Text = "TouchUp Solnik" + " v" + Application.ProductVersion.Substring(0, 3) + " - Inicio de sesión";
                this.TxtVersion.Text = "v" + Application.ProductVersion.Substring(0, 3);
            }
        }

        public void Login(string Usuario, string Password)
        {
            try
            {
                ConexionMySql conexion = new ConexionMySql();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Password = @Password", conexion.getConnection());
                cmd.Parameters.AddWithValue("usuario", Usuario);
                cmd.Parameters.AddWithValue("password", Password);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][3].ToString() == "0" || dt.Rows[0][3].ToString() == "1") // Si el usuario es superadmin o admin se abre la pantalla de administrador
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        AdminInicio adminForm = new AdminInicio(Usuario);
                        adminForm.Show();
                    }
                    if (dt.Rows[0][3].ToString() == "2") // Si el usuario es supervisor se abre la pantalla de supervisor
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DisplaySupervisor displaySupervisor = new DisplaySupervisor(Usuario);
                        displaySupervisor.Show();
                    }
                    if (dt.Rows[0][3].ToString() == "3") // Si el usuario es operario se abre la pantalla de operario
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        OperarioInicio operarioinicio = new OperarioInicio(Usuario);
                        operarioinicio.Show();
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario o contraseña son incorrectos. Por favor, intente nuevamente.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Application.Restart();
            }
        }

        class RoundedButton : Button
        {
            GraphicsPath GetRoundPath(RectangleF Rect, int radius)
            {
                float r2 = radius / 2f;
                GraphicsPath GraphPath = new GraphicsPath();
                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
                GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                 Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
                GraphPath.CloseFigure();
                return GraphPath;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
                using (GraphicsPath GraphPath = GetRoundPath(Rect, 50))
                {
                    this.Region = new Region(GraphPath);
                    using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawPath(pen, GraphPath);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del programa?", "TouchUP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxtCopyright.Text = DateTime.Now.ToString("yyyy") + " Ⓒ Solnik SA - Proyectos y tecnología";

        }

        private void TxtCopyright_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Login(this.TxtUsuario.Text, this.TxtPassword.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtPassword.Clear();
        }

        protected void radioButtonFHD_CheckedChanged(object sender, EventArgs e)
        {
            BtnVisualizar.Enabled = radioButtonFHD.Checked;
            BtnVisualizar.BackColor = ColorTranslator.FromHtml("#4169E1");
            BtnVisualizar.ForeColor = Color.White;
            BtnVisualizar.FlatStyle = FlatStyle.Flat;
            BtnVisualizar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#4169E1");
        }

        protected void radioButtonWXGA_CheckedChanged(object sender, EventArgs e)
        {
            BtnVisualizar.Enabled = radioButtonWXGA.Checked;
            BtnVisualizar.BackColor = ColorTranslator.FromHtml("#4169E1");
            BtnVisualizar.ForeColor = Color.White;
            BtnVisualizar.FlatStyle = FlatStyle.Flat;
            BtnVisualizar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#4169E1");
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            // No abrir si no hay conexión a internet

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                if (radioButtonFHD.Checked == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    VisorTouchFHD visorTouchFHD = new VisorTouchFHD();
                    visorTouchFHD.Show();
                    this.Hide();
                }
                if (radioButtonWXGA.Checked == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    VisorTouchWXGA visorTouchWXGA = new VisorTouchWXGA();
                    visorTouchWXGA.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Se perdió la conexión con el servidor. Por favor, verifique su conexión e intente nuevamente.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PicPassShow_Click(object sender, EventArgs e)
        {
            if (TxtPassword.PasswordChar == '*')
            {
                PicEyeHide.BringToFront();
                TxtPassword.PasswordChar = '\0';
            }
            else if (TxtPassword.Text != null)
            {
                PicEyeHide.Visible = true;
            }
            else
            {
                PicEyeHide.Visible = false;
            }
        }

        private void PicPassHide_Click(object sender, EventArgs e)
        {
            if (TxtPassword.PasswordChar == '\0')
            {
                PicEyeOpen.BringToFront();
                TxtPassword.PasswordChar = '*';
            }
        }

        private void linkLabelPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "mailto:sistemasba@solnik.com.ar?subject=TouchUP%20-%20Solicitud%20de%20cambio%20de%acceso";
            proc.Start();

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtPassword.Text != null)
            {
                PicEyeOpen.Visible = true;
            }
            else
            {
                PicEyeOpen.Visible = false;
            }
        }

        private void BtnInfoApp_Click(object sender, EventArgs e)
        {
            Updater updater = new Updater();
            updater.ShowDialog();
        }
    }
}
