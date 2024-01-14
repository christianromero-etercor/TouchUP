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
using SpreadsheetLight;

namespace TouchUP.Visores
{
    public partial class HistoricoRegistroFallas : Form
    {
        private List<RegistroFallas> mRegistroFallas;
        private RegistroFallasConsultas mRegistroFallasConsultas;

        public HistoricoRegistroFallas()
        {
            InitializeComponent();

            mRegistroFallas = new List<RegistroFallas>();
            mRegistroFallasConsultas = new RegistroFallasConsultas();

            this.Cursor = Cursors.Default;

            ObtenerRegistrosFallasAcciones();

            // Titulo Pantalla
            this.Text = "Historico - Acciones Correctivas";
            this.groupBoxDataGrid.Text = "Registros de Fallas y Acciones Correctivas (" + contarRegistros() + " REGISTROS)";

        }

        private void HistoricoRegistroFallas_Load(object sender, EventArgs e)
        {

        }

        public void ObtenerRegistrosFallasAcciones()
        {
            mRegistroFallas = new List<RegistroFallas>();
            mRegistroFallasConsultas = new RegistroFallasConsultas();

            this.Cursor = Cursors.Default;

            // Limpiar dataGridRegistrosSelected
            mRegistroFallas = mRegistroFallasConsultas.ObtenerRegistroFallasAcciones();

            foreach (var registroFallas in mRegistroFallas)
            {
                dataGridHistoricosRegistrosFallas.Rows.Add(registroFallas.FechaHora, registroFallas.Modelo, registroFallas.Placa, registroFallas.Componente, registroFallas.Cantidad, registroFallas.Falla, registroFallas.Comentarios, registroFallas.Usuario);
            }
        }

        // Contar registros de dataGridRegistrosSelected

        private int contarRegistros()
        {
            int registros = dataGridHistoricosRegistrosFallas.Rows.Count;

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            SLDocument sl = new SLDocument();

            int iC = 1;
            foreach (DataGridViewColumn column in dataGridHistoricosRegistrosFallas.Columns)
            {
                    sl.SetCellValue(1, iC, column.HeaderText);
                    iC++;
            }

            int iR = 2;
            foreach (DataGridViewRow row in dataGridHistoricosRegistrosFallas.Rows)
            {
                sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                sl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                sl.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                sl.SetCellValue(iR, 8, row.Cells[7].Value.ToString());

                iR++;
            }

            sl.SaveAs("C:\\Users\\Public\\Documents\\TouchUP - Histórico de Fallas y Acciones Correctivas al " + DateTime.Now.ToString("dd-MM-yyyy hh-mm") + ".xlsx");
            MessageBox.Show("El archivo se ha exportado correctamente en la carpeta" + "\r\n" + "C:\\Users\\Public\\Documents", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CursorHand_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void CursorHand_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void HistoricoRegistroFallas_MaximumSizeChanged(object sender, EventArgs e)
        {
            dataGridHistoricosRegistrosFallas.Height = this.Height - 21;
        }
    }

}
