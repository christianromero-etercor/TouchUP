using System;
using System.Drawing;
using System.Windows.Forms;

namespace TouchUP.Visores.supervisor
{
    partial class LoginSupervisor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox PictureBoxBackground;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSupervisor));
            this.DateA = new System.Windows.Forms.Timer(this.components);
            this.linkLabelPass = new System.Windows.Forms.LinkLabel();
            this.PicEyeOpen = new System.Windows.Forms.PictureBox();
            this.PicEyeHide = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnExitSesion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            PictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(PictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxBackground
            // 
            PictureBoxBackground.BackColor = System.Drawing.SystemColors.Control;
            PictureBoxBackground.Image = global::TouchUP.Properties.Resources.BackTouchLogin;
            PictureBoxBackground.Location = new System.Drawing.Point(-7, -19);
            PictureBoxBackground.Margin = new System.Windows.Forms.Padding(2);
            PictureBoxBackground.Name = "PictureBoxBackground";
            PictureBoxBackground.Size = new System.Drawing.Size(467, 294);
            PictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBoxBackground.TabIndex = 5;
            PictureBoxBackground.TabStop = false;
            // 
            // DateA
            // 
            this.DateA.Enabled = true;
            // 
            // linkLabelPass
            // 
            this.linkLabelPass.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabelPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelPass.AutoSize = true;
            this.linkLabelPass.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.linkLabelPass.Font = new System.Drawing.Font("Segoe UI", 7.7F);
            this.linkLabelPass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.linkLabelPass.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelPass.Location = new System.Drawing.Point(372, 209);
            this.linkLabelPass.Name = "linkLabelPass";
            this.linkLabelPass.Size = new System.Drawing.Size(121, 13);
            this.linkLabelPass.TabIndex = 21;
            this.linkLabelPass.TabStop = true;
            this.linkLabelPass.Text = "Olvidó su contraseña?";
            this.linkLabelPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPass_LinkClicked);
            // 
            // PicEyeOpen
            // 
            this.PicEyeOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicEyeOpen.BackColor = System.Drawing.Color.White;
            this.PicEyeOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEyeOpen.Image = global::TouchUP.Properties.Resources.PicEyeOpen;
            this.PicEyeOpen.Location = new System.Drawing.Point(565, 106);
            this.PicEyeOpen.Margin = new System.Windows.Forms.Padding(2);
            this.PicEyeOpen.Name = "PicEyeOpen";
            this.PicEyeOpen.Size = new System.Drawing.Size(30, 30);
            this.PicEyeOpen.TabIndex = 20;
            this.PicEyeOpen.TabStop = false;
            this.PicEyeOpen.Visible = false;
            this.PicEyeOpen.Click += new System.EventHandler(this.PicPassShow_Click);
            // 
            // PicEyeHide
            // 
            this.PicEyeHide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicEyeHide.BackColor = System.Drawing.Color.White;
            this.PicEyeHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEyeHide.Image = global::TouchUP.Properties.Resources.PicEyeClosed;
            this.PicEyeHide.Location = new System.Drawing.Point(565, 106);
            this.PicEyeHide.Margin = new System.Windows.Forms.Padding(2);
            this.PicEyeHide.Name = "PicEyeHide";
            this.PicEyeHide.Size = new System.Drawing.Size(30, 30);
            this.PicEyeHide.TabIndex = 19;
            this.PicEyeHide.TabStop = false;
            this.PicEyeHide.Click += new System.EventHandler(this.PicPassHide_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(441, 155);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(156, 35);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Location = new System.Drawing.Point(275, 72);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(185, 13);
            this.LabelPassword.TabIndex = 13;
            this.LabelPassword.Text = "Ingrese su contraseña a continuación";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIngresar.Location = new System.Drawing.Point(278, 155);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(156, 35);
            this.BtnIngresar.TabIndex = 16;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtPassword.Location = new System.Drawing.Point(278, 103);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(319, 35);
            this.TxtPassword.TabIndex = 15;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // BtnExitSesion
            // 
            this.BtnExitSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExitSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnExitSesion.Image")));
            this.BtnExitSesion.Location = new System.Drawing.Point(612, 11);
            this.BtnExitSesion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExitSesion.Name = "BtnExitSesion";
            this.BtnExitSesion.Size = new System.Drawing.Size(14, 13);
            this.BtnExitSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnExitSesion.TabIndex = 9;
            this.BtnExitSesion.TabStop = false;
            this.BtnExitSesion.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingreso Supervisor";
            // 
            // LoginSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(639, 261);
            this.Controls.Add(this.PicEyeOpen);
            this.Controls.Add(this.PicEyeHide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.linkLabelPass);
            this.Controls.Add(this.BtnExitSesion);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(PictureBoxBackground);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUp V3.0 - Login";
            ((System.ComponentModel.ISupportInitialize)(PictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox BtnExitSesion;
        private Timer DateA;
        private TextBox TxtPassword;
        private Button BtnCancelar;
        private Label LabelPassword;
        private Button BtnIngresar;
        private PictureBox PicEyeHide;
        private PictureBox PicEyeOpen;
        private LinkLabel linkLabelPass;
        private Label label1;
    }
}

