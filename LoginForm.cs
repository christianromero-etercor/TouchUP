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

namespace TouchUP
{
    public partial class LoginForm : Form
    {

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


        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Model;Integrated Security=True");

        // Login

        public void Login(string Usuario, string Password) {

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario, Password, Role FROM Usuarios WHERE Usuario = @Usuario AND Password = @Password", cn);
                cmd.Parameters.AddWithValue("Usuario", Usuario);
                cmd.Parameters.AddWithValue("Password", Password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][2].ToString() == "1")
                    {
                        new DisplayAdmin(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][2].ToString() == "2")
                    {
                        new DisplaySupervisor(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][2].ToString() == "3")
                    {
                        new DisplayOperarioInicio(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario o contraseña es incorrecto", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cn.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoSolnikDark_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxBackground_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (radioButtonFHD.Checked == true)
            {
                DisplayOperarioTV displayOperarioTV = new DisplayOperarioTV();
                displayOperarioTV.Show();
                this.Hide();
            }
            if (radioButtonWXGA.Checked == true)
            {
                DisplayOperarioAA displayOperarioAA = new DisplayOperarioAA();
                displayOperarioAA.Show();
                this.Hide();
            }
        }

        private void PicPassShow_Click(object sender, EventArgs e)
        {
            if(TxtPassword.PasswordChar == '*')
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
