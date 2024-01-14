using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchUP.Visores.admin;
using System.IO;


namespace TouchUP.Visores.admin
{
    public partial class AgregarArticulo : Form
    {
        private List<Articulo> mArticulos;
        private Articulo mProducto;
        private ArticuloConsultas mProductoConsultas;
        public AgregarArticulo(AbmArticulos abmArticulos)

        {
            InitializeComponent();
            mArticulos = new List<Articulo>();
            mProductoConsultas = new ArticuloConsultas();
            mProducto = new Articulo();
        }

        public delegate void updateDelegate(object sender, UpdateEventArgs args);
        public event updateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()

        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            PicImagenPlaca.AllowDrop = true;
            PicImagenPlacaRef.AllowDrop = true;
        }

        private void BtnAbrirPlaca_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicImagenPlaca.Image = new Bitmap(openFileDialog.FileName);
                PicImagenPlaca.Visible = true;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PicImagenPlaca_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    PicImagenPlaca.Image = new Bitmap(fileNames[0]);
                    PicImagenPlaca.Visible = true;
                }
            }

        }

        private void PicImagenPlaca_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosProducto();

            if (mProductoConsultas.insertarProducto(mProducto))
            {
                
                if(DialogResult.Yes == MessageBox.Show("Desea agregar la placa " + TxtPlaca.Text + " a la base de datos?", "Confirmación de proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    LimpiarCampos();
                    this.Hide();
                    Agregar();

                    MessageBox.Show("La placa ha sido agregada correctamente", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Error al agregar la Placa, reintente nuevamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            CmbPuesto.SelectedValue = null;
            CmbMarca.SelectedValue = null;
            TxtModelo.Text = "";
            TxtPlaca.Text = "";
            PicImagenPlaca.Image = null;
        }

        private void cargarDatosProducto()
        {
            mProducto.Puesto = CmbPuesto.Text;
            mProducto.Marca = CmbMarca.Text;
            mProducto.Modelo = TxtModelo.Text;
            mProducto.Placa = TxtPlaca.Text;
            mProducto.Imagen = ImageToByteArray(PicImagenPlaca.Image);


        }

        private byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null)
            {
                return null;
            }

            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private bool datosCorrectos()
        {
            if (CmbPuesto == null || CmbMarca == null || TxtModelo.Text == "" || TxtPlaca.Text == "" || PicImagenPlaca.Image == null)
            {
                MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (CmbPuesto == null)
            {
                MessageBox.Show("Debe ingresar un Puesto de trabajo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (CmbMarca == null)
            {
                MessageBox.Show("Debe ingresar una Marca asociada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (TxtModelo.Text == "")
            {
                MessageBox.Show("Debe ingresar una Modelo asociado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (TxtPlaca.Text == "")
            {
                MessageBox.Show("Debe ingresar una Placa para el Modelo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (PicImagenPlaca.Image == null)
            {
                MessageBox.Show("Debe seleccionar una imagen de la placa para el TouchUP", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void CmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CmbPuesto.SelectedItem.ToString() == "AA")
            {
                CmbMarca.Items.Clear();
                CmbMarca.Items.Add("Genérico");
                CmbMarca.Items.Add("DAEWOO ELECTRONICS");
                CmbMarca.Items.Add("HYUNDAI ELECTRONICS");
                CmbMarca.Items.Add("LG");
                CmbMarca.Items.Add("NEX");
                CmbMarca.Items.Add("PEABODY");
            }
            else if (this.CmbPuesto.SelectedItem.ToString() == "TV")
            {
                CmbMarca.Items.Clear();
                CmbMarca.Items.Add("Genérico");
                CmbMarca.Items.Add("DAEWOO ELECTRONICS");
                CmbMarca.Items.Add("HYUNDAI ELECTRONICS");
                CmbMarca.Items.Add("RECCO");
            }
            else
            {
                CmbMarca.Items.Clear();
                CmbPuesto.SelectedIndex = -1;
            }

        }
    }
}

// Compare this snippet from Visores/admin/ModificarArticulos.cs:


