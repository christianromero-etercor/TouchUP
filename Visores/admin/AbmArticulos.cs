using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SpreadsheetLight;

namespace TouchUP.Visores.admin
{
    public partial class AbmArticulos : Form
    {

        private List<Articulo> mArticulos;
        private ArticuloConsultas mArticulosConsultas;
        public AbmArticulos()
        {
            InitializeComponent();

            mArticulos = new List<Articulo>();
            mArticulosConsultas = new ArticuloConsultas();

            cargarProductos();
            cargarMarca();
            cargarPuesto();

            if (Application.ProductVersion.Length > 3)
            {
                this.Text = "TouchUP" + " v" + Application.ProductVersion.Substring(0, 3) + " - Maestro de Artículos";
            }
        }


        public static DataGridViewRow selectedrow;

        void SaveData()
        {
            for (int i = 0; i <= 125; i++)
            {
                Thread.Sleep(10);//Loader
            }
        }

        public void DisplayTotalRegistros()
        {
            if (dataGridViewProductos.Rows.Count == 1)
            {
                LblRegistros.Visible = true;
                LblRegistros.Text = dataGridViewProductos.Rows.Count.ToString() + " Registro" + " | " + DateTime.Now.ToString();
                LblExportar.Visible = true;
            }
            else if (dataGridViewProductos.Rows.Count > 1)
            {
                LblRegistros.Visible = true;
                LblRegistros.Text = dataGridViewProductos.Rows.Count.ToString() + " Registros" + " | " + DateTime.Now.ToString();
                LblExportar.Visible = true;
            }
            else
            {
                LblRegistros.Text = "No se han encontrado registros";
                LblRegistros.Visible = true;
                LblExportar.Visible = false;
            }
        }

        public void cargarProductos(string filtro = "")
        {
            LblRegistros.Visible = false;
            dataGridViewProductos.Rows.Clear();
            dataGridViewProductos.Refresh();
            mArticulos.Clear();
            mArticulos = mArticulosConsultas.getProductos(filtro);

            using (Loader form = new Loader(SaveData))
            {
                form.ShowDialog(this);
            }

            for (int i = 0; i < mArticulos.Count; i++)
            {
                dataGridViewProductos.RowTemplate.Height = 130;
                dataGridViewProductos.Rows.Add(mArticulos[i].Id, mArticulos[i].Puesto, mArticulos[i].Marca, mArticulos[i].Modelo, mArticulos[i].Placa, mArticulos[i].Imagen);
            }

            DisplayTotalRegistros();
        }

        // Carga Marca en CmbMarcaFiltro no acumula marcas repetidas

        public void cargarMarca()
        {
            ConexionMySql conexionMySql = new ConexionMySql();
            string QUERY = "SELECT DISTINCT Marca FROM Maestro_Articulos ORDER BY Marca ASC";
            MySqlDataReader mReader = null;

            // Get
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMySql.getConnection();
            mReader = mComando.ExecuteReader();

            // If
            while (mReader.Read())
            {
                //Agregar item al combobox no acumula Marcas repetidas
                if (!CmbMarcaFiltro.Items.Contains(mReader.GetString("Marca")))
                {
                    CmbMarcaFiltro.Items.Add(mReader.GetString("Marca"));
                }
            }

            mReader.Close();
        }

        // Carga Puesto en CmbPuestoFiltro

        public void cargarPuesto()
        {
            ConexionMySql conexionMySql = new ConexionMySql();
            string QUERY = "SELECT DISTINCT Puesto FROM Maestro_Articulos ORDER BY Puesto ASC";
            MySqlDataReader mReader = null;

            // Get
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMySql.getConnection();
            mReader = mComando.ExecuteReader();

            // If
            while (mReader.Read())
            {
                //Agregar item al combobox no acumula Puesto repetidas
                if (!CmbPuestoFiltro.Items.Contains(mReader.GetString("Puesto")))
                {
                    CmbPuestoFiltro.Items.Add(mReader.GetString("Puesto"));
                }
            }

            mReader.Close();
        }


        private void BusquedaPuesto(string filtro = "")
        {
            dataGridViewProductos.Rows.Clear();
            dataGridViewProductos.Refresh();
            mArticulos.Clear();
            mArticulos = mArticulosConsultas.getProductosPuesto(filtro);

            for (int i = 0; i < mArticulos.Count; i++)
            {
                dataGridViewProductos.RowTemplate.Height = 175;
                dataGridViewProductos.Rows.Add(mArticulos[i].Id, mArticulos[i].Puesto, mArticulos[i].Marca, mArticulos[i].Modelo, mArticulos[i].Placa, mArticulos[i].Imagen);
            }

            DisplayTotalRegistros();

        }

        private void BusquedaMarca(string filtro = "")
        {
            dataGridViewProductos.Rows.Clear();
            dataGridViewProductos.Refresh();
            mArticulos.Clear();
            mArticulos = mArticulosConsultas.getProductosMarca(filtro);

            for (int i = 0; i < mArticulos.Count; i++)
            {
                dataGridViewProductos.RowTemplate.Height = 175;
                dataGridViewProductos.Rows.Add(mArticulos[i].Id, mArticulos[i].Puesto, mArticulos[i].Marca, mArticulos[i].Modelo, mArticulos[i].Placa, mArticulos[i].Imagen);
            }

            DisplayTotalRegistros();

        }

        private void BusquedaPuestoMarca(string filtroPuesto = "", string filtroMarca = "")
        {
            dataGridViewProductos.Rows.Clear();
            dataGridViewProductos.Refresh();
            mArticulos.Clear();
            mArticulos = mArticulosConsultas.getProductosPuestoMarca(filtroPuesto, filtroMarca);

            for (int i = 0; i < mArticulos.Count; i++)
            {
                dataGridViewProductos.RowTemplate.Height = 175;
                dataGridViewProductos.Rows.Add(mArticulos[i].Id, mArticulos[i].Puesto, mArticulos[i].Marca, mArticulos[i].Modelo, mArticulos[i].Placa, mArticulos[i].Imagen);
            }

            DisplayTotalRegistros();

        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusquedaMarca(CmbMarcaFiltro.Text);
        }

        private void comboBoxPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusquedaPuesto(CmbPuestoFiltro.Text);
        }

        private void AgreUpdateEventHandler(object sender, AgregarArticulo.UpdateEventArgs args)
        {
            cargarProductos();
            cargarMarca();
            cargarPuesto();

            if (dataGridViewProductos.RowCount > 0)
            {
                dataGridViewProductos.FirstDisplayedScrollingRowIndex = dataGridViewProductos.RowCount - 1;
            }

            if (dataGridViewProductos.RowCount == 0)
            {
                dataGridViewProductos.FirstDisplayedScrollingRowIndex = 0;
                DisplayTotalRegistros();
            }
        }

        private void ModUpdateEventHandler(object sender, ModificarArticulos.UpdateEventArgs args)
        {
            cargarProductos();
            cargarMarca();
            cargarPuesto();

            if (dataGridViewProductos.RowCount > 0)
            {
                dataGridViewProductos.FirstDisplayedScrollingRowIndex = dataGridViewProductos.RowCount - 1;
            }

            if (dataGridViewProductos.RowCount == 0)
            {
                dataGridViewProductos.FirstDisplayedScrollingRowIndex = 0;
                DisplayTotalRegistros();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AgregarArticulo agregarArticulo = new AgregarArticulo(this);
            agregarArticulo.UpdateEventHandler += AgreUpdateEventHandler;
            agregarArticulo.ShowDialog();
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                // Modificar Articulo

                Cursor.Current = Cursors.WaitCursor;
                ModificarArticulos enviar = new ModificarArticulos();

                enviar.LblId.Text = dataGridViewProductos.SelectedCells[0].Value.ToString();
                enviar.TxtPuesto.Text = dataGridViewProductos.SelectedCells[1].Value.ToString();
                enviar.TxtMarca.Text = dataGridViewProductos.SelectedCells[2].Value.ToString();
                enviar.TxtModelo.Text = dataGridViewProductos.SelectedCells[3].Value.ToString();
                enviar.TxtPlaca.Text = dataGridViewProductos.SelectedCells[4].Value.ToString();
                enviar.PicImagenPlaca.Image = Image.FromStream(new MemoryStream(dataGridViewProductos.CurrentRow.Cells[5].Value as byte[]));

                enviar.UpdateEventHandler += ModUpdateEventHandler;
                enviar.ShowDialog();
            }

            if (e.ColumnIndex == 7)
            {
                // Eliminar Articulo
                if (MessageBox.Show("Desea eliminar la Placa " + dataGridViewProductos.CurrentRow.Cells[4].Value.ToString() + " del TouchUP?", "Confirmación de proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConexionMySql conexionMySql = new ConexionMySql();
                    conexionMySql.eliminarArticulo(dataGridViewProductos.CurrentRow.Cells[0].Value.ToString());

                    Cursor.Current = Cursors.WaitCursor;
                    cargarProductos();
                    DisplayTotalRegistros();

                    MessageBox.Show("La placa ha sido eliminada correctamente", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < 6)
            {
                selectedrow = dataGridViewProductos.Rows[e.RowIndex];

                // Modificar Articulo
                if (selectedrow != null)
                {

                    Cursor.Current = Cursors.WaitCursor;
                    ModificarArticulos enviar = new ModificarArticulos();

                    enviar.LblId.Text = dataGridViewProductos.SelectedCells[0].Value.ToString();
                    enviar.TxtPuesto.Text = dataGridViewProductos.SelectedCells[1].Value.ToString();
                    enviar.TxtMarca.Text = dataGridViewProductos.SelectedCells[2].Value.ToString();
                    enviar.TxtModelo.Text = dataGridViewProductos.SelectedCells[3].Value.ToString();
                    enviar.TxtPlaca.Text = dataGridViewProductos.SelectedCells[4].Value.ToString();
                    enviar.PicImagenPlaca.Image = Image.FromStream(new MemoryStream(dataGridViewProductos.CurrentRow.Cells[5].Value as byte[]));

                    enviar.UpdateEventHandler += ModUpdateEventHandler;
                    enviar.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna placa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TouchUP.LoginForm inicio = new TouchUP.LoginForm();
            this.Hide();
            inicio.Show();
        }

        private void linkRefreshDataTable_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            BtnBorrar_Click(sender, e);
            cargarProductos();
            cargarMarca();
            cargarPuesto();
        }

        private void PicSearch_Click(object sender, EventArgs e)
        {
            cargarProductos(TxtBuscarPlaca.Text);
        }

        private void TxtBuscarPlaca_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarPlaca.Text == "")
            {
                cargarProductos(TxtBuscarPlaca.Text);
                PicSearch.Enabled = false;
                Cursor.Current = Cursors.Arrow;
            }
            else
            {
                PicSearch.Enabled = true;
                Cursor.Current = Cursors.Hand;
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            CmbMarcaFiltro.Text = "";
            CmbPuestoFiltro.Text = "";
            TxtBuscarPlaca.Text = "";

            cargarProductos();
        }

        private void BtnBorrar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarPlaca.Text != "")
            {
                BtnBorrar.Enabled = true;
                Cursor.Current = Cursors.Arrow;
            }
            else
            {
                BtnBorrar.Enabled = false;
                Cursor.Current = Cursors.Hand;
            }
        }

        private void BtnBorrar_TabIndexChanged(object sender, EventArgs e)
        {
            if (CmbMarcaFiltro.Text != "")
            {
                BtnBorrar.Enabled = true;
                Cursor.Current = Cursors.Arrow;
            }
            else if (CmbPuestoFiltro.Text != "")
            {
                BtnBorrar.Enabled = true;
                Cursor.Current = Cursors.Arrow;
            }
            else
            {
                BtnBorrar.Enabled = false;
                Cursor.Current = Cursors.Hand;
            }
        }


        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usuario = "Admin";
            AdminInicio adminInicio = new AdminInicio(usuario);
            this.Hide();
            adminInicio.Show();
        }

        private void AbmProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmUsuarios abmUsuarios = new AbmUsuarios();
            this.Hide();
            abmUsuarios.Show();
        }

        private void visorOperarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string usuario = "Operario";
            OperarioInicio operarioInicio = new OperarioInicio(usuario);
            this.Hide();
            operarioInicio.Show();
        }

        private void visorSupervisorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Usuario = "Supervisor";
            DisplaySupervisor displaySupervisor = new DisplaySupervisor(Usuario);
            this.Hide();
            displaySupervisor.Show();
        }

        private void LblExportar_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();

            int iC = 1;
            foreach (DataGridViewColumn column in dataGridViewProductos.Columns)
            {
                // Exportar todas las columnas menos la columna Imagen
                if (column.Index != 5)
                {
                    sl.SetCellValue(1, iC, column.HeaderText);
                    iC++;
                }
            }

           

            int iR = 2;
            foreach (DataGridViewRow row in dataGridViewProductos.Rows)
            {
                sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                iR++;
            }

            sl.SaveAs("C:\\Users\\Public\\Documents\\TouchUP - Maestro de artículos al " + DateTime.Now.ToString("dd-MM-yyyy hh-mm") + ".xlsx");
            MessageBox.Show("El archivo se ha exportado correctamente en la carpeta" + "\r\n" + "C:\\Users\\Public\\Documents", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void fullHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisorTouchFHD visorTouchFHD = new VisorTouchFHD();
            visorTouchFHD.ShowDialog();
        }

        private void wXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisorTouchWXGA visorTouchWXGA = new VisorTouchWXGA();
            visorTouchWXGA.ShowDialog();
        }
    }
}
