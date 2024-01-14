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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            System.Windows.Forms.PictureBox PictureBoxBackground;
            this.TxtVersion = new System.Windows.Forms.Label();
            this.TxtCopyright = new System.Windows.Forms.Label();
            this.DateA = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButtonWXGA = new System.Windows.Forms.RadioButton();
            this.radioButtonFHD = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.linkLabelPass = new System.Windows.Forms.LinkLabel();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.tabVisorTouch = new System.Windows.Forms.TabControl();
            this.BtnInfoApp = new System.Windows.Forms.PictureBox();
            this.PicEyeOpen = new System.Windows.Forms.PictureBox();
            this.PicEyeHide = new System.Windows.Forms.PictureBox();
            this.BtnExitSesion = new System.Windows.Forms.PictureBox();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            PictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.tabPage2.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabVisorTouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInfoApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(PictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtVersion
            // 
            this.TxtVersion.AutoSize = true;
            this.TxtVersion.BackColor = System.Drawing.Color.SkyBlue;
            this.TxtVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtVersion.ForeColor = System.Drawing.Color.White;
            this.TxtVersion.Location = new System.Drawing.Point(40, 331);
            this.TxtVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtVersion.Name = "TxtVersion";
            this.TxtVersion.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.TxtVersion.Size = new System.Drawing.Size(44, 19);
            this.TxtVersion.TabIndex = 8;
            this.TxtVersion.Text = "vX.X";
            // 
            // TxtCopyright
            // 
            this.TxtCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCopyright.AutoSize = true;
            this.TxtCopyright.BackColor = System.Drawing.Color.Transparent;
            this.TxtCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtCopyright.Font = new System.Drawing.Font("OpenSymbol", 8F);
            this.TxtCopyright.Location = new System.Drawing.Point(368, 332);
            this.TxtCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtCopyright.Name = "TxtCopyright";
            this.TxtCopyright.Size = new System.Drawing.Size(201, 13);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(234, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visor TouchUP";
            // 
            // radioButtonWXGA
            // 
            this.radioButtonWXGA.AutoSize = true;
            this.radioButtonWXGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.radioButtonWXGA.Location = new System.Drawing.Point(11, 99);
            this.radioButtonWXGA.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWXGA.Name = "radioButtonWXGA";
            this.radioButtonWXGA.Size = new System.Drawing.Size(193, 24);
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
            this.radioButtonFHD.Location = new System.Drawing.Point(11, 63);
            this.radioButtonFHD.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFHD.Name = "radioButtonFHD";
            this.radioButtonFHD.Size = new System.Drawing.Size(213, 24);
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
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 15);
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
            this.BtnVisualizar.Location = new System.Drawing.Point(11, 157);
            this.BtnVisualizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(213, 35);
            this.BtnVisualizar.TabIndex = 21;
            this.BtnVisualizar.Text = "Visualizar";
            this.BtnVisualizar.UseVisualStyleBackColor = false;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageLogin.Controls.Add(this.linkLabelPass);
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
            this.tabPageLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageLogin.Size = new System.Drawing.Size(234, 224);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Acceso Usuarios";
            this.tabPageLogin.UseVisualStyleBackColor = true;
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
            this.linkLabelPass.Location = new System.Drawing.Point(51, 207);
            this.linkLabelPass.Name = "linkLabelPass";
            this.linkLabelPass.Size = new System.Drawing.Size(121, 13);
            this.linkLabelPass.TabIndex = 21;
            this.linkLabelPass.TabStop = true;
            this.linkLabelPass.Text = "Olvidó su contraseña?";
            this.linkLabelPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPass_LinkClicked);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LabelUsuario.Location = new System.Drawing.Point(11, 18);
            this.LabelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(50, 15);
            this.LabelUsuario.TabIndex = 12;
            this.LabelUsuario.Text = "Usuario";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(122, 157);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 35);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Location = new System.Drawing.Point(10, 83);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(70, 15);
            this.LabelPassword.TabIndex = 13;
            this.LabelPassword.Text = "Contraseña";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIngresar.Location = new System.Drawing.Point(11, 157);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(100, 35);
            this.BtnIngresar.TabIndex = 16;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtUsuario.Location = new System.Drawing.Point(13, 41);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(212, 29);
            this.TxtUsuario.TabIndex = 14;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtPassword.Location = new System.Drawing.Point(11, 107);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(213, 29);
            this.TxtPassword.TabIndex = 15;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // tabVisorTouch
            // 
            this.tabVisorTouch.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabVisorTouch.Controls.Add(this.tabPageLogin);
            this.tabVisorTouch.Controls.Add(this.tabPage2);
            this.tabVisorTouch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabVisorTouch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.tabVisorTouch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabVisorTouch.Location = new System.Drawing.Point(364, 60);
            this.tabVisorTouch.Margin = new System.Windows.Forms.Padding(8);
            this.tabVisorTouch.Name = "tabVisorTouch";
            this.tabVisorTouch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabVisorTouch.RightToLeftLayout = true;
            this.tabVisorTouch.SelectedIndex = 0;
            this.tabVisorTouch.Size = new System.Drawing.Size(242, 253);
            this.tabVisorTouch.TabIndex = 11;
            // 
            // BtnInfoApp
            // 
            this.BtnInfoApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInfoApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfoApp.Image = global::TouchUP.Properties.Resources.IconQuestion;
            this.BtnInfoApp.Location = new System.Drawing.Point(588, 11);
            this.BtnInfoApp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInfoApp.Name = "BtnInfoApp";
            this.BtnInfoApp.Size = new System.Drawing.Size(14, 13);
            this.BtnInfoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnInfoApp.TabIndex = 12;
            this.BtnInfoApp.TabStop = false;
            this.toolTipInfo.SetToolTip(this.BtnInfoApp, "Información");
            this.BtnInfoApp.Click += new System.EventHandler(this.BtnInfoApp_Click);
            // 
            // PicEyeOpen
            // 
            this.PicEyeOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicEyeOpen.BackColor = System.Drawing.Color.White;
            this.PicEyeOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEyeOpen.Image = global::TouchUP.Properties.Resources.PicEyeOpen;
            this.PicEyeOpen.Location = new System.Drawing.Point(190, 107);
            this.PicEyeOpen.Margin = new System.Windows.Forms.Padding(2);
            this.PicEyeOpen.Name = "PicEyeOpen";
            this.PicEyeOpen.Size = new System.Drawing.Size(27, 24);
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
            this.PicEyeHide.Location = new System.Drawing.Point(190, 107);
            this.PicEyeHide.Margin = new System.Windows.Forms.Padding(2);
            this.PicEyeHide.Name = "PicEyeHide";
            this.PicEyeHide.Size = new System.Drawing.Size(27, 24);
            this.PicEyeHide.TabIndex = 19;
            this.PicEyeHide.TabStop = false;
            this.PicEyeHide.Click += new System.EventHandler(this.PicPassHide_Click);
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
            this.toolTipInfo.SetToolTip(this.BtnExitSesion, "Cerrar");
            this.BtnExitSesion.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PictureBoxBackground
            // 
            PictureBoxBackground.BackColor = System.Drawing.SystemColors.Control;
            PictureBoxBackground.Image = global::TouchUP.Properties.Resources.BackTouchLogin;
            PictureBoxBackground.Location = new System.Drawing.Point(-7, 0);
            PictureBoxBackground.Margin = new System.Windows.Forms.Padding(2);
            PictureBoxBackground.Name = "PictureBoxBackground";
            PictureBoxBackground.Size = new System.Drawing.Size(653, 416);
            PictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBoxBackground.TabIndex = 5;
            PictureBoxBackground.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 379);
            this.Controls.Add(this.BtnInfoApp);
            this.Controls.Add(this.tabVisorTouch);
            this.Controls.Add(this.TxtCopyright);
            this.Controls.Add(this.BtnExitSesion);
            this.Controls.Add(this.TxtVersion);
            this.Controls.Add(PictureBoxBackground);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUp - Login";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabVisorTouch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnInfoApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEyeHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(PictureBoxBackground)).EndInit();
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
        private LinkLabel linkLabelPass;
        private PictureBox BtnInfoApp;
        private ToolTip toolTipInfo;
    }
}

