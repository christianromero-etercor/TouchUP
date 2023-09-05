using System;
using System.Drawing;
using System.Windows.Forms;

namespace TouchUP
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TxtVersion = new System.Windows.Forms.Label();
            this.TxtCopyright = new System.Windows.Forms.Label();
            this.DateA = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButtonWXGA = new System.Windows.Forms.RadioButton();
            this.radioButtonFHD = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.tabVisorTouch = new System.Windows.Forms.TabControl();
            this.BtnExitSesion = new System.Windows.Forms.PictureBox();
            this.PicEyeHide = new System.Windows.Forms.PictureBox();
            this.PicEyeOpen = new System.Windows.Forms.PictureBox();
            PictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(PictureBoxBackground)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabVisorTouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxBackground
            // 
            PictureBoxBackground.BackColor = System.Drawing.SystemColors.Control;
            PictureBoxBackground.Image = global::TouchUP.Properties.Resources.BackTouchLogin;
            PictureBoxBackground.Location = new System.Drawing.Point(-9, 0);
            PictureBoxBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            PictureBoxBackground.Name = "PictureBoxBackground";
            PictureBoxBackground.Size = new System.Drawing.Size(871, 512);
            PictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBoxBackground.TabIndex = 5;
            PictureBoxBackground.TabStop = false;
            PictureBoxBackground.Click += new System.EventHandler(this.PictureBoxBackground_Click);
            // 
            // TxtVersion
            // 
            this.TxtVersion.AutoSize = true;
            this.TxtVersion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtVersion.ForeColor = System.Drawing.Color.White;
            this.TxtVersion.Location = new System.Drawing.Point(54, 407);
            this.TxtVersion.Name = "TxtVersion";
            this.TxtVersion.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            this.TxtVersion.Size = new System.Drawing.Size(49, 24);
            this.TxtVersion.TabIndex = 8;
            this.TxtVersion.Text = "v3.0";
            this.TxtVersion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TxtCopyright
            // 
            this.TxtCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCopyright.AutoSize = true;
            this.TxtCopyright.BackColor = System.Drawing.Color.Transparent;
            this.TxtCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtCopyright.Font = new System.Drawing.Font("OpenSymbol", 8F);
            this.TxtCopyright.Location = new System.Drawing.Point(490, 408);
            this.TxtCopyright.Name = "TxtCopyright";
            this.TxtCopyright.Size = new System.Drawing.Size(256, 17);
            this.TxtCopyright.TabIndex = 10;
            this.TxtCopyright.Text = "SOLNIK SA - Proyectos y Tecnología";
            this.TxtCopyright.Click += new System.EventHandler(this.TxtCopyright_Click);
            // 
            // DateA
            // 
            this.DateA.Enabled = true;
            this.DateA.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.radioButtonWXGA);
            this.tabPage2.Controls.Add(this.radioButtonFHD);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BtnVisualizar);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(314, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visor TouchUP";
            // 
            // radioButtonWXGA
            // 
            this.radioButtonWXGA.AutoSize = true;
            this.radioButtonWXGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.radioButtonWXGA.Location = new System.Drawing.Point(15, 122);
            this.radioButtonWXGA.Name = "radioButtonWXGA";
            this.radioButtonWXGA.Size = new System.Drawing.Size(241, 29);
            this.radioButtonWXGA.TabIndex = 23;
            this.radioButtonWXGA.TabStop = true;
            this.radioButtonWXGA.Text = "1366 x 768 (WXGA)";
            this.radioButtonWXGA.UseVisualStyleBackColor = true;
            this.radioButtonWXGA.CheckedChanged += new System.EventHandler(this.radioButtonWXGA_CheckedChanged);
            // 
            // radioButtonFHD
            // 
            this.radioButtonFHD.AutoSize = true;
            this.radioButtonFHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.radioButtonFHD.Location = new System.Drawing.Point(15, 77);
            this.radioButtonFHD.Name = "radioButtonFHD";
            this.radioButtonFHD.Size = new System.Drawing.Size(264, 29);
            this.radioButtonFHD.TabIndex = 22;
            this.radioButtonFHD.TabStop = true;
            this.radioButtonFHD.Text = "1920 x 1080 (Full HD)";
            this.radioButtonFHD.UseVisualStyleBackColor = true;
            this.radioButtonFHD.CheckedChanged += new System.EventHandler(this.radioButtonFHD_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingreso por resolución de pantalla:";
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVisualizar.Enabled = false;
            this.BtnVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.BtnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizar.ForeColor = System.Drawing.Color.Gray;
            this.BtnVisualizar.Location = new System.Drawing.Point(15, 206);
            this.BtnVisualizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(284, 38);
            this.BtnVisualizar.TabIndex = 21;
            this.BtnVisualizar.Text = "Visualizar";
            this.BtnVisualizar.UseVisualStyleBackColor = false;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageLogin.Controls.Add(this.PicEyeOpen);
            this.tabPageLogin.Controls.Add(this.LabelUsuario);
            this.tabPageLogin.Controls.Add(this.PicEyeHide);
            this.tabPageLogin.Controls.Add(this.BtnCancelar);
            this.tabPageLogin.Controls.Add(this.LabelPassword);
            this.tabPageLogin.Controls.Add(this.BtnIngresar);
            this.tabPageLogin.Controls.Add(this.TxtUsuario);
            this.tabPageLogin.Controls.Add(this.TxtPassword);
            this.tabPageLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageLogin.Location = new System.Drawing.Point(4, 28);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageLogin.Size = new System.Drawing.Size(314, 279);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Acceso Usuarios";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LabelUsuario.Location = new System.Drawing.Point(15, 22);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(60, 18);
            this.LabelUsuario.TabIndex = 12;
            this.LabelUsuario.Text = "Usuario";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Location = new System.Drawing.Point(162, 206);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 38);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Location = new System.Drawing.Point(14, 102);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(85, 18);
            this.LabelPassword.TabIndex = 13;
            this.LabelPassword.Text = "Contraseña";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIngresar.Location = new System.Drawing.Point(15, 206);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(134, 38);
            this.BtnIngresar.TabIndex = 16;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("OpenSymbol", 14F);
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtUsuario.Location = new System.Drawing.Point(17, 50);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(282, 36);
            this.TxtUsuario.TabIndex = 14;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("OpenSymbol", 14F);
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtPassword.Location = new System.Drawing.Point(15, 132);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(284, 36);
            this.TxtPassword.TabIndex = 15;
            // 
            // tabVisorTouch
            // 
            this.tabVisorTouch.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabVisorTouch.Controls.Add(this.tabPageLogin);
            this.tabVisorTouch.Controls.Add(this.tabPage2);
            this.tabVisorTouch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabVisorTouch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.tabVisorTouch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabVisorTouch.Location = new System.Drawing.Point(485, 74);
            this.tabVisorTouch.Margin = new System.Windows.Forms.Padding(10);
            this.tabVisorTouch.Name = "tabVisorTouch";
            this.tabVisorTouch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabVisorTouch.RightToLeftLayout = true;
            this.tabVisorTouch.SelectedIndex = 0;
            this.tabVisorTouch.Size = new System.Drawing.Size(322, 311);
            this.tabVisorTouch.TabIndex = 11;
            // 
            // BtnExitSesion
            // 
            this.BtnExitSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExitSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnExitSesion.Image")));
            this.BtnExitSesion.Location = new System.Drawing.Point(816, 14);
            this.BtnExitSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExitSesion.Name = "BtnExitSesion";
            this.BtnExitSesion.Size = new System.Drawing.Size(18, 16);
            this.BtnExitSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnExitSesion.TabIndex = 9;
            this.BtnExitSesion.TabStop = false;
            this.BtnExitSesion.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PicEyeHide
            // 
            this.PicEyeHide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicEyeHide.BackColor = System.Drawing.Color.White;
            this.PicEyeHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEyeHide.Image = global::TouchUP.Properties.Resources.PicEyeClosed;
            this.PicEyeHide.Location = new System.Drawing.Point(253, 132);
            this.PicEyeHide.Name = "PicEyeHide";
            this.PicEyeHide.Size = new System.Drawing.Size(36, 30);
            this.PicEyeHide.TabIndex = 19;
            this.PicEyeHide.TabStop = false;
            this.PicEyeHide.Click += new System.EventHandler(this.PicPassHide_Click);
            // 
            // PicEyeOpen
            // 
            this.PicEyeOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicEyeOpen.BackColor = System.Drawing.Color.White;
            this.PicEyeOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEyeOpen.Image = global::TouchUP.Properties.Resources.PicEyeOpen;
            this.PicEyeOpen.Location = new System.Drawing.Point(253, 132);
            this.PicEyeOpen.Name = "PicEyeOpen";
            this.PicEyeOpen.Size = new System.Drawing.Size(36, 30);
            this.PicEyeOpen.TabIndex = 20;
            this.PicEyeOpen.TabStop = false;
            this.PicEyeOpen.Click += new System.EventHandler(this.PicPassShow_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 467);
            this.Controls.Add(this.tabVisorTouch);
            this.Controls.Add(this.TxtCopyright);
            this.Controls.Add(this.BtnExitSesion);
            this.Controls.Add(this.TxtVersion);
            this.Controls.Add(PictureBoxBackground);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUp V3.0 - Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(PictureBoxBackground)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabVisorTouch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TxtVersion;
        private PictureBox BtnExitSesion;
        private Label TxtCopyright;
        private Timer DateA;
        private TabPage tabPage2;
        private TabPage tabPageLogin;
        private TextBox TxtPassword;
        private Label LabelUsuario;
        private Button BtnCancelar;
        private Label LabelPassword;
        private Button BtnIngresar;
        private TextBox TxtUsuario;
        private TabControl tabVisorTouch;
        private Label label2;
        private Button BtnVisualizar;
        private RadioButton radioButtonWXGA;
        private RadioButton radioButtonFHD;
        private PictureBox PicEyeHide;
        private PictureBox PicEyeOpen;
    }
}

