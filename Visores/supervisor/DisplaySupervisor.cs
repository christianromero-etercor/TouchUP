﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchUP
{
    public partial class DisplaySupervisor : Form
    {
        public DisplaySupervisor(string Usuario)
        {
            InitializeComponent();
            LblMensaje.Text = "Bienvenido " + Usuario;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
