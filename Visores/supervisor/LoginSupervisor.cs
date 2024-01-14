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
using System.Threading;

namespace TouchUP.Visores.supervisor
{
    public partial class LoginSupervisor : Form
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

        public LoginSupervisor()
        {
            InitializeComponent();

            mUsuarios = new List<Usuarios>();
            mUsuariosConsultas = new UsuariosConsultas();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

        }

        // Login Supervisor

        public void Login(string Password)
        {

            try
            {
                ConexionMySql conexion = new ConexionMySql();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Usuarios WHERE Perfil = 2 AND Password = @Password", conexion.getConnection());
                cmd.Parameters.AddWithValue("password", Password);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][3].ToString() == "2") // Si el usuario es supervisor se abre la pantalla de supervisor
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        this.Close();
                        string Usuario = dt.Rows[0][1].ToString();
                        DisplaySupervisor displaySupervisor = new DisplaySupervisor(Usuario);
                        displaySupervisor.Show();

                        foreach (Form frm in Application.OpenForms)
                        {
                            if (frm.Name == "VisorTouchFHD" || frm.Name == "VisorTouchWXGA")
                            {
                                frm.Close();
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("La contraseña ingresada no corresponde a un usuario Supervisor", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts."))
                {
                    MessageBox.Show("Error de conexión. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Si el form VisorTouchFHD está abierto, se pausa el timer
            if (Application.OpenForms["VisorTouchFHD"] != null)
            {
                VisorTouchFHD visorTouchFHD = (VisorTouchFHD)Application.OpenForms["VisorTouchFHD"];
                visorTouchFHD.timerUpdateBD.Stop();
            }
            // Si el form VisorTouchWXGA está abierto, se pausa el timer
            if (Application.OpenForms["VisorTouchWXGA"] != null)
            {
                VisorTouchWXGA visorTouchWXGA = (VisorTouchWXGA)Application.OpenForms["VisorTouchWXGA"];
                visorTouchWXGA.timerUpdateBD.Stop();
            }

            Cursor.Current = Cursors.WaitCursor;

            string Password = TxtPassword.Text;

            Login(Password);

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtPassword.Clear();
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

    }
}
