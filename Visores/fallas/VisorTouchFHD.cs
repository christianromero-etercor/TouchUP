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

namespace TouchUP.Visores
{
    public partial class VisorTouchFHD : Form
    {

        private List<RegistroFallas> mRegistroFallas;
        private RegistroFallasConsultas mRegistroFallasConsultas;

        public VisorTouchFHD()
        {
            InitializeComponent();

            mRegistroFallas = new List<RegistroFallas>();
            mRegistroFallasConsultas = new RegistroFallasConsultas();

            DoubleBufferedDataGrid(dataGridAA, true);
            DoubleBufferedDataGrid(dataGridTV, true);
            
            this.Cursor = Cursors.Default;

            OpenOnSecondaryScreen(this);

            MostrarPanelInicial();

        }

        public static void OpenOnSecondaryScreen(Form form)
        {
            if (Screen.AllScreens.Length > 1)
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = Screen.AllScreens[1].WorkingArea.Location;
                form.Show();
            }
        }

        public void DoubleBufferedDataGrid(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            System.Reflection.PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        } // Evita el parpadeo del datagridview


        public void llenar_tablaAA(string fallas = "")
        {
            dataGridAA.Rows.Clear();
            mRegistroFallas.Clear();
            mRegistroFallas = mRegistroFallasConsultas.queryVisorAA(fallas);

            for (int i = 0; i < mRegistroFallas.Count; i++)
            {
                dataGridAA.Rows.Add(mRegistroFallas[i].FechaHora, mRegistroFallas[i].Modelo, mRegistroFallas[i].Placa, mRegistroFallas[i].Componente, mRegistroFallas[i].Falla, mRegistroFallas[i].Cantidad);
            }


            foreach (DataGridViewRow row in this.dataGridAA.Rows)
            {

                if (Convert.ToInt32(row.Cells[dataGridAA.Columns[5].Index].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.DodgerBlue;
                    row.Selected = false;
                }

                if (Convert.ToInt32(row.Cells[dataGridAA.Columns[5].Index].Value) == 2)
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f5c542");
                    row.Selected = false;

                }

                if (Convert.ToInt32(row.Cells[dataGridAA.Columns[5].Index].Value) >= 3)
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e80927");
                    row.Selected = false;

                    // Mostrar panel AA
                    this.panelAA.Visible = true;
                    this.toolStripNav2.Visible = true;
                    this.FechaHoy.Visible = true;
                    BtnDataAA.BackColor = System.Drawing.Color.Silver;
                    BtnDataAA.Image = global::TouchUP.Properties.Resources.AAIconVShowRed;
                    BtnDataAA.ForeColor = System.Drawing.Color.Red;
                    PicAlarmAA.Visible = true;

                    // Ajuste de panel AA
                    if (panelTV.Visible == false)
                    {
                        this.panelAA.Width = 1920;
                        this.panelAA.Location = new Point(0, 200);
                    }
                    else
                    {
                        this.panelAA.Width = 960;
                        this.panelAA.Location = new Point(0, 200);
                    }

                }
            }
        }

        public void llenar_tablaTV(string fallas = "")
        {
            dataGridTV.Rows.Clear();
            mRegistroFallas.Clear();
            mRegistroFallas = mRegistroFallasConsultas.queryVisorTV(fallas);

            for (int i = 0; i < mRegistroFallas.Count; i++)
            {
                dataGridTV.Rows.Add(mRegistroFallas[i].FechaHora, mRegistroFallas[i].Modelo, mRegistroFallas[i].Placa, mRegistroFallas[i].Componente, mRegistroFallas[i].Falla, mRegistroFallas[i].Cantidad);
            }

            foreach (DataGridViewRow row in this.dataGridTV.Rows)
            {

                if (Convert.ToInt32(row.Cells[dataGridTV.Columns[5].Index].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.MediumTurquoise;
                    row.Selected = false;
                }

                if (Convert.ToInt32(row.Cells[dataGridTV.Columns[5].Index].Value) == 2)
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f5c542");
                    row.Selected = false;

                }

                if (Convert.ToInt32(row.Cells[dataGridTV.Columns[5].Index].Value) >= 3)
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e80927");
                    row.Selected = false;

                    // Mostrar panel TV
                    this.panelTV.Visible = true;
                    this.toolStripNav2.Visible = true;
                    this.FechaHoy.Visible = true;
                    BtnDataTV.BackColor = System.Drawing.Color.Silver;
                    BtnDataTV.Image = global::TouchUP.Properties.Resources.TVIconVShowRed;
                    BtnDataTV.ForeColor = System.Drawing.Color.Red;
                    PicAlarmTV.Visible = true;

                    // Ajuste de panel TV
                    if (panelAA.Visible == false)
                    {
                        this.panelTV.Width = 1920;
                        this.panelTV.Location = new Point(0, 200);
                    }
                    else
                    {
                        this.panelTV.Width = 960;
                        this.panelTV.Location = new Point(960, 200);
                    }

                }
            }
        }

        // Verificar si la alarma se encuentra sonando

        public bool SonarAlarma()
        {
            bool sonando = false;

            if (PicAlarmAA.Visible == true || PicAlarmTV.Visible == true)
            {
                sonando = true;
            }

            return sonando;
        }

        private void MostrarPanelInicial()
        {
            if(panelAA.Visible == true && panelTV.Visible == true)
            {
                panelInicial.Visible = false;
            }
            else
            {
                panelInicial.Visible = true;
            }
        }

        private void BtnDataAA_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (this.panelAA.Visible == false)
            {
                this.panelAA.Visible = true;
                this.toolStripNav2.Visible = true;
                this.FechaHoy.Visible = true;
                BtnDataAA.BackColor = System.Drawing.Color.Silver;
                BtnDataAA.Image = global::TouchUP.Properties.Resources.AAIconVShow;
                BtnDataAA.ForeColor = System.Drawing.Color.RoyalBlue;
                this.panelAA.Width = 1920;
                this.panelAA.Location = new Point(0, 200);
            }
            else if (this.panelAA.Visible == true)
            {
                this.panelAA.Visible = false;
                this.toolStripNav2.Visible = false;
                this.FechaHoy.Visible = false;
                BtnDataAA.BackColor = System.Drawing.Color.Silver;
                BtnDataAA.Image = global::TouchUP.Properties.Resources.AAIconVHide;
                BtnDataAA.ForeColor = ColorTranslator.FromHtml("#b2b2b2");
            }

            if (this.panelAA.Visible == false || this.panelTV.Visible == true)
            {
                this.toolStripNav2.Visible = true;
                this.FechaHoy.Visible = true;
                this.panelTV.Width = 1920;
                this.panelTV.Location = new Point(0, 200);
            }

            if (this.panelAA.Visible == false && this.panelTV.Visible == false)
            {
                this.toolStripNav2.Visible = false;
                this.FechaHoy.Visible = false;
            }

            if (this.panelAA.Visible == true && this.panelTV.Visible == true)
            {
                this.toolStripNav2.Visible = true;
                this.panelAA.Width = 960;
                this.panelAA.Location = new Point(0, 200);
                this.panelTV.Width = 960;
                this.panelTV.Location = new Point(960, 200);
            }

        }

        private void BtnDataTV_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (this.panelTV.Visible == false)
            {
                this.panelTV.Visible = true;
                this.toolStripNav2.Visible = true;
                this.FechaHoy.Visible = true;
                BtnDataTV.BackColor = System.Drawing.Color.Silver;
                BtnDataTV.Image = global::TouchUP.Properties.Resources.TVIconVShow;
                BtnDataTV.ForeColor = System.Drawing.Color.RoyalBlue;
                this.panelTV.Width = 1920;
                this.panelTV.Location = new Point(0, 200);
            }
            else if (this.panelTV.Visible == true)
            {
                this.panelTV.Visible = false;
                this.toolStripNav2.Visible = false;
                this.FechaHoy.Visible = false;
                BtnDataTV.BackColor = System.Drawing.Color.Silver;
                BtnDataTV.Image = global::TouchUP.Properties.Resources.TVIconVHide;
                BtnDataTV.ForeColor = ColorTranslator.FromHtml("#b2b2b2");
            }

            if (this.panelTV.Visible == false || this.panelAA.Visible == true)
            {
                this.toolStripNav2.Visible = true;
                this.FechaHoy.Visible = true;
                this.panelAA.Width = 1920;
                this.panelAA.Location = new Point(0, 200);
            }

            if (this.panelTV.Visible == false && this.panelAA.Visible == false)
            {
                this.toolStripNav2.Visible = false;
                this.FechaHoy.Visible = false;
            }

            if (this.panelTV.Visible == true && this.panelAA.Visible == true)
            {
                this.toolStripNav2.Visible = true;
                this.panelTV.Width = 960;
                this.panelTV.Location = new Point(960, 200);
                this.panelAA.Width = 960;
                this.panelAA.Location = new Point(0, 200);
            }

        }

        private void timerVisor_Tick(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToString("HH:mm");
            FechaHoy.Text = DateTime.Now.ToString("dd/MM/yy");
            FechaInicio.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            HoraInicio.Text = DateTime.Now.ToString("HH:mm:ss");
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


        private void dataGridAA_Scroll(object sender, ScrollEventArgs e)
        {
            this.dataGridAA.Enabled = true;
            this.dataGridAA.FirstDisplayedScrollingRowIndex = dataGridAA.RowCount - 1;
        }

        private void dataGridTV_Scroll(object sender, ScrollEventArgs e)
        {
            this.dataGridTV.Enabled = true;
            this.dataGridAA.FirstDisplayedScrollingRowIndex = dataGridAA.RowCount - 1;
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {

            llenar_tablaAA();
            llenar_tablaTV();

            if (PicAlarmAA.Visible == true)
            {
                if (panelAA.BackColor == ColorTranslator.FromHtml("#e80927"))
                {
                    panelAA.BackColor = System.Drawing.Color.RoyalBlue;
                    LblLineaAA.BackColor = SystemColors.MenuHighlight;
                    PicAlarmAA.Visible = false;
                    BtnDataAA.Image = global::TouchUP.Properties.Resources.AAIconVShow;
                    BtnDataAA.ForeColor = System.Drawing.Color.RoyalBlue;
                    SoundPlayer audio = new SoundPlayer(global::TouchUP.Properties.Resources.AlarmSound);
                    audio.Stop();
                }
                else
                {
                    panelAA.BackColor = ColorTranslator.FromHtml("#e80927");
                    LblLineaAA.BackColor = ColorTranslator.FromHtml("#e80927");
                    PicAlarmAA.Visible = true;
                    BtnDataAA.Image = global::TouchUP.Properties.Resources.AAIconVShowRed;
                    BtnDataAA.ForeColor = System.Drawing.Color.Red;
                    SoundPlayer audio = new SoundPlayer(global::TouchUP.Properties.Resources.AlarmSound);
                    audio.Play();
                }
            }

            if (PicAlarmTV.Visible == true)
            {
                if (panelTV.BackColor == ColorTranslator.FromHtml("#e80927"))
                {
                    panelTV.BackColor = System.Drawing.Color.LightSeaGreen;
                    LblLineaTV.BackColor = System.Drawing.Color.MediumTurquoise;
                    PicAlarmTV.Visible = false;
                    BtnDataTV.Image = global::TouchUP.Properties.Resources.TVIconVShow;
                    BtnDataTV.ForeColor = System.Drawing.Color.RoyalBlue;
                    SoundPlayer audio = new SoundPlayer(global::TouchUP.Properties.Resources.AlarmSound);
                    audio.Stop();
                }
                else
                {
                    panelTV.BackColor = ColorTranslator.FromHtml("#e80927");
                    LblLineaTV.BackColor = ColorTranslator.FromHtml("#e80927");
                    PicAlarmTV.Visible = true;
                    BtnDataTV.Image = global::TouchUP.Properties.Resources.TVIconVShowRed;
                    BtnDataTV.ForeColor = System.Drawing.Color.Red;
                    SoundPlayer audio = new SoundPlayer(global::TouchUP.Properties.Resources.AlarmSound);
                    audio.Play();
                }
            }

        }


        private void BtnDataAA_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDataAA_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnDataTV_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDataTV_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnInicio_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnInicio_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            MostrarPanelInicial();
        }

        private void BtnSalir_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void VisorTouchFHD_Deactivate(object sender, EventArgs e)
        {
            //this.timerUpdateBD.Interval = 60000;//
            
            if (timerUpdateBD.Enabled == true)
            {
                SoundPlayer audio = new SoundPlayer(global::TouchUP.Properties.Resources.AlarmSound);
                audio.Stop();
            }

        }

        private void VisorTouchFHD_Activated(object sender, EventArgs e)
        {
            //this.timerUpdateBD.Interval = 1200;

        }
    }

}
