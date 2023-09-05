using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace TouchUP
{
    public partial class DisplayAdmin : Form
    {
        public DisplayAdmin(string Usuario)
        {
            InitializeComponent();
            LblMensaje.Text = "Hola, " + Usuario;

            this.toolTipRole.SetToolTip(this.TxtRole, "Para una correcta indexación de perfiles según roles de pantalla," + Environment.NewLine + "se debe respetar la siguiente jerarquía:" + Environment.NewLine + "1 para perfil Adminstrador" + Environment.NewLine + "2 para perfil Supervisor" + Environment.NewLine + "3 para perfil Operario");
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Model;Integrated Security=True");

        public void llenar_tabla()
        {
            string consulta = "select * from Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void limpiar_campos()
        {
            TxtUsuario.Clear();
            TxtPassword.Clear();
            TxtRole.Clear();
        }

        private void DisplayAdmin_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" || TxtPassword.Text == "" || TxtRole.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (TxtRole.Text != "1" && TxtRole.Text != "2" && TxtRole.Text != "3")
            {
                MessageBox.Show("El campo de Perfil debe contener un valor numérico entre 1 y 3", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
            cn.Open();
            string consulta = "insert into Usuarios values ('" + TxtUsuario.Text + "','" + TxtPassword.Text + "','" + TxtRole.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, cn);
            comando.ExecuteNonQuery();
            llenar_tabla();
            MessageBox.Show("El usuario " + TxtUsuario.Text + " ha sido agregado a la base de datos", "Alta de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar_campos();
            cn.Close();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" || TxtPassword.Text == "" || TxtRole.Text == "")
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar de la base", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            cn.Open();
            string consulta = "delete from Usuarios where Usuario = '" + TxtUsuario.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, cn);
            comando.ExecuteNonQuery();
            
            if (DialogResult.Yes == MessageBox.Show("¿Seguro que deseas eliminar el usuario " + TxtUsuario.Text + " del acceso a la plataforma?", "Confirmación de Baja de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                llenar_tabla();
                limpiar_campos();
                MessageBox.Show("El usuario ha sido eliminado de la base de datos", "Baja de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
            }
            else
            {
            cn.Close();
        }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" || TxtPassword.Text == "" || TxtRole.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (TxtRole.Text != "1" && TxtRole.Text != "2" && TxtRole.Text != "3")
            {
                MessageBox.Show("El campo de Perfil debe contener un valor numérico entre 1 y 3 según la configuración de los accesos a la plataforma", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            cn.Open();
            string consulta = "update Usuarios set Password = '" + TxtPassword.Text + "', Role = '" + TxtRole.Text + "' where Usuario = '" + TxtUsuario.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, cn);
            comando.ExecuteNonQuery();
            llenar_tabla();
            MessageBox.Show("Los datos del usuario " + TxtUsuario.Text + " han sido modificados", "Confirmación de proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar_campos();
            cn.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUsuario.Text = dataGridView1.SelectedCells[1].Value.ToString();
            TxtPassword.Text = dataGridView1.SelectedCells[2].Value.ToString();
            TxtRole.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show();
        }

        private void VisorOperarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayOperarioInicio DisplayOperario = new DisplayOperarioInicio(TxtUsuario.Text);
            this.Hide();
            DisplayOperario.Show();
        }

        private void VisorSupervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplaySupervisor DisplaySupervisor = new DisplaySupervisor(TxtUsuario.Text);
            this.Hide();
            DisplaySupervisor.Show();
        }

        private void AbmUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void LblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
