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
using System.Numerics;
using System.Threading;

namespace TouchUP.Visores
{
    public partial class EliminarRegistroFallas : Form
    {
        private List<RegistroFallas> mRegistroFallas;
        private RegistroFallasConsultas mRegistroFallasConsultas;

        public EliminarRegistroFallas(string Placa, string Componente, string Falla, string Usuario)
        {
            InitializeComponent();

            mRegistroFallas = new List<RegistroFallas>();
            mRegistroFallasConsultas = new RegistroFallasConsultas();
            
            this.Cursor = Cursors.Default;

            obtenerRegistrosString(Placa, Componente, Falla);

            // Titulo Pantalla
            this.Text = "Eliminar registros en " + Placa + " / Componente: " + Componente;

            // Titulo groupBoxDataGrid
            groupBoxDataGrid.Text = Placa + " ("+ contarRegistros() + " REGISTROS)";

            // LblAccionCorrectiva
            LblAccionCorrectiva.Text = "Ingrese los comentarios de la acción correctiva para estos componentes...";
            LblComponente.Text = Componente + "/" + Falla;

            // LblUsuario
            LblUsuario.Text = Usuario;
        }

        // Llenar dataGridRegistroFallas segun Strings recibidos

        private List<RegistroFallas> obtenerRegistrosString(string Placa, string Componente, string Falla)
        {

            Cursor.Current = Cursors.WaitCursor;

            // Limpiar dataGridRegistrosSelected
            mRegistroFallas = mRegistroFallasConsultas.RegistroFallasSelected(Placa, Componente, Falla);

            foreach (var registroFallas in mRegistroFallas)
            {
                dataGridRegistrosSelected.Rows.Add(registroFallas.FechaHora, registroFallas.Modelo, registroFallas.Placa, registroFallas.Componente, registroFallas.Falla);
            }

            Cursor.Current = Cursors.Default;

            return mRegistroFallas;
        }

        // Contar registros de dataGridRegistrosSelected

        private int contarRegistros()
        {
            int registros = dataGridRegistrosSelected.Rows.Count;

            return registros;
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

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // EliminarRegistroFallasSelected dataGridRegistrosSelected

            Cursor.Current = Cursors.WaitCursor;
             
            if (dataGridRegistrosSelected.SelectedRows.Count > 0)
            {
                    string Placa = dataGridRegistrosSelected.CurrentRow.Cells["Placa"].Value.ToString();
                    string Componente = dataGridRegistrosSelected.CurrentRow.Cells["Componente"].Value.ToString();
                    string Falla = dataGridRegistrosSelected.CurrentRow.Cells["Falla"].Value.ToString();

                    string FechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string Modelo = dataGridRegistrosSelected.CurrentRow.Cells["Modelo"].Value.ToString();
                    string Comentarios = LblAccionCorrectiva.Text;

                    int Cantidad = contarRegistros();

                    string Usuario = LblUsuario.Text;

                    mRegistroFallasConsultas.AlmacenarRegistroFallas(FechaHora, Modelo, Placa, Componente, Cantidad, Falla, Comentarios, Usuario);
                    mRegistroFallasConsultas.EliminarRegistroFallasSelected(Placa, Componente, Falla);

                    this.Hide();

                    dataGridRegistrosSelected.Rows.Clear();

                    obtenerRegistrosString(Placa, Componente, Falla);

                MessageBox.Show("La acción correctiva fue realizada correctamente", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al procesar su solicitud. Por favor, reintente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblAccionCorrectiva_TextChanged(object sender, EventArgs e)
        {
            // si LblAccionCorrectiva.Text == "" entonces BtnEliminar.Enabled = false

            if (LblAccionCorrectiva == null || LblAccionCorrectiva.Text == "" || LblAccionCorrectiva.Text == "Ingrese los comentarios de la acción correctiva para estos componentes...")
            {
                // BtnEliminar
                BtnEliminar.Enabled = false;
                BtnEliminar.BackColor = System.Drawing.Color.Transparent;
                BtnEliminar.ForeColor = System.Drawing.Color.DarkGray;
                BtnEliminar.ForeColor = SystemColors.ControlDark;
                BtnEliminar.FlatStyle = FlatStyle.Flat;
                BtnEliminar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#cacaca");
                BtnEliminar.Image = global::TouchUP.Properties.Resources.BtnEliminarGrey;
            }
            else
            {
                // BtnEliminar
                BtnEliminar.Enabled = true;
                BtnEliminar.BackColor = ColorTranslator.FromHtml("#e80927");
                BtnEliminar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#e80927");
                BtnEliminar.ForeColor = System.Drawing.Color.White;
                BtnEliminar.Image = global::TouchUP.Properties.Resources.BtnEliminarWhite;
            }
        }

        private void LblAccionCorrectiva_Click(object sender, EventArgs e)
        {
            // LblAccionCorrectiva
            LblAccionCorrectiva.Text = "";
            LblAccionCorrectiva.ForeColor = System.Drawing.Color.DarkGray;
            LblAccionCorrectiva.BackColor = System.Drawing.Color.White;
            LblAccionCorrectiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LblAccionCorrectiva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        // Pausar Timer de formulario padre

        private void EliminarRegistroFallas_Load(object sender, EventArgs e)
        {
            // Pausar Timer de formulario padre

            DisplaySupervisor displaySupervisor = (DisplaySupervisor)Application.OpenForms["DisplaySupervisor"];
            displaySupervisor.timerUpdateBD.Stop();
        }
    }

}
