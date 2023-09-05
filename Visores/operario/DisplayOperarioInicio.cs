using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchUP.Visores.operario;

namespace TouchUP
{
    public partial class DisplayOperarioInicio : Form
    {
        public DisplayOperarioInicio(string Usuario)
        {
            InitializeComponent();
            LblMensajePie.Text = "Modulo - Selección de puesto " + Usuario;
        }

        public DisplayOperarioInicio()
        {
        }

        private void DisplayOperario_Load(object sender, EventArgs e)
        {

        }

        private void BtnAA_Click(object sender, EventArgs e)
        {
            TouchUP.Visores.operario.DisplayOperarioAA DisplayOperarioAA = new TouchUP.Visores.operario.DisplayOperarioAA();
            this.Hide();
            DisplayOperarioAA.Show();
            
        }

        private void BtnTV_Click(object sender, EventArgs e)
        {
            TouchUP.Visores.operario.DisplayOperarioTV DisplayOperarioTV = new TouchUP.Visores.operario.DisplayOperarioTV();
            this.Hide();
            DisplayOperarioTV.Show();

        }
    }
}