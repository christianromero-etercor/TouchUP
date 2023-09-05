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
            this.BtnAbrirPlaca = new System.Windows.Forms.Button();
            this.dataGridVistaPrevia = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbPlaca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbModelo = new System.Windows.Forms.ComboBox();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.LblMensajeBienvenida = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVistaPrevia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAbrirPlaca
            // 
            this.BtnAbrirPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrirPlaca.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAbrirPlaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrirPlaca.Enabled = false;
            this.BtnAbrirPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirPlaca.ForeColor = System.Drawing.Color.White;
            this.BtnAbrirPlaca.Location = new System.Drawing.Point(29, 397);
            this.BtnAbrirPlaca.Name = "BtnAbrirPlaca";
            this.BtnAbrirPlaca.Size = new System.Drawing.Size(230, 35);
            this.BtnAbrirPlaca.TabIndex = 53;
            this.BtnAbrirPlaca.Text = "Abrir";
            this.BtnAbrirPlaca.UseVisualStyleBackColor = false;
            // 
            // dataGridVistaPrevia
            // 
            this.dataGridVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVistaPrevia.Location = new System.Drawing.Point(300, 221);
            this.dataGridVistaPrevia.Name = "dataGridVistaPrevia";
            this.dataGridVistaPrevia.RowHeadersWidth = 51;
            this.dataGridVistaPrevia.RowTemplate.Height = 24;
            this.dataGridVistaPrevia.Size = new System.Drawing.Size(430, 230);
            this.dataGridVistaPrevia.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(657, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Vista Previa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(25, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "3) Placa";
            // 
            // CmbPlaca
            // 
            this.CmbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbPlaca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbPlaca.FormattingEnabled = true;
            this.CmbPlaca.Location = new System.Drawing.Point(28, 343);
            this.CmbPlaca.Name = "CmbPlaca";
            this.CmbPlaca.Size = new System.Drawing.Size(230, 28);
            this.CmbPlaca.TabIndex = 49;
            this.CmbPlaca.SelectedIndexChanged += new System.EventHandler(this.CmbPlaca_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(26, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "2) Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(25, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "1) Marca";
            // 
            // CmbModelo
            // 
            this.CmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbModelo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbModelo.FormattingEnabled = true;
            this.CmbModelo.Location = new System.Drawing.Point(29, 285);
            this.CmbModelo.Name = "CmbModelo";
            this.CmbModelo.Size = new System.Drawing.Size(230, 28);
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
            this.CmbMarca.ItemHeight = 20;
            this.CmbMarca.Location = new System.Drawing.Point(28, 227);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(230, 28);
            this.CmbMarca.TabIndex = 45;
            this.CmbMarca.SelectedIndexChanged += new System.EventHandler(this.CmbMarca_SelectedIndexChanged);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblMensaje.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblMensaje.Location = new System.Drawing.Point(222, 166);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(378, 20);
            this.LblMensaje.TabIndex = 44;
            this.LblMensaje.Text = "Buscador de Placa AA según Marca/Modelo";
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
            this.LblMensajeBienvenida.Location = new System.Drawing.Point(25, 39);
            this.LblMensajeBienvenida.Margin = new System.Windows.Forms.Padding(0);
            this.LblMensajeBienvenida.Name = "LblMensajeBienvenida";
            this.LblMensajeBienvenida.Padding = new System.Windows.Forms.Padding(30, 60, 30, 20);
            this.LblMensajeBienvenida.Size = new System.Drawing.Size(143, 99);
            this.LblMensajeBienvenida.TabIndex = 43;
            this.LblMensajeBienvenida.Text = "Puesto AA";
            this.LblMensajeBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(564, 84);
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
            this.pictureBox1.Location = new System.Drawing.Point(564, 41);
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
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(800, 140);
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(782, 31);
            this.toolStrip1.TabIndex = 54;
            this.toolStrip1.Text = "NavInicio";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.LinkColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel1.Text = "Inicio";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // DisplayOperarioAA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnAbrirPlaca);
            this.Controls.Add(this.dataGridVistaPrevia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbModelo);
            this.Controls.Add(this.CmbMarca);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.LblMensajeBienvenida);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DisplayOperarioAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUP 3.0 | Operario - Selector de Placas de AA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVistaPrevia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrirPlaca;
        private System.Windows.Forms.DataGridView dataGridVistaPrevia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbModelo;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Label LblMensajeBienvenida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}