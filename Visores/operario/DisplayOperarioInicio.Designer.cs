﻿namespace TouchUP
{
    partial class DisplayOperarioInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayOperarioInicio));
            this.LblMensaje = new System.Windows.Forms.Label();
            this.LblMensajePie = new System.Windows.Forms.Label();
            this.LblMensajeBienvenida = new System.Windows.Forms.Label();
            this.BtnTV = new System.Windows.Forms.Button();
            this.BtnAA = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMensaje
            // 
            this.LblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblMensaje.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblMensaje.Location = new System.Drawing.Point(213, 9);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(393, 20);
            this.LblMensaje.TabIndex = 0;
            this.LblMensaje.Text = "Por favor, seleccione una linea de producción";
            // 
            // LblMensajePie
            // 
            this.LblMensajePie.AutoSize = true;
            this.LblMensajePie.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblMensajePie.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.LblMensajePie.ForeColor = System.Drawing.Color.White;
            this.LblMensajePie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblMensajePie.Location = new System.Drawing.Point(26, 71);
            this.LblMensajePie.Name = "LblMensajePie";
            this.LblMensajePie.Size = new System.Drawing.Size(57, 19);
            this.LblMensajePie.TabIndex = 8;
            this.LblMensajePie.Text = "Sección";
            // 
            // LblMensajeBienvenida
            // 
            this.LblMensajeBienvenida.AutoSize = true;
            this.LblMensajeBienvenida.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblMensajeBienvenida.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblMensajeBienvenida.ForeColor = System.Drawing.Color.White;
            this.LblMensajeBienvenida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblMensajeBienvenida.Location = new System.Drawing.Point(22, 33);
            this.LblMensajeBienvenida.Name = "LblMensajeBienvenida";
            this.LblMensajeBienvenida.Size = new System.Drawing.Size(113, 45);
            this.LblMensajeBienvenida.TabIndex = 7;
            this.LblMensajeBienvenida.Text = "Inicio";
            // 
            // BtnTV
            // 
            this.BtnTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTV.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnTV.Image = global::TouchUP.Properties.Resources.TVIcon2;
            this.BtnTV.Location = new System.Drawing.Point(399, 231);
            this.BtnTV.Name = "BtnTV";
            this.BtnTV.Padding = new System.Windows.Forms.Padding(20);
            this.BtnTV.Size = new System.Drawing.Size(180, 180);
            this.BtnTV.TabIndex = 10;
            this.BtnTV.Text = "Puesto TV";
            this.BtnTV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTV.UseVisualStyleBackColor = true;
            this.BtnTV.Click += new System.EventHandler(this.BtnTV_Click);
            // 
            // BtnAA
            // 
            this.BtnAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAA.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnAA.Image = global::TouchUP.Properties.Resources.AAIcon2;
            this.BtnAA.Location = new System.Drawing.Point(192, 231);
            this.BtnAA.Name = "BtnAA";
            this.BtnAA.Padding = new System.Windows.Forms.Padding(20);
            this.BtnAA.Size = new System.Drawing.Size(180, 180);
            this.BtnAA.TabIndex = 9;
            this.BtnAA.Text = "Puesto AA";
            this.BtnAA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAA.UseVisualStyleBackColor = true;
            this.BtnAA.Click += new System.EventHandler(this.BtnAA_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(586, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(586, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(-4, -3);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(809, 140);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LblMensaje);
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 11;
            // 
            // DisplayOperarioInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnTV);
            this.Controls.Add(this.BtnAA);
            this.Controls.Add(this.LblMensajePie);
            this.Controls.Add(this.LblMensajeBienvenida);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DisplayOperarioInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOLNIK | TouchUP 3.0 - Operario";
            this.Load += new System.EventHandler(this.DisplayOperario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LblMensajePie;
        private System.Windows.Forms.Label LblMensajeBienvenida;
        private System.Windows.Forms.Button BtnAA;
        private System.Windows.Forms.Button BtnTV;
        private System.Windows.Forms.Panel panel1;
    }
}