namespace TouchUP.Visores.admin
{
    partial class AdminInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInicio));
            this.LblMensaje = new System.Windows.Forms.Label();
            this.LblHeadline = new System.Windows.Forms.Label();
            this.BtnSupervisor = new System.Windows.Forms.Button();
            this.BtnOperario = new System.Windows.Forms.Button();
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.PicLogoSolnik = new System.Windows.Forms.PictureBox();
            this.PicLogoTouchUP = new System.Windows.Forms.PictureBox();
            this.PicHeaderContainer = new System.Windows.Forms.PictureBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbmProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.visorOperarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visorSupervisorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnVisorFallas = new System.Windows.Forms.ToolStripDropDownButton();
            this.fullHDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtCopyright = new System.Windows.Forms.Label();
            this.timerCopyright = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoSolnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoTouchUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHeaderContainer)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.LblMensaje.ForeColor = System.Drawing.Color.White;
            this.LblMensaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblMensaje.Location = new System.Drawing.Point(14, 75);
            this.LblMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(202, 16);
            this.LblMensaje.TabIndex = 74;
            this.LblMensaje.Text = "Seleccione un módulos del programa";
            // 
            // LblHeadline
            // 
            this.LblHeadline.AutoSize = true;
            this.LblHeadline.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblHeadline.Font = new System.Drawing.Font("Microsoft YaHei UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeadline.ForeColor = System.Drawing.Color.White;
            this.LblHeadline.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblHeadline.Location = new System.Drawing.Point(12, 45);
            this.LblHeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHeadline.Name = "LblHeadline";
            this.LblHeadline.Size = new System.Drawing.Size(78, 31);
            this.LblHeadline.TabIndex = 73;
            this.LblHeadline.Text = "Inicio";
            // 
            // BtnSupervisor
            // 
            this.BtnSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSupervisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSupervisor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSupervisor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnSupervisor.Image = global::TouchUP.Properties.Resources.IconSupervisor;
            this.BtnSupervisor.Location = new System.Drawing.Point(319, 325);
            this.BtnSupervisor.Name = "BtnSupervisor";
            this.BtnSupervisor.Padding = new System.Windows.Forms.Padding(20, 10, 20, 35);
            this.BtnSupervisor.Size = new System.Drawing.Size(230, 180);
            this.BtnSupervisor.TabIndex = 80;
            this.BtnSupervisor.Text = "Visor Supervisor";
            this.BtnSupervisor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSupervisor.UseVisualStyleBackColor = true;
            this.BtnSupervisor.Click += new System.EventHandler(this.BtnSupervisor_Click);
            // 
            // BtnOperario
            // 
            this.BtnOperario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOperario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOperario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnOperario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnOperario.Image = global::TouchUP.Properties.Resources.IconOperario;
            this.BtnOperario.Location = new System.Drawing.Point(85, 325);
            this.BtnOperario.Name = "BtnOperario";
            this.BtnOperario.Padding = new System.Windows.Forms.Padding(20, 10, 20, 35);
            this.BtnOperario.Size = new System.Drawing.Size(230, 180);
            this.BtnOperario.TabIndex = 79;
            this.BtnOperario.Text = "Visor Operario";
            this.BtnOperario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOperario.UseVisualStyleBackColor = true;
            this.BtnOperario.Click += new System.EventHandler(this.BtnOperario_Click);
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArticulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnArticulos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnArticulos.Image = global::TouchUP.Properties.Resources.IconAbmArticulos;
            this.BtnArticulos.Location = new System.Drawing.Point(319, 139);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Padding = new System.Windows.Forms.Padding(20, 10, 20, 35);
            this.BtnArticulos.Size = new System.Drawing.Size(230, 180);
            this.BtnArticulos.TabIndex = 78;
            this.BtnArticulos.Text = "Maestro de artículos";
            this.BtnArticulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnArticulos.UseVisualStyleBackColor = true;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnUsuarios.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnUsuarios.Image = global::TouchUP.Properties.Resources.iconUsuarios;
            this.BtnUsuarios.Location = new System.Drawing.Point(85, 139);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Padding = new System.Windows.Forms.Padding(20, 10, 20, 35);
            this.BtnUsuarios.Size = new System.Drawing.Size(230, 180);
            this.BtnUsuarios.TabIndex = 77;
            this.BtnUsuarios.Text = "Admin Usuarios";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // PicLogoSolnik
            // 
            this.PicLogoSolnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLogoSolnik.BackColor = System.Drawing.Color.RoyalBlue;
            this.PicLogoSolnik.Image = global::TouchUP.Properties.Resources.LogoSolnikDark;
            this.PicLogoSolnik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PicLogoSolnik.Location = new System.Drawing.Point(495, 75);
            this.PicLogoSolnik.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogoSolnik.Name = "PicLogoSolnik";
            this.PicLogoSolnik.Size = new System.Drawing.Size(57, 26);
            this.PicLogoSolnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogoSolnik.TabIndex = 76;
            this.PicLogoSolnik.TabStop = false;
            // 
            // PicLogoTouchUP
            // 
            this.PicLogoTouchUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLogoTouchUP.BackColor = System.Drawing.Color.RoyalBlue;
            this.PicLogoTouchUP.Image = global::TouchUP.Properties.Resources.LogoAppDark;
            this.PicLogoTouchUP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PicLogoTouchUP.Location = new System.Drawing.Point(495, 40);
            this.PicLogoTouchUP.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogoTouchUP.Name = "PicLogoTouchUP";
            this.PicLogoTouchUP.Size = new System.Drawing.Size(124, 52);
            this.PicLogoTouchUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogoTouchUP.TabIndex = 75;
            this.PicLogoTouchUP.TabStop = false;
            // 
            // PicHeaderContainer
            // 
            this.PicHeaderContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicHeaderContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.PicHeaderContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicHeaderContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PicHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.PicHeaderContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PicHeaderContainer.Name = "PicHeaderContainer";
            this.PicHeaderContainer.Padding = new System.Windows.Forms.Padding(20);
            this.PicHeaderContainer.Size = new System.Drawing.Size(634, 200);
            this.PicHeaderContainer.TabIndex = 72;
            this.PicHeaderContainer.TabStop = false;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.toolStripMenu.BackColor = System.Drawing.Color.White;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.BtnVisorFallas});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.toolStripMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenu.Size = new System.Drawing.Size(634, 27);
            this.toolStripMenu.Stretch = true;
            this.toolStripMenu.TabIndex = 81;
            this.toolStripMenu.Text = "toolStripNav";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioToolStripMenuItem,
            this.AbmProductosToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.toolStripDropDownButton1.Image = global::TouchUP.Properties.Resources.IconSeguridad;
            this.toolStripDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(116, 24);
            this.toolStripDropDownButton1.Text = "Administrador";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.InicioToolStripMenuItem.Image = global::TouchUP.Properties.Resources.TVIcon2;
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.InicioToolStripMenuItem.Text = "Inicio";
            // 
            // AbmProductosToolStripMenuItem
            // 
            this.AbmProductosToolStripMenuItem.Image = global::TouchUP.Properties.Resources.iconInicio;
            this.AbmProductosToolStripMenuItem.Name = "AbmProductosToolStripMenuItem";
            this.AbmProductosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AbmProductosToolStripMenuItem.Text = "ABM Usuarios";
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.SalirToolStripMenuItem.Image = global::TouchUP.Properties.Resources.iconSalir;
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.SalirToolStripMenuItem.Text = "Cerrar Sesión";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visorOperarioToolStripMenuItem1,
            this.visorSupervisorToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = global::TouchUP.Properties.Resources.BotonesMaker;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(78, 24);
            this.toolStripDropDownButton2.Text = "Perfiles";
            // 
            // visorOperarioToolStripMenuItem1
            // 
            this.visorOperarioToolStripMenuItem1.Image = global::TouchUP.Properties.Resources.IconOperario;
            this.visorOperarioToolStripMenuItem1.Name = "visorOperarioToolStripMenuItem1";
            this.visorOperarioToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.visorOperarioToolStripMenuItem1.Text = "Visor Operario";
            this.visorOperarioToolStripMenuItem1.Click += new System.EventHandler(this.visorOperarioToolStripMenuItem1_Click);
            // 
            // visorSupervisorToolStripMenuItem1
            // 
            this.visorSupervisorToolStripMenuItem1.Image = global::TouchUP.Properties.Resources.IconSupervisor;
            this.visorSupervisorToolStripMenuItem1.Name = "visorSupervisorToolStripMenuItem1";
            this.visorSupervisorToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.visorSupervisorToolStripMenuItem1.Text = "Visor Supervisor";
            this.visorSupervisorToolStripMenuItem1.Click += new System.EventHandler(this.visorSupervisorToolStripMenuItem1_Click);
            // 
            // BtnVisorFallas
            // 
            this.BtnVisorFallas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullHDToolStripMenuItem,
            this.wXToolStripMenuItem});
            this.BtnVisorFallas.Image = global::TouchUP.Properties.Resources.IconVer;
            this.BtnVisorFallas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVisorFallas.Name = "BtnVisorFallas";
            this.BtnVisorFallas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnVisorFallas.Size = new System.Drawing.Size(112, 24);
            this.BtnVisorFallas.Text = "Visor de fallas";
            // 
            // fullHDToolStripMenuItem
            // 
            this.fullHDToolStripMenuItem.Image = global::TouchUP.Properties.Resources.TVIcon;
            this.fullHDToolStripMenuItem.Name = "fullHDToolStripMenuItem";
            this.fullHDToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fullHDToolStripMenuItem.Text = "FULL HD (1920x1080)";
            this.fullHDToolStripMenuItem.Click += new System.EventHandler(this.fullHDToolStripMenuItem_Click);
            // 
            // wXToolStripMenuItem
            // 
            this.wXToolStripMenuItem.Image = global::TouchUP.Properties.Resources.TVIcon;
            this.wXToolStripMenuItem.Name = "wXToolStripMenuItem";
            this.wXToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.wXToolStripMenuItem.Text = "WXGA (1366x768)";
            this.wXToolStripMenuItem.Click += new System.EventHandler(this.wXToolStripMenuItem_Click);
            // 
            // TxtCopyright
            // 
            this.TxtCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCopyright.AutoSize = true;
            this.TxtCopyright.BackColor = System.Drawing.SystemColors.Control;
            this.TxtCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtCopyright.Font = new System.Drawing.Font("OpenSymbol", 8F);
            this.TxtCopyright.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtCopyright.Location = new System.Drawing.Point(213, 545);
            this.TxtCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtCopyright.Name = "TxtCopyright";
            this.TxtCopyright.Size = new System.Drawing.Size(201, 13);
            this.TxtCopyright.TabIndex = 82;
            this.TxtCopyright.Text = "SOLNIK SA - Proyectos y Tecnología";
            // 
            // timerCopyright
            // 
            this.timerCopyright.Enabled = true;
            this.timerCopyright.Tick += new System.EventHandler(this.timerCopyright_Tick);
            // 
            // AdminInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 581);
            this.Controls.Add(this.TxtCopyright);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.BtnSupervisor);
            this.Controls.Add(this.BtnOperario);
            this.Controls.Add(this.BtnArticulos);
            this.Controls.Add(this.BtnUsuarios);
            this.Controls.Add(this.PicLogoSolnik);
            this.Controls.Add(this.PicLogoTouchUP);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.LblHeadline);
            this.Controls.Add(this.PicHeaderContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUP - Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoSolnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoTouchUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHeaderContainer)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogoSolnik;
        private System.Windows.Forms.PictureBox PicLogoTouchUP;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Label LblHeadline;
        private System.Windows.Forms.PictureBox PicHeaderContainer;
        private System.Windows.Forms.Button BtnArticulos;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnSupervisor;
        private System.Windows.Forms.Button BtnOperario;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbmProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem visorOperarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visorSupervisorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton BtnVisorFallas;
        private System.Windows.Forms.ToolStripMenuItem fullHDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wXToolStripMenuItem;
        private System.Windows.Forms.Label TxtCopyright;
        private System.Windows.Forms.Timer timerCopyright;
    }
}