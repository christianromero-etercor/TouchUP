using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using System.Security.AccessControl;

namespace TouchUP.Placas.AA
{
    public partial class PCB_DISPLAY_INVERTER_3200 : Form
    {

        private List<RegistroFallas> mRegistroFallas;
        private RegistroFallasConsultas mRegistroFallasConsultas;

        private string Modelo, Placa;

        public string pModelo
        {
            set { Modelo = value; }
            get { return Modelo; }
        }

        public string pPlaca
        {
            set { Placa = value; }
            get { return Placa; }
        }

        public PCB_DISPLAY_INVERTER_3200(string Modelo, string Placa)
        {
            InitializeComponent();

            LblPlaca.Text = Placa;
            LblModelo.Text = Modelo;

            mRegistroFallas = new List<RegistroFallas>();
            mRegistroFallasConsultas = new RegistroFallasConsultas();

            DoubleBufferedDataGrid(dataGridRegistroFallas, true);
            this.Cursor = Cursors.Default;

            dataGridRegistroFallas.Columns[0].Visible = false;
            dataGridRegistroFallas.Columns[1].Visible = false;
            dataGridRegistroFallas.Columns[2].Visible = false;
            dataGridRegistroFallas.Columns[3].Visible = true;
            dataGridRegistroFallas.Columns[4].Visible = true;

            // Fullscreen Display
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            
            // Botones de selección Eventos
            radioButtonFaltante.CheckedChanged += new EventHandler(backColor_ColorChanged1);
            radioButtonInvertido.CheckedChanged += new EventHandler(backColor_ColorChanged2);
            radioButtonLevantado.CheckedChanged += new EventHandler(backColor_ColorChanged3);
            radioButtonEquivocado.CheckedChanged += new EventHandler(backColor_ColorChanged4);
            radioButtonMalInsertado.CheckedChanged += new EventHandler(backColor_ColorChanged5);

            // Botones de selección False
            radioButtonFaltante.Checked = false;
            radioButtonInvertido.Checked = false;
            radioButtonLevantado.Checked = false;
            radioButtonEquivocado.Checked = false;
            radioButtonMalInsertado.Checked = false;
            radioButtonFaltante.Checked = false;

            GmbImagenPlaca.Text = Modelo + " - " + Placa;
            LblPlacaSidebar.Text = Placa;

            Cursor.Current = Cursors.Arrow;
        }

        public void PCB_DISPLAY_INVERTER_3200_Load(object sender, EventArgs e)
        {
            timerFecha.Start();

            string NombreForm = this.Name;
            this.Text = NombreForm;

            LblPlaca.Text = pPlaca;
            LblModelo.Text = pModelo;

            LblComponente.Text = "";
        }

        public void DoubleBufferedDataGrid(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            System.Reflection.PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        } // Evita el parpadeo del datagridview

        public void llenar_tabla(string fallas = "")
        {
            string Placa = LblPlaca.Text;

            dataGridRegistroFallas.Rows.Clear();
            mRegistroFallas.Clear();
            mRegistroFallas = mRegistroFallasConsultas.getRegistrosFallasPorPlaca(fallas, Placa);

            for (int i = 0; i < mRegistroFallas.Count; i++)
            {
                dataGridRegistroFallas.Rows.Add(mRegistroFallas[i].FechaHora, mRegistroFallas[i].Modelo, mRegistroFallas[i].Placa, mRegistroFallas[i].Componente, mRegistroFallas[i].Falla);
            }

            if (dataGridRegistroFallas.RowCount > 0)
            {
                dataGridRegistroFallas.FirstDisplayedScrollingRowIndex = dataGridRegistroFallas.RowCount - 1;
            }

            GmbRegistro.Text = "Registro de fallas (" + dataGridRegistroFallas.RowCount + ")";
        }

        public void limpiar_campos()
        {
            // Txt Componente
            LblComponente.Text = "";

            // Botones de selección
            radioButtonMalInsertado.Checked = false;
            radioButtonFaltante.Checked = false;
            radioButtonInvertido.Checked = false;
            radioButtonLevantado.Checked = false;
            radioButtonEquivocado.Checked = false;
        }

        private void backColor_ColorChanged1(object sender, EventArgs e)
        {
            if (radioButtonFaltante.Checked == true)
            {
                // radioButton1
                this.radioButtonFaltante.BackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonFaltante.ForeColor = System.Drawing.Color.White;
                this.radioButtonFaltante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonFaltante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;

            }
            else
            {
                this.radioButtonFaltante.BackColor = System.Drawing.Color.Transparent;
                this.radioButtonFaltante.ForeColor = System.Drawing.Color.DimGray;
                this.radioButtonFaltante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.radioButtonFaltante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            }
        }

        private void backColor_ColorChanged2(object sender, EventArgs e)
        {
            if (radioButtonInvertido.Checked == true)
            {
                // radioButton2
                this.radioButtonInvertido.BackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonInvertido.ForeColor = System.Drawing.Color.White;
                this.radioButtonInvertido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonInvertido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            }
            else
            {
                this.radioButtonInvertido.BackColor = System.Drawing.Color.Transparent;
                this.radioButtonInvertido.ForeColor = System.Drawing.Color.DimGray;
                this.radioButtonInvertido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.radioButtonInvertido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            }
        }

        private void backColor_ColorChanged3(object sender, EventArgs e)
        {
            if (radioButtonLevantado.Checked == true)
            {
                // radioButton3
                this.radioButtonLevantado.BackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonLevantado.ForeColor = System.Drawing.Color.White;
                this.radioButtonLevantado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonLevantado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            }
            else
            {
                this.radioButtonLevantado.BackColor = System.Drawing.Color.Transparent;
                this.radioButtonLevantado.ForeColor = System.Drawing.Color.DimGray;
                this.radioButtonLevantado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.radioButtonLevantado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            }
        }

        private void backColor_ColorChanged4(object sender, EventArgs e)
        {
            if (radioButtonEquivocado.Checked == true)
            {
                // radioButton4
                this.radioButtonEquivocado.BackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonEquivocado.ForeColor = System.Drawing.Color.White;
                this.radioButtonEquivocado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonEquivocado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            }
            else
            {
                this.radioButtonEquivocado.BackColor = System.Drawing.Color.Transparent;
                this.radioButtonEquivocado.ForeColor = System.Drawing.Color.DimGray;
                this.radioButtonEquivocado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.radioButtonEquivocado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            }
        }

        private void backColor_ColorChanged5(object sender, EventArgs e)
        {
            if (radioButtonMalInsertado.Checked == true)
            {
                // radioButton5
                this.radioButtonMalInsertado.BackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonMalInsertado.ForeColor = System.Drawing.Color.White;
                this.radioButtonMalInsertado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                this.radioButtonMalInsertado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            }
            else
            {
                this.radioButtonMalInsertado.BackColor = System.Drawing.Color.Transparent;
                this.radioButtonMalInsertado.ForeColor = System.Drawing.Color.DarkGray;
                this.radioButtonMalInsertado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.radioButtonMalInsertado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            }
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string Usuario = "Operario";

            TouchUP.OperarioInicio displayOperarioAA = new OperarioInicio(Usuario);
            displayOperarioAA.Show();
            this.Hide();
        }

        private void radioButtonFaltante_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFaltante.Checked == true)
            {
                if (MessageBox.Show("¿Está seguro que desea registrar el componente " + LblComponente.Text + " bajo la falla: " + radioButtonFaltante.Text + "?", "Registro de falla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RegistroFallasConsultas registroFallasConsultas = new RegistroFallasConsultas();
                    RegistroFallas mRegistroFallas = new RegistroFallas();

                    mRegistroFallas.Modelo = LblModelo.Text;
                    mRegistroFallas.Placa = LblPlaca.Text;
                    mRegistroFallas.Componente = LblComponente.Text;
                    mRegistroFallas.Falla = radioButtonFaltante.Text;

                    mRegistroFallasConsultas.agregarRegistroFalla(mRegistroFallas);

                    llenar_tabla();
                    limpiar_campos();

                    MessageBox.Show("El Registro de falla fue cargado correctamente", "Registro de falla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return;
                }
                else
                {
                    radioButtonFaltante.Checked = false;
                }
            }
        }

        private void radioButtonInvertido_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonInvertido.Checked == true)
            {
                if (MessageBox.Show("¿Está seguro que desea registrar el componente " + LblComponente.Text + " bajo la falla: " + radioButtonInvertido.Text + "?", "Registro de falla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                RegistroFallasConsultas registroFallasConsultas = new RegistroFallasConsultas();
                RegistroFallas mRegistroFallas = new RegistroFallas();

                mRegistroFallas.Modelo = LblModelo.Text;
                mRegistroFallas.Placa = LblPlaca.Text;
                mRegistroFallas.Componente = LblComponente.Text;
                mRegistroFallas.Falla = radioButtonInvertido.Text;

                mRegistroFallasConsultas.agregarRegistroFalla(mRegistroFallas);
                llenar_tabla();
                limpiar_campos();

                MessageBox.Show("El Registro de falla fue cargado correctamente", "Registro de falla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                {
                radioButtonInvertido.Checked = false;
            }
            }

        }

        private void radioButtonLevantado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLevantado.Checked == true)
            {
                if (MessageBox.Show("¿Está seguro que desea registrar el componente " + LblComponente.Text + " bajo la falla: " + radioButtonLevantado.Text + "?", "Registro de falla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RegistroFallasConsultas registroFallasConsultas = new RegistroFallasConsultas();
                    RegistroFallas mRegistroFallas = new RegistroFallas();

                    mRegistroFallas.Modelo = LblModelo.Text;
                    mRegistroFallas.Placa = LblPlaca.Text;
                    mRegistroFallas.Componente = LblComponente.Text;
                    mRegistroFallas.Falla = radioButtonLevantado.Text;

                    mRegistroFallasConsultas.agregarRegistroFalla(mRegistroFallas);
                    llenar_tabla();
                    limpiar_campos();

                    MessageBox.Show("El Registro de falla fue cargado correctamente", "Registro de falla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    radioButtonLevantado.Checked = false;
                }
            }
        }

        private void radioButtonEquivocado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEquivocado.Checked == true)
            {
                if (MessageBox.Show("¿Está seguro que desea registrar el componente " + LblComponente.Text + " bajo la falla: " + radioButtonEquivocado.Text + "?", "Registro de falla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RegistroFallasConsultas registroFallasConsultas = new RegistroFallasConsultas();
                    RegistroFallas mRegistroFallas = new RegistroFallas();

                    mRegistroFallas.Modelo = LblModelo.Text;
                    mRegistroFallas.Placa = LblPlaca.Text;
                    mRegistroFallas.Componente = LblComponente.Text;
                    mRegistroFallas.Falla = radioButtonEquivocado.Text;

                    mRegistroFallasConsultas.agregarRegistroFalla(mRegistroFallas);
                    llenar_tabla();
                    limpiar_campos();

                    MessageBox.Show("El Registro de falla fue cargado correctamente", "Registro de falla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    radioButtonEquivocado.Checked = false;
                }
            }
        }

        private void radioButtonMalInsertado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMalInsertado.Checked == true)
            {
                if (MessageBox.Show("¿Está seguro que desea registrar el componente " + LblComponente.Text + " bajo la falla: " + radioButtonMalInsertado.Text + "?", "Registro de falla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RegistroFallasConsultas registroFallasConsultas = new RegistroFallasConsultas();
                    RegistroFallas mRegistroFallas = new RegistroFallas();

                    mRegistroFallas.Modelo = LblModelo.Text;
                    mRegistroFallas.Placa = LblPlaca.Text;
                    mRegistroFallas.Componente = LblComponente.Text;
                    mRegistroFallas.Falla = radioButtonMalInsertado.Text;

                    mRegistroFallasConsultas.agregarRegistroFalla(mRegistroFallas);
                    llenar_tabla();
                    limpiar_campos();

                    MessageBox.Show("El Registro de falla fue cargado correctamente", "Registro de falla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    radioButtonMalInsertado.Checked = false;
                }
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox Picture = (PictureBox)sender;
                
            if(Picture.Name != "picImagenPlaca")
            {
                LblComponente.Text = toolTipComponentes.GetToolTip(Picture);
            }
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox Picture = (PictureBox)sender;
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.Parent = picImagenPlaca;
        }

        private void Pic_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void LblInicio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string Usuario = "Operario";
            OperarioInicio displayOperarioInicio = new OperarioInicio(Usuario);
            displayOperarioInicio.Show();
            this.Hide();
        }

        private void LblSalir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Application.Exit();
        }

        private void LblMinimizar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.WindowState = FormWindowState.Minimized;
        }

        private void LblSalir_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void LblInicio_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void picImagenPlaca_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void LblPlacaSidebar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.RotateTransform(-90);
            g.DrawString(LblPlacaSidebar.Text, new System.Drawing.Font("Microsoft Sans Serif", 32, FontStyle.Bold), Brushes.White, new PointF(-LblPlacaSidebar.Height, 0));
        }

        private void timerUpdateBD_Tick(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void picImagenPlaca_Click(object sender, EventArgs e)
        {
            LblComponente.Text = "";
        }

        private void radioButton_MouseHover(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            radioButton.ForeColor = System.Drawing.Color.White;
            radioButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            radioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;

        }

        private void radioButton_MouseLeave(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            radioButton.ForeColor = System.Drawing.Color.DimGray;
            radioButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            radioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
        }

        private void toolStripNav_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void toolStripNav_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }


        private void LblComponente_TextChanged(object sender, EventArgs e)
        {
            if(LblComponente.Text == "")
            {
                radioButtonFaltante.Enabled = false;
                radioButtonFaltante.ForeColor = System.Drawing.Color.Silver;
                radioButtonFaltante.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                radioButtonFaltante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
                radioButtonFaltante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;

                radioButtonInvertido.Enabled = false;
                radioButtonInvertido.ForeColor = System.Drawing.Color.Silver;
                radioButtonInvertido.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                radioButtonInvertido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
                radioButtonInvertido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;

                radioButtonLevantado.Enabled = false;
                radioButtonLevantado.ForeColor = System.Drawing.Color.Silver;
                radioButtonLevantado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                radioButtonLevantado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
                radioButtonLevantado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;

                radioButtonEquivocado.Enabled = false;
                radioButtonEquivocado.ForeColor = System.Drawing.Color.Silver;
                radioButtonEquivocado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                radioButtonEquivocado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
                radioButtonEquivocado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;

                radioButtonMalInsertado.Enabled = false;
                radioButtonMalInsertado.ForeColor = System.Drawing.Color.Silver;
                radioButtonMalInsertado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                radioButtonMalInsertado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
                radioButtonMalInsertado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;

                GmbComponente.BackColor = System.Drawing.Color.Transparent;
                GmbComponente.ForeColor = System.Drawing.Color.DimGray;
            }
            else
            {
                radioButtonFaltante.Enabled = true;
                radioButtonFaltante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonFaltante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonFaltante.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
                radioButtonFaltante.ForeColor = System.Drawing.Color.DimGray;

                radioButtonInvertido.Enabled = true;
                radioButtonInvertido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonInvertido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonInvertido.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
                radioButtonInvertido.ForeColor = System.Drawing.Color.DimGray;


                radioButtonLevantado.Enabled = true;
                radioButtonLevantado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonLevantado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonLevantado.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
                radioButtonLevantado.ForeColor = System.Drawing.Color.DimGray;

                radioButtonEquivocado.Enabled = true;
                radioButtonEquivocado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonEquivocado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonEquivocado.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
                radioButtonEquivocado.ForeColor = System.Drawing.Color.DimGray;

                radioButtonMalInsertado.Enabled = true;
                radioButtonMalInsertado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonMalInsertado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
                radioButtonMalInsertado.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
                radioButtonMalInsertado.ForeColor = System.Drawing.Color.DimGray;

                GmbComponente.BackColor = System.Drawing.Color.RoyalBlue;
                GmbComponente.ForeColor = System.Drawing.Color.White;
            }
        }

    }
}
