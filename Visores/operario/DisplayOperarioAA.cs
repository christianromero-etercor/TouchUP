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

namespace TouchUP.Visores.operario
{
    public partial class DisplayOperarioAA : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Model;Integrated Security=True");

        public DisplayOperarioAA()
        {
            InitializeComponent();
            carga_marca();
        }

        public void DisplayOperarioAA_Load(object sender, EventArgs e)
        {

        }

        public void carga_marca()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Marca from Puesto_AA", cn);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            cn.Close();

            DataRow fila = dt.NewRow();
            fila["Marca"] = "Seleccione una marca";
            dt.Rows.InsertAt(fila, 0);

            CmbMarca.ValueMember = "Marca";
            CmbMarca.DisplayMember = "Marca";
            CmbMarca.DataSource = dt;

        }

        public void carga_modelo(string Marca)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Modelo from Puesto_AA WHERE Marca = @Marca", cn);
            cmd.Parameters.AddWithValue("Marca", Marca);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            cn.Close();

            DataRow fila = dt.NewRow();
            fila["Modelo"] = "Seleccione un modelo";
            dt.Rows.InsertAt(fila, 0);

            CmbModelo.ValueMember = "Modelo";
            CmbModelo.DisplayMember = "Modelo";
            CmbModelo.DataSource = dt;
        }

        public void carga_placa(string Marca, string Modelo)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Placa from Puesto_AA WHERE Marca = @Marca AND Modelo = @Modelo", cn);
            cmd.Parameters.AddWithValue("Marca", Marca);
            cmd.Parameters.AddWithValue("Modelo", Modelo);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            cn.Close();

            DataRow fila = dt.NewRow();
            fila["Placa"] = "Seleccione una placa";
            dt.Rows.InsertAt(fila, 0);

            CmbPlaca.ValueMember = "Placa";
            CmbPlaca.DisplayMember = "Placa";
            CmbPlaca.DataSource = dt;

        }

        private void CmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMarca.SelectedValue.ToString() != null)
            {
                String Marca = CmbMarca.SelectedValue.ToString();
                carga_modelo(Marca);
            }
        }

        private void CmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbModelo.SelectedValue.ToString() != null)
            {
                String Marca = CmbMarca.SelectedValue.ToString();
                String Modelo = CmbModelo.SelectedValue.ToString();
                carga_placa(Marca, Modelo);
            }
        }

        private void CmbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMarca.SelectedIndex == 0 || CmbModelo.SelectedIndex == 0 || CmbPlaca.SelectedIndex == 0)
            {
                BtnAbrirPlaca.Enabled = false;
                BtnAbrirPlaca.BackColor = Color.Transparent;
                BtnAbrirPlaca.ForeColor = ColorTranslator.FromHtml("#cacaca");
                BtnAbrirPlaca.FlatStyle = FlatStyle.Flat;
                BtnAbrirPlaca.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#cacaca");
            }
            else
            {
                BtnAbrirPlaca.Enabled = true;
                BtnAbrirPlaca.BackColor = ColorTranslator.FromHtml("#4169E1");
                BtnAbrirPlaca.ForeColor = Color.White;
                BtnAbrirPlaca.FlatStyle = FlatStyle.Flat;
                BtnAbrirPlaca.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#4169E1");
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {


            this.Hide();



        }

        private void LblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbrirPlaca_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            LoginForm displayOperarioInicio = new LoginForm();
            displayOperarioInicio.Show();
            this.Close();
        }

    }
}