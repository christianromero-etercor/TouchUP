using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchUP.Visores.admin;
using System.IO;
using static TouchUP.Visores.admin.AgregarArticulo;
using static TouchUP.Visores.admin.AbmArticulos;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Threading;


namespace TouchUP.Visores.admin
{

    public partial class ModificarArticulos : Form
    {
        private int id;
        private string puesto, marca, modelo, placa, imagenplaca;

        public int pid
        {
            set { id = value; }
            get { return id; }
        }
        public string ppuesto
        {
            set { puesto = value; }
            get { return puesto; }
        }

        public string pmarca
        {
            set { marca = value; }
            get { return marca; }
        }

        public string pmodelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

        public string pplaca
        {
            set { placa = value; }
            get { TxtPlaca.Text = placa; return placa; }
        }

        public string pimagenplaca
        {
            set { imagenplaca = value; }
            get { return imagenplaca; }
        }

        ConexionMySql conexionMySql = new ConexionMySql();
        ArticuloConsultas mArticulosConsultas = new ArticuloConsultas();
        Articulo mArticulo = new Articulo();

        public ModificarArticulos()
        {
            InitializeComponent();
            ArticuloConsultas puesto = new ArticuloConsultas();
            mArticulosConsultas = new ArticuloConsultas();
            mArticulo = new Articulo();
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

        private void ModificarArticulos_Load(object sender, EventArgs e)
        {
            LblId.Text = pid.ToString();
            TxtPuesto.Text = ppuesto;
            TxtMarca.Text = pmarca;
            TxtModelo.Text = pmodelo;
            TxtPlaca.Text = pplaca;
            PicImagenPlaca.Image = new Bitmap(pimagenplaca);

            LblHeadline.Text = new string(pplaca.Where(char.IsLetter).ToArray());
            LblMensaje.Text = new string(pmarca.Where(char.IsLetter).ToArray()) + " / " + new string(pmodelo.Where(char.IsLetter).ToArray());
        }

        private bool datosCorrectos()
        {
            if (TxtPuesto.Text == "")
            {
                MessageBox.Show("Debe ingresar un Puesto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtMarca.Text == "")
            {
                MessageBox.Show("Debe ingresar una Marca", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtModelo.Text == "")
            {
                MessageBox.Show("Debe ingresar una Modelo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtPlaca.Text == "")
            {
                MessageBox.Show("Debe ingresar una Placa para el Modelo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PicImagenPlaca.Image == null)
            {
                MessageBox.Show("Debe seleccionar una imagen de placa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {

            TxtPuesto.Text = "";
            TxtMarca.Text = "";
            TxtModelo.Text = "";
            TxtPlaca.Text = "";
            PicImagenPlaca.Image = null;
        }

        private void modificarProducto()
        {
            mArticulo.Id = Convert.ToInt32(LblId.Text);
            mArticulo.Puesto = TxtPuesto.Text;
            mArticulo.Marca = TxtMarca.Text;
            mArticulo.Modelo = TxtModelo.Text;
            mArticulo.Placa = TxtPlaca.Text;
            mArticulo.Imagen = ImageToByteArray(PicImagenPlaca.Image);

            mArticulosConsultas.modificarProducto(mArticulo);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            else if (MessageBox.Show("¿Está seguro que desea modificar la placa " + TxtPlaca.Text + "?", "Confirmación de proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                modificarProducto();
                LimpiarCampos();
                this.Hide();
                Agregar();

                MessageBox.Show("Los datos han sido modificados correctamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private byte[] ImageToByteArray(Image Imagen)
        {
            if (Imagen == null)
            {
                return null;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                Imagen.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicImagenPlaca.Image = new Bitmap(openFileDialog.FileName);
            }
        }

    }
}
