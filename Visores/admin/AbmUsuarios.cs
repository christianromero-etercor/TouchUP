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
using TouchUP.Visores;
using TouchUP.Visores.admin;
using System.Threading;
using MySql.Data.MySqlClient;
using TouchUP.Visores.supervisor;

namespace TouchUP
{
    public partial class AbmUsuarios : Form
    {

        private List<Usuarios> mUsuarios;
        private UsuariosConsultas mUsuariosConsultas;

        public AbmUsuarios()
        {
            InitializeComponent();

            mUsuarios = new List<Usuarios>();
            mUsuariosConsultas = new UsuariosConsultas();

            this.toolTipRole.SetToolTip(this.TxtRole, "Para una correcta indexación de perfiles según roles de pantalla," + Environment.NewLine + "se debe respetar la siguiente jerarquía:" + Environment.NewLine + "1 para perfil Adminstrador" + Environment.NewLine + "2 para perfil Supervisor" + Environment.NewLine + "3 para perfil Operario");

            llenar_tabla();
            limpiar_campos();

            if (Application.ProductVersion.Length > 3)
            {
                this.Text = "TouchUP" + " v" + Application.ProductVersion.Substring(0, 3) + " - Administrador de Usuarios";
            }
        }

        public void llenar_tabla(string usuario = "")
        {
            DataGridUsuarios.Rows.Clear();
            DataGridUsuarios.Refresh();
            mUsuarios.Clear();
            mUsuarios = mUsuariosConsultas.GetUsuarios(usuario);

            Cursor.Current = Cursors.WaitCursor;

            for (int i=0; i < mUsuarios.Count; i++)
            {
                DataGridUsuarios.Rows.Add(mUsuarios[i].Id, mUsuarios[i].Usuario, mUsuarios[i].Password, mUsuarios[i].Perfil);
                DataGridUsuarios.ClearSelection();
            }

            DataGridUsuarios.ClearSelection();
            Cursor.Current = Cursors.Default;
        }


        public void limpiar_campos()
        {
            TxtUsuario.Clear();
            TxtPassword.Clear();
            TxtRole.Clear();
            DataGridUsuarios.ClearSelection();
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
                Cursor.Current = Cursors.WaitCursor;

                UsuariosConsultas mUsuariosConsultas = new UsuariosConsultas();
                Usuarios mUsuario = new Usuarios();
                mUsuario.Usuario = TxtUsuario.Text;
                mUsuario.Password = TxtPassword.Text;
                mUsuario.Perfil = Convert.ToInt32(TxtRole.Text);
                mUsuariosConsultas.AgregarUsuario(mUsuario);
                llenar_tabla();
                limpiar_campos();
                MessageBox.Show("El usuario " + TxtUsuario.Text + " ha sido agregado a la base de datos", "Confirmación de proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" || TxtPassword.Text == "" || TxtRole.Text == "")
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar de la base", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            if (DialogResult.Yes == MessageBox.Show("¿Seguro que deseas eliminar el usuario " + TxtUsuario.Text + " del acceso a la plataforma?", "Confirmación de Baja de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                ConexionMySql conexionMySql = new ConexionMySql();
                conexionMySql.eliminarUsuario(DataGridUsuarios.SelectedCells[0].Value.ToString());

                llenar_tabla();
                limpiar_campos();
                MessageBox.Show("El usuario ha sido eliminado de la base de datos", "Baja de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                return;
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
            {
                Cursor.Current = Cursors.WaitCursor;

                ConexionMySql conexionMySql = new ConexionMySql();
                conexionMySql.modificarUsuario(DataGridUsuarios.SelectedCells[0].Value.ToString(), TxtUsuario.Text, TxtPassword.Text, TxtRole.Text);
                
                llenar_tabla();
                limpiar_campos();

                MessageBox.Show("Los datos de ingreso han sido modificados correctamente", "Confirmación de proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            LoginForm Inicio = new LoginForm();
            this.Hide();
            Inicio.Show();
        }

        private void VisorOperarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            OperarioInicio DisplayOperario = new OperarioInicio(TxtUsuario.Text);
            this.Hide();
            DisplayOperario.Show();
        }

        private void VisorSupervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

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
            Cursor.Current = Cursors.WaitCursor;

            LoginForm Inicio = new LoginForm();
            this.Hide();
            Inicio.Show();
        }

        private void AbmArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            AbmArticulos abmArticulos = new AbmArticulos();
            abmArticulos.Show();
            this.Hide();

        }

        private void AbmProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            AbmArticulos abmArticulos = new AbmArticulos();
            abmArticulos.Show();
            this.Hide();
        }

        private void ButtonsActivated_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario != null || TxtPassword != null || TxtRole != null)
            {
                // Modificar Button
                BtnModificar.Enabled = true;
                BtnModificar.BackColor = ColorTranslator.FromHtml("#99b4d1");
                BtnModificar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#99b4d1");
                BtnModificar.ForeColor = Color.White;
                BtnModificar.Image = global::TouchUP.Properties.Resources.BtnEditarWhite;

                // Eliminar Button
                BtnEliminar.Enabled = true;
                BtnEliminar.BackColor = ColorTranslator.FromHtml("#f08080");
                BtnEliminar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#f08080");
                BtnEliminar.ForeColor = Color.White;
                BtnEliminar.Image = global::TouchUP.Properties.Resources.BtnEliminarWhite;
            }
            else
            {
                // Modificar Button
                BtnModificar.Enabled = false;
                BtnModificar.BackColor = Color.Transparent;
                BtnModificar.ForeColor = Color.DarkGray;
                BtnModificar.ForeColor = SystemColors.ControlDark;
                BtnModificar.FlatStyle = FlatStyle.Flat;
                BtnModificar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#cacaca");
                BtnModificar.Image = global::TouchUP.Properties.Resources.BtnEditarGrey;

                // Eliminar Button
                BtnEliminar.Enabled = false;
                BtnEliminar.BackColor = Color.Transparent;
                BtnEliminar.ForeColor = Color.DarkGray;
                BtnEliminar.ForeColor = SystemColors.ControlDark;
                BtnEliminar.FlatStyle = FlatStyle.Flat;
                BtnEliminar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#cacaca");
                BtnEliminar.Image = global::TouchUP.Properties.Resources.BtnEliminarGrey;
            }

        }

        private void DataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUsuario.Text = DataGridUsuarios.SelectedCells[1].Value.ToString();
            TxtPassword.Text = DataGridUsuarios.SelectedCells[2].Value.ToString();
            TxtRole.Text = DataGridUsuarios.SelectedCells[3].Value.ToString();

        }
    }
}
