namespace TouchUP.Placas.AA
{
    partial class PCB_DISPLAY_INVERTER_3200
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCB_DISPLAY_INVERTER_3200));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerFecha = new System.Windows.Forms.Timer(this.components);
            this.SideBarLeft = new System.Windows.Forms.Panel();
            this.pictureLogoSolnik = new System.Windows.Forms.PictureBox();
            this.LblPlacaSidebar = new System.Windows.Forms.Label();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.pictureLogoTouchUp = new System.Windows.Forms.PictureBox();
            this.BackSidebarLeft = new System.Windows.Forms.Label();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.BodyCenter = new System.Windows.Forms.Panel();
            this.GmbImagenPlaca = new System.Windows.Forms.GroupBox();
            this.picImagenPlaca = new System.Windows.Forms.PictureBox();
            this.toolTipComponentes = new System.Windows.Forms.ToolTip(this.components);
            this.GmbComponente = new System.Windows.Forms.GroupBox();
            this.LblComponente = new System.Windows.Forms.Label();
            this.GmbFalla = new System.Windows.Forms.GroupBox();
            this.radioButtonMalInsertado = new System.Windows.Forms.RadioButton();
            this.radioButtonEquivocado = new System.Windows.Forms.RadioButton();
            this.radioButtonLevantado = new System.Windows.Forms.RadioButton();
            this.radioButtonInvertido = new System.Windows.Forms.RadioButton();
            this.radioButtonFaltante = new System.Windows.Forms.RadioButton();
            this.GmbRegistro = new System.Windows.Forms.GroupBox();
            this.dataGridRegistroFallas = new System.Windows.Forms.DataGridView();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStripNav = new System.Windows.Forms.ToolStrip();
            this.LblSalir = new System.Windows.Forms.ToolStripLabel();
            this.LblMinimizar = new System.Windows.Forms.ToolStripLabel();
            this.LblInicio = new System.Windows.Forms.ToolStripLabel();
            this.SideBarRight = new System.Windows.Forms.Panel();
            this.timerUpdateBD = new System.Windows.Forms.Timer(this.components);
            this.SideBarLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoSolnik)).BeginInit();
            this.panelFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoTouchUp)).BeginInit();
            this.BodyCenter.SuspendLayout();
            this.GmbImagenPlaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenPlaca)).BeginInit();
            this.GmbComponente.SuspendLayout();
            this.GmbFalla.SuspendLayout();
            this.GmbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroFallas)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStripNav.SuspendLayout();
            this.SideBarRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerFecha
            // 
            this.timerFecha.Enabled = true;
            this.timerFecha.Tick += new System.EventHandler(this.timerFecha_Tick);
            // 
            // SideBarLeft
            // 
            resources.ApplyResources(this.SideBarLeft, "SideBarLeft");
            this.SideBarLeft.BackColor = System.Drawing.Color.LightSlateGray;
            this.SideBarLeft.Controls.Add(this.pictureLogoSolnik);
            this.SideBarLeft.Controls.Add(this.LblPlacaSidebar);
            this.SideBarLeft.Controls.Add(this.panelFecha);
            this.SideBarLeft.Controls.Add(this.LblHora);
            this.SideBarLeft.Controls.Add(this.pictureLogoTouchUp);
            this.SideBarLeft.Controls.Add(this.BackSidebarLeft);
            this.SideBarLeft.Controls.Add(this.LblPlaca);
            this.SideBarLeft.Controls.Add(this.LblModelo);
            this.SideBarLeft.Name = "SideBarLeft";
            // 
            // pictureLogoSolnik
            // 
            resources.ApplyResources(this.pictureLogoSolnik, "pictureLogoSolnik");
            this.pictureLogoSolnik.Image = global::TouchUP.Properties.Resources.LogoSolnikDark;
            this.pictureLogoSolnik.Name = "pictureLogoSolnik";
            this.pictureLogoSolnik.TabStop = false;
            // 
            // LblPlacaSidebar
            // 
            resources.ApplyResources(this.LblPlacaSidebar, "LblPlacaSidebar");
            this.LblPlacaSidebar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.LblPlacaSidebar.Name = "LblPlacaSidebar";
            this.LblPlacaSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.LblPlacaSidebar_Paint);
            // 
            // panelFecha
            // 
            resources.ApplyResources(this.panelFecha, "panelFecha");
            this.panelFecha.Controls.Add(this.LblFecha);
            this.panelFecha.Name = "panelFecha";
            // 
            // LblFecha
            // 
            resources.ApplyResources(this.LblFecha, "LblFecha");
            this.LblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Name = "LblFecha";
            // 
            // LblHora
            // 
            resources.ApplyResources(this.LblHora, "LblHora");
            this.LblHora.ForeColor = System.Drawing.Color.White;
            this.LblHora.Name = "LblHora";
            // 
            // pictureLogoTouchUp
            // 
            resources.ApplyResources(this.pictureLogoTouchUp, "pictureLogoTouchUp");
            this.pictureLogoTouchUp.Name = "pictureLogoTouchUp";
            this.pictureLogoTouchUp.TabStop = false;
            // 
            // BackSidebarLeft
            // 
            resources.ApplyResources(this.BackSidebarLeft, "BackSidebarLeft");
            this.BackSidebarLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSidebarLeft.Name = "BackSidebarLeft";
            // 
            // LblPlaca
            // 
            resources.ApplyResources(this.LblPlaca, "LblPlaca");
            this.LblPlaca.Name = "LblPlaca";
            // 
            // LblModelo
            // 
            resources.ApplyResources(this.LblModelo, "LblModelo");
            this.LblModelo.Name = "LblModelo";
            // 
            // BodyCenter
            // 
            resources.ApplyResources(this.BodyCenter, "BodyCenter");
            this.BodyCenter.BackColor = System.Drawing.SystemColors.Control;
            this.BodyCenter.Controls.Add(this.GmbImagenPlaca);
            this.BodyCenter.Name = "BodyCenter";
            // 
            // GmbImagenPlaca
            // 
            this.GmbImagenPlaca.Controls.Add(this.picImagenPlaca);
            resources.ApplyResources(this.GmbImagenPlaca, "GmbImagenPlaca");
            this.GmbImagenPlaca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GmbImagenPlaca.Name = "GmbImagenPlaca";
            this.GmbImagenPlaca.TabStop = false;
            // 
            // picImagenPlaca
            // 
            resources.ApplyResources(this.picImagenPlaca, "picImagenPlaca");
            this.picImagenPlaca.Name = "picImagenPlaca";
            this.picImagenPlaca.TabStop = false;
            this.picImagenPlaca.Click += new System.EventHandler(this.picImagenPlaca_Click);
            this.picImagenPlaca.MouseHover += new System.EventHandler(this.picImagenPlaca_MouseHover);
            // 
            // toolTipComponentes
            // 
            this.toolTipComponentes.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolTipComponentes.ForeColor = System.Drawing.Color.White;
            this.toolTipComponentes.IsBalloon = true;
            // 
            // GmbComponente
            // 
            this.GmbComponente.Controls.Add(this.LblComponente);
            resources.ApplyResources(this.GmbComponente, "GmbComponente");
            this.GmbComponente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GmbComponente.Name = "GmbComponente";
            this.GmbComponente.TabStop = false;
            // 
            // LblComponente
            // 
            resources.ApplyResources(this.LblComponente, "LblComponente");
            this.LblComponente.ForeColor = System.Drawing.Color.White;
            this.LblComponente.Name = "LblComponente";
            this.LblComponente.TextChanged += new System.EventHandler(this.LblComponente_TextChanged);
            // 
            // GmbFalla
            // 
            resources.ApplyResources(this.GmbFalla, "GmbFalla");
            this.GmbFalla.Controls.Add(this.radioButtonMalInsertado);
            this.GmbFalla.Controls.Add(this.radioButtonEquivocado);
            this.GmbFalla.Controls.Add(this.radioButtonLevantado);
            this.GmbFalla.Controls.Add(this.radioButtonInvertido);
            this.GmbFalla.Controls.Add(this.radioButtonFaltante);
            this.GmbFalla.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GmbFalla.Name = "GmbFalla";
            this.GmbFalla.TabStop = false;
            // 
            // radioButtonMalInsertado
            // 
            resources.ApplyResources(this.radioButtonMalInsertado, "radioButtonMalInsertado");
            this.radioButtonMalInsertado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMalInsertado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonMalInsertado.ForeColor = System.Drawing.Color.Silver;
            this.radioButtonMalInsertado.Name = "radioButtonMalInsertado";
            this.radioButtonMalInsertado.UseMnemonic = false;
            this.radioButtonMalInsertado.UseVisualStyleBackColor = false;
            this.radioButtonMalInsertado.CheckedChanged += new System.EventHandler(this.radioButtonMalInsertado_CheckedChanged);
            this.radioButtonMalInsertado.MouseLeave += new System.EventHandler(this.radioButton_MouseLeave);
            this.radioButtonMalInsertado.MouseHover += new System.EventHandler(this.radioButton_MouseHover);
            // 
            // radioButtonEquivocado
            // 
            resources.ApplyResources(this.radioButtonEquivocado, "radioButtonEquivocado");
            this.radioButtonEquivocado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonEquivocado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonEquivocado.ForeColor = System.Drawing.Color.Silver;
            this.radioButtonEquivocado.Name = "radioButtonEquivocado";
            this.radioButtonEquivocado.UseMnemonic = false;
            this.radioButtonEquivocado.UseVisualStyleBackColor = false;
            this.radioButtonEquivocado.CheckedChanged += new System.EventHandler(this.radioButtonEquivocado_CheckedChanged);
            this.radioButtonEquivocado.MouseLeave += new System.EventHandler(this.radioButton_MouseLeave);
            this.radioButtonEquivocado.MouseHover += new System.EventHandler(this.radioButton_MouseHover);
            // 
            // radioButtonLevantado
            // 
            resources.ApplyResources(this.radioButtonLevantado, "radioButtonLevantado");
            this.radioButtonLevantado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonLevantado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonLevantado.ForeColor = System.Drawing.Color.Silver;
            this.radioButtonLevantado.Name = "radioButtonLevantado";
            this.radioButtonLevantado.UseMnemonic = false;
            this.radioButtonLevantado.UseVisualStyleBackColor = false;
            this.radioButtonLevantado.CheckedChanged += new System.EventHandler(this.radioButtonLevantado_CheckedChanged);
            this.radioButtonLevantado.MouseLeave += new System.EventHandler(this.radioButton_MouseLeave);
            this.radioButtonLevantado.MouseHover += new System.EventHandler(this.radioButton_MouseHover);
            // 
            // radioButtonInvertido
            // 
            resources.ApplyResources(this.radioButtonInvertido, "radioButtonInvertido");
            this.radioButtonInvertido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonInvertido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonInvertido.ForeColor = System.Drawing.Color.Silver;
            this.radioButtonInvertido.Name = "radioButtonInvertido";
            this.radioButtonInvertido.UseMnemonic = false;
            this.radioButtonInvertido.UseVisualStyleBackColor = false;
            this.radioButtonInvertido.CheckedChanged += new System.EventHandler(this.radioButtonInvertido_CheckedChanged);
            this.radioButtonInvertido.MouseLeave += new System.EventHandler(this.radioButton_MouseLeave);
            this.radioButtonInvertido.MouseHover += new System.EventHandler(this.radioButton_MouseHover);
            // 
            // radioButtonFaltante
            // 
            resources.ApplyResources(this.radioButtonFaltante, "radioButtonFaltante");
            this.radioButtonFaltante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFaltante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonFaltante.ForeColor = System.Drawing.Color.Silver;
            this.radioButtonFaltante.Name = "radioButtonFaltante";
            this.radioButtonFaltante.UseMnemonic = false;
            this.radioButtonFaltante.UseVisualStyleBackColor = false;
            this.radioButtonFaltante.CheckedChanged += new System.EventHandler(this.radioButtonFaltante_CheckedChanged);
            this.radioButtonFaltante.MouseLeave += new System.EventHandler(this.radioButton_MouseLeave);
            this.radioButtonFaltante.MouseHover += new System.EventHandler(this.radioButton_MouseHover);
            // 
            // GmbRegistro
            // 
            resources.ApplyResources(this.GmbRegistro, "GmbRegistro");
            this.GmbRegistro.Controls.Add(this.dataGridRegistroFallas);
            this.GmbRegistro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GmbRegistro.Name = "GmbRegistro";
            this.GmbRegistro.TabStop = false;
            // 
            // dataGridRegistroFallas
            // 
            this.dataGridRegistroFallas.AllowUserToAddRows = false;
            this.dataGridRegistroFallas.AllowUserToDeleteRows = false;
            this.dataGridRegistroFallas.AllowUserToResizeColumns = false;
            this.dataGridRegistroFallas.AllowUserToResizeRows = false;
            this.dataGridRegistroFallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRegistroFallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRegistroFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistroFallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaHora,
            this.RefModelo,
            this.RefPlaca,
            this.Componente,
            this.Falla});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRegistroFallas.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridRegistroFallas, "dataGridRegistroFallas");
            this.dataGridRegistroFallas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridRegistroFallas.MultiSelect = false;
            this.dataGridRegistroFallas.Name = "dataGridRegistroFallas";
            this.dataGridRegistroFallas.ReadOnly = true;
            this.dataGridRegistroFallas.RowHeadersVisible = false;
            this.dataGridRegistroFallas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridRegistroFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRegistroFallas.ShowCellToolTips = false;
            this.dataGridRegistroFallas.ShowEditingIcon = false;
            // 
            // FechaHora
            // 
            resources.ApplyResources(this.FechaHora, "FechaHora");
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            // 
            // RefModelo
            // 
            resources.ApplyResources(this.RefModelo, "RefModelo");
            this.RefModelo.Name = "RefModelo";
            this.RefModelo.ReadOnly = true;
            // 
            // RefPlaca
            // 
            resources.ApplyResources(this.RefPlaca, "RefPlaca");
            this.RefPlaca.Name = "RefPlaca";
            this.RefPlaca.ReadOnly = true;
            // 
            // Componente
            // 
            this.Componente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Componente, "Componente");
            this.Componente.Name = "Componente";
            this.Componente.ReadOnly = true;
            // 
            // Falla
            // 
            this.Falla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Falla, "Falla");
            this.Falla.Name = "Falla";
            this.Falla.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStripNav);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // toolStripNav
            // 
            resources.ApplyResources(this.toolStripNav, "toolStripNav");
            this.toolStripNav.BackColor = System.Drawing.Color.Transparent;
            this.toolStripNav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblSalir,
            this.LblMinimizar,
            this.LblInicio});
            this.toolStripNav.Name = "toolStripNav";
            this.toolStripNav.MouseLeave += new System.EventHandler(this.toolStripNav_MouseLeave);
            this.toolStripNav.MouseHover += new System.EventHandler(this.toolStripNav_MouseHover);
            // 
            // LblSalir
            // 
            this.LblSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.LblSalir, "LblSalir");
            this.LblSalir.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblSalir.Image = global::TouchUP.Properties.Resources.IconExitOutline;
            this.LblSalir.Margin = new System.Windows.Forms.Padding(0);
            this.LblSalir.Name = "LblSalir";
            this.LblSalir.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.LblSalir.VisitedLinkColor = System.Drawing.Color.Silver;
            this.LblSalir.Click += new System.EventHandler(this.LblSalir_Click);
            this.LblSalir.MouseLeave += new System.EventHandler(this.toolStripNav_MouseLeave);
            this.LblSalir.MouseHover += new System.EventHandler(this.toolStripNav_MouseHover);
            // 
            // LblMinimizar
            // 
            this.LblMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.LblMinimizar, "LblMinimizar");
            this.LblMinimizar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblMinimizar.Image = global::TouchUP.Properties.Resources.IconMinimizarOutline;
            this.LblMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.LblMinimizar.Name = "LblMinimizar";
            this.LblMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.LblMinimizar.VisitedLinkColor = System.Drawing.Color.Silver;
            this.LblMinimizar.Click += new System.EventHandler(this.LblMinimizar_Click);
            this.LblMinimizar.MouseLeave += new System.EventHandler(this.toolStripNav_MouseLeave);
            this.LblMinimizar.MouseHover += new System.EventHandler(this.toolStripNav_MouseHover);
            // 
            // LblInicio
            // 
            this.LblInicio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.LblInicio, "LblInicio");
            this.LblInicio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblInicio.Image = global::TouchUP.Properties.Resources.IconInicioOutline;
            this.LblInicio.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Click += new System.EventHandler(this.LblInicio_Click);
            this.LblInicio.MouseHover += new System.EventHandler(this.LblInicio_MouseHover);
            // 
            // SideBarRight
            // 
            resources.ApplyResources(this.SideBarRight, "SideBarRight");
            this.SideBarRight.BackColor = System.Drawing.SystemColors.Control;
            this.SideBarRight.Controls.Add(this.panel3);
            this.SideBarRight.Controls.Add(this.GmbRegistro);
            this.SideBarRight.Controls.Add(this.GmbFalla);
            this.SideBarRight.Controls.Add(this.GmbComponente);
            this.SideBarRight.Name = "SideBarRight";
            // 
            // timerUpdateBD
            // 
            this.timerUpdateBD.Enabled = true;
            this.timerUpdateBD.Interval = 1200;
            this.timerUpdateBD.Tick += new System.EventHandler(this.timerUpdateBD_Tick);
            // 
            // PCB_DISPLAY_INVERTER_3200
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.BodyCenter);
            this.Controls.Add(this.SideBarLeft);
            this.Controls.Add(this.SideBarRight);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "PCB_DISPLAY_INVERTER_3200";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SideBarLeft.ResumeLayout(false);
            this.SideBarLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoSolnik)).EndInit();
            this.panelFecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoTouchUp)).EndInit();
            this.BodyCenter.ResumeLayout(false);
            this.GmbImagenPlaca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenPlaca)).EndInit();
            this.GmbComponente.ResumeLayout(false);
            this.GmbComponente.PerformLayout();
            this.GmbFalla.ResumeLayout(false);
            this.GmbRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroFallas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.toolStripNav.ResumeLayout(false);
            this.toolStripNav.PerformLayout();
            this.SideBarRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerFecha;
        private System.Windows.Forms.Panel SideBarLeft;
        private System.Windows.Forms.Panel BodyCenter;
        private System.Windows.Forms.GroupBox GmbImagenPlaca;
        public System.Windows.Forms.PictureBox picImagenPlaca;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.PictureBox pictureLogoTouchUp;
        private System.Windows.Forms.ToolTip toolTipComponentes;
        private System.Windows.Forms.GroupBox GmbComponente;
        private System.Windows.Forms.Label LblComponente;
        private System.Windows.Forms.GroupBox GmbFalla;
        private System.Windows.Forms.RadioButton radioButtonEquivocado;
        private System.Windows.Forms.RadioButton radioButtonLevantado;
        private System.Windows.Forms.RadioButton radioButtonInvertido;
        private System.Windows.Forms.RadioButton radioButtonFaltante;
        private System.Windows.Forms.GroupBox GmbRegistro;
        public System.Windows.Forms.DataGridView dataGridRegistroFallas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Componente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Falla;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStripNav;
        private System.Windows.Forms.ToolStripLabel LblSalir;
        private System.Windows.Forms.ToolStripLabel LblMinimizar;
        private System.Windows.Forms.ToolStripLabel LblInicio;
        private System.Windows.Forms.Panel SideBarRight;
        private System.Windows.Forms.Label BackSidebarLeft;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblPlacaSidebar;
        public System.Windows.Forms.Timer timerUpdateBD;
        private System.Windows.Forms.RadioButton radioButtonMalInsertado;
        private System.Windows.Forms.PictureBox pictureLogoSolnik;
    }
}