namespace TouchUP.Visores.operario
{
    partial class DisplayOperarioAA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayOperarioAA));
            this.LblPlaca = new System.Windows.Forms.Label();
            this.CmbPlaca = new System.Windows.Forms.ComboBox();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.CmbModelo = new System.Windows.Forms.ComboBox();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.picVistaPrevia = new System.Windows.Forms.PictureBox();
            this.BtnAbrirPlaca = new System.Windows.Forms.Button();
            this.LblMensajeBienvenida = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LblLimpiar = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.BtnInicio = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picVistaPrevia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblPlaca.Location = new System.Drawing.Point(31, 325);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(46, 13);
            this.LblPlaca.TabIndex = 50;
            this.LblPlaca.Text = "3) Placa";
            // 
            // CmbPlaca
            // 
            this.CmbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbPlaca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbPlaca.FormattingEnabled = true;
            this.CmbPlaca.Location = new System.Drawing.Point(34, 344);
            this.CmbPlaca.Name = "CmbPlaca";
            this.CmbPlaca.Size = new System.Drawing.Size(251, 24);
            this.CmbPlaca.TabIndex = 49;
            this.CmbPlaca.SelectedIndexChanged += new System.EventHandler(this.CmbPlaca_SelectedIndexChanged);
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblModelo.Location = new System.Drawing.Point(32, 267);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(54, 13);
            this.LblModelo.TabIndex = 48;
            this.LblModelo.Text = "2) Modelo";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblMarca.Location = new System.Drawing.Point(31, 209);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(49, 13);
            this.LblMarca.TabIndex = 47;
            this.LblMarca.Text = "1) Marca";
            // 
            // CmbModelo
            // 
            this.CmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbModelo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbModelo.FormattingEnabled = true;
            this.CmbModelo.Location = new System.Drawing.Point(35, 286);
            this.CmbModelo.Name = "CmbModelo";
            this.CmbModelo.Size = new System.Drawing.Size(251, 24);
            this.CmbModelo.TabIndex = 46;
            this.CmbModelo.SelectedIndexChanged += new System.EventHandler(this.CmbModelo_SelectedIndexChanged);
            // 
            // CmbMarca
            // 
            this.CmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbMarca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.ItemHeight = 16;
            this.CmbMarca.Location = new System.Drawing.Point(34, 228);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(251, 24);
            this.CmbMarca.TabIndex = 45;
            this.CmbMarca.SelectedIndexChanged += new System.EventHandler(this.CmbMarca_SelectedIndexChanged);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblMensaje.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblMensaje.Location = new System.Drawing.Point(230, 150);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(324, 17);
            this.LblMensaje.TabIndex = 44;
            this.LblMensaje.Text = "Buscador de Placa AA según Marca/Modelo";
            // 
            // picVistaPrevia
            // 
            this.picVistaPrevia.BackgroundImage = global::TouchUP.Properties.Resources.BackVistaPrevia;
            this.picVistaPrevia.Location = new System.Drawing.Point(323, 209);
            this.picVistaPrevia.Name = "picVistaPrevia";
            this.picVistaPrevia.Size = new System.Drawing.Size(429, 224);
            this.picVistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVistaPrevia.TabIndex = 55;
            this.picVistaPrevia.TabStop = false;
            // 
            // BtnAbrirPlaca
            // 
            this.BtnAbrirPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrirPlaca.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbrirPlaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrirPlaca.Enabled = false;
            this.BtnAbrirPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirPlaca.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnAbrirPlaca.Image = global::TouchUP.Properties.Resources.PicEyeClosed;
            this.BtnAbrirPlaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrirPlaca.Location = new System.Drawing.Point(34, 388);
            this.BtnAbrirPlaca.Name = "BtnAbrirPlaca";
            this.BtnAbrirPlaca.Padding = new System.Windows.Forms.Padding(60, 0, 40, 0);
            this.BtnAbrirPlaca.Size = new System.Drawing.Size(251, 35);
            this.BtnAbrirPlaca.TabIndex = 53;
            this.BtnAbrirPlaca.Text = "Iniciar TouchUP";
            this.BtnAbrirPlaca.UseVisualStyleBackColor = false;
            this.BtnAbrirPlaca.Click += new System.EventHandler(this.BtnAbrirPlaca_Click);
            // 
            // LblMensajeBienvenida
            // 
            this.LblMensajeBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMensajeBienvenida.AutoSize = true;
            this.LblMensajeBienvenida.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblMensajeBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblMensajeBienvenida.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.LblMensajeBienvenida.ForeColor = System.Drawing.Color.White;
            this.LblMensajeBienvenida.Image = global::TouchUP.Properties.Resources.AAIconW2;
            this.LblMensajeBienvenida.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblMensajeBienvenida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblMensajeBienvenida.Location = new System.Drawing.Point(9, 9);
            this.LblMensajeBienvenida.Margin = new System.Windows.Forms.Padding(0);
            this.LblMensajeBienvenida.Name = "LblMensajeBienvenida";
            this.LblMensajeBienvenida.Padding = new System.Windows.Forms.Padding(30, 60, 30, 20);
            this.LblMensajeBienvenida.Size = new System.Drawing.Size(123, 96);
            this.LblMensajeBienvenida.TabIndex = 43;
            this.LblMensajeBienvenida.Text = "Puesto AA";
            this.LblMensajeBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(604, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(604, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(782, 100);
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // LblLimpiar
            // 
            this.LblLimpiar.AutoSize = true;
            this.LblLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.7F, System.Drawing.FontStyle.Underline);
            this.LblLimpiar.ForeColor = System.Drawing.Color.DimGray;
            this.LblLimpiar.Location = new System.Drawing.Point(32, 431);
            this.LblLimpiar.Name = "LblLimpiar";
            this.LblLimpiar.Size = new System.Drawing.Size(83, 13);
            this.LblLimpiar.TabIndex = 57;
            this.LblLimpiar.Text = "Borrar selección";
            this.LblLimpiar.Visible = false;
            this.LblLimpiar.Click += new System.EventHandler(this.TxtLimpiar_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.toolStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnInicio});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 100);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 5, 11, 40);
            this.toolStripMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenu.Size = new System.Drawing.Size(782, 68);
            this.toolStripMenu.Stretch = true;
            this.toolStripMenu.TabIndex = 83;
            this.toolStripMenu.Text = "toolStripNav";
            // 
            // BtnInicio
            // 
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnInicio.Image = global::TouchUP.Properties.Resources.IconVer;
            this.BtnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnInicio.Size = new System.Drawing.Size(56, 20);
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            this.BtnInicio.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.BtnInicio.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // DisplayOperarioAA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.LblLimpiar);
            this.Controls.Add(this.picVistaPrevia);
            this.Controls.Add(this.BtnAbrirPlaca);
            this.Controls.Add(this.LblPlaca);
            this.Controls.Add(this.CmbPlaca);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.CmbModelo);
            this.Controls.Add(this.CmbMarca);
            this.Controls.Add(this.LblMensajeBienvenida);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayOperarioAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUP 3.0 | Operario - Selector de Placas AA";
            ((System.ComponentModel.ISupportInitialize)(this.picVistaPrevia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrirPlaca;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.ComboBox CmbPlaca;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.ComboBox CmbModelo;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Label LblMensajeBienvenida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picVistaPrevia;
        private System.Windows.Forms.Label LblLimpiar;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripLabel BtnInicio;
    }
}