using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;

namespace TouchUP.Visores.operario
{

    public partial class DisplayOperarioTV : Form
    {


        private ConexionMySql mConexion;

        public DisplayOperarioTV()
        {

            InitializeComponent();
            mConexion = new ConexionMySql();
            cargarMarca();

            if (Application.ProductVersion.Length > 3)
            {
                this.Text = "TouchUP" + " v" + Application.ProductVersion.Substring(0, 3) + " - Selector de placas para puesto de TV (Operario)";
            }

        }

        public void DisplayOperarioTV_Load(object sender, EventArgs e)
        {
            //Abrir Placa Butonn
            BtnAbrirPlaca.Enabled = false;
            BtnAbrirPlaca.ForeColor = System.Drawing.Color.Silver;
            BtnAbrirPlaca.ForeColor = ColorTranslator.FromHtml("#cacaca");
            BtnAbrirPlaca.FlatStyle = FlatStyle.Flat;
            BtnAbrirPlaca.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#cacaca");

            //Selectores
            CmbModelo.Enabled = false;
            CmbModelo.FlatStyle = FlatStyle.Flat;

            CmbPlaca.Enabled = false;
            CmbPlaca.FlatStyle = FlatStyle.Flat;
        }

        private void cargarMarca()
        {
            CmbMarca.Items.Clear();
            CmbMarca.DataSource = null;


            string consulta = "SELECT DISTINCT Marca FROM Maestro_Articulos WHERE Puesto = 'TV'";

            MySqlDataReader reader = null;
            if (mConexion.getConnection() != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta);
                    cmd.Connection = mConexion.getConnection();
                    reader = cmd.ExecuteReader();

                    CmbMarca.Items.Add("Seleccione una marca");

                    while (reader.Read())
                    {
                        CmbMarca.Items.Add(reader["Marca"].ToString());
                    }

                    CmbMarca.SelectedIndex = 0;

                    mConexion.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las marcas" + ex.Message);
                }
            }
        }

        private void cargaModelo(string Marca)
        {
            CmbModelo.Items.Clear();
            CmbModelo.DataSource = null;

            string consulta = "SELECT DISTINCT Modelo FROM Maestro_Articulos WHERE Marca = '" + Marca + "' AND Puesto = 'TV'";

            MySqlDataReader reader = null;
            if (mConexion.getConnection() != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta);
                    cmd.Connection = mConexion.getConnection();
                    reader = cmd.ExecuteReader();

                    CmbModelo.Items.Add("Seleccione un modelo");

                    while (reader.Read())
                    {
                        CmbModelo.Items.Add(reader["Modelo"].ToString());
                    }

                    CmbModelo.SelectedIndex = 0;

                    mConexion.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los modelos" + ex.Message);
                }
            }
        }

        private void cargaPlaca(string Marca, string Modelo)
        {
            CmbPlaca.Items.Clear();
            CmbPlaca.DataSource = null;

            string consulta = "SELECT DISTINCT Placa FROM Maestro_Articulos WHERE Marca = '" + Marca + "' AND Modelo = '" + Modelo + "' AND Puesto = 'TV'";

            MySqlDataReader reader = null;
            if (mConexion.getConnection() != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta);
                    cmd.Connection = mConexion.getConnection();
                    reader = cmd.ExecuteReader();

                    CmbPlaca.Items.Add("Seleccione una placa");

                    while (reader.Read())
                    {
                        CmbPlaca.Items.Add(reader["Placa"].ToString());
                    }

                    CmbPlaca.SelectedIndex = 0;

                    mConexion.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las placas" + ex.Message);
                }
            }
        }

        private void cargarImagen(string Marca, string Modelo, string Placa)
        {
            string consulta = "SELECT Imagen FROM Maestro_Articulos WHERE Marca = '" + Marca + "' AND Modelo = '" + Modelo + "' AND Placa = '" + Placa + "' AND Puesto = 'TV'";

            MySqlDataReader reader = null;
            if (mConexion.getConnection() != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta);
                    cmd.Connection = mConexion.getConnection();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        byte[] img = (byte[])reader["Imagen"];
                        MemoryStream ms = new MemoryStream(img);
                        picVistaPrevia.Image = Image.FromStream(ms);
                    }

                    mConexion.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen seleccionada" + ex.Message);
                }
            }
        }


        private void CmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMarca.SelectedIndex == 0)
            {
                CmbModelo.Enabled = false;
                CmbPlaca.Enabled = false;
                picVistaPrevia.Image = null;
            }
            else
            {
                CmbModelo.Enabled = true;
                CmbPlaca.Enabled = true;
                cargaModelo(CmbMarca.SelectedItem.ToString());
            }

        }

        private void CmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbModelo.SelectedIndex == 0)
            {
                CmbPlaca.Enabled = false;
                picVistaPrevia.Image = null;
            }
            else
            {
                CmbPlaca.Enabled = true;
                cargaPlaca(CmbMarca.SelectedItem.ToString(), CmbModelo.SelectedItem.ToString());
            }

        }

        private void CmbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMarca.SelectedIndex == 0 || CmbModelo.SelectedIndex == 0 || CmbPlaca.SelectedIndex == 0)
            {
                //Abrir Placa Butonn
                BtnAbrirPlaca.Enabled = false;
                BtnAbrirPlaca.BackColor = Color.Transparent;
                BtnAbrirPlaca.ForeColor = ColorTranslator.FromHtml("#cacaca");
                BtnAbrirPlaca.FlatStyle = FlatStyle.Flat;
                BtnAbrirPlaca.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#cacaca");
                //Limpiar Placa Button
                LblLimpiar.Visible = false;

                //Limpiar Vista Previa
                picVistaPrevia.Image = null;

            }
            else
            {
                //Cursor de espera
                Cursor.Current = Cursors.WaitCursor;

                //Abrir Placa Button
                BtnAbrirPlaca.Enabled = true;
                BtnAbrirPlaca.Image = global::TouchUP.Properties.Resources.BtnEyeWhite;
                BtnAbrirPlaca.BackColor = ColorTranslator.FromHtml("#4169E1");
                BtnAbrirPlaca.ForeColor = Color.White;
                BtnAbrirPlaca.FlatStyle = FlatStyle.Flat;
                BtnAbrirPlaca.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#4169E1");
                //Limpiar Placa Button
                LblLimpiar.Visible = true;

                //Carga Imagen de placa seleccionada
                cargarImagen(CmbMarca.SelectedItem.ToString(), CmbModelo.SelectedItem.ToString(), CmbPlaca.SelectedItem.ToString());
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            string Usuario = "Operario";
            OperarioInicio operarioInicio = new OperarioInicio(Usuario);
            operarioInicio.Show();
            this.Hide();
        }

        private void TxtLimpiar_Click(object sender, EventArgs e)
        {
            CmbMarca.SelectedIndex = 0;
            CmbModelo.SelectedIndex = 0;
            CmbPlaca.SelectedIndex = 0;
            picVistaPrevia.Image = null;
        }

        private void BtnAbrirPlaca_Click(object sender, EventArgs e)
        {
            switch (CmbPlaca.SelectedText = CmbPlaca.SelectedItem.ToString())
            {
                case "PCB INVERTER 3200":
                    {
                        string Modelo = CmbModelo.SelectedItem.ToString();
                        string Placa = CmbPlaca.SelectedItem.ToString();

                        Cursor.Current = Cursors.WaitCursor;

                        this.Hide();

                        TouchUP.Placas.AA.PCB_INVERTER_3200 pcbinverter3200 = new Placas.AA.PCB_INVERTER_3200(Modelo, Placa);
                        pcbinverter3200.ShowDialog();
                        break;
                    }
                case "":
                    {
                        string Modelo = CmbModelo.SelectedItem.ToString();
                        string Placa = CmbPlaca.SelectedItem.ToString();

                        Cursor.Current = Cursors.WaitCursor;

                        this.Hide();

                        TouchUP.Placas.AA.PCB_INVERTER_3200 display3400_5000 = new Placas.AA.PCB_INVERTER_3200(Modelo, Placa);
                        display3400_5000.ShowDialog();
                        break;
                    }
                // Mostrar MensageBox si no se puede acceder al Form
                default:
                    {
                        MessageBox.Show("No se puede acceder a la placa seleccionada", "Error de redireccionamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }

        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string Usuario = "Operario";
            OperarioInicio operarioInicio = new OperarioInicio(Usuario);
            operarioInicio.Show();
            this.Hide();
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

    }
}

