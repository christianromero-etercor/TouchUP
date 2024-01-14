using System.Windows.Forms;

namespace TouchUP.Visores
{
    partial class VisorTouchWXGA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorTouchWXGA));
            this.toolStripNav1 = new System.Windows.Forms.ToolStrip();
            this.BtnDataAA = new System.Windows.Forms.ToolStripButton();
            this.BtnDataTV = new System.Windows.Forms.ToolStripButton();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            this.BtnLoginSupervisor = new System.Windows.Forms.ToolStripButton();
            this.panelAA = new System.Windows.Forms.Panel();
            this.groupBoxAA = new System.Windows.Forms.GroupBox();
            this.PicAlarmAA = new System.Windows.Forms.PictureBox();
            this.dataGridAA = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblLineaAA = new System.Windows.Forms.Label();
            this.panelTV = new System.Windows.Forms.Panel();
            this.groupBoxTV = new System.Windows.Forms.GroupBox();
            this.PicAlarmTV = new System.Windows.Forms.PictureBox();
            this.dataGridTV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblLineaTV = new System.Windows.Forms.Label();
            this.toolStripNav2 = new System.Windows.Forms.ToolStrip();
            this.PicLogo = new System.Windows.Forms.ToolStripLabel();
            this.Timer = new System.Windows.Forms.ToolStripLabel();
            this.timerVisor = new System.Windows.Forms.Timer(this.components);
            this.toolTipRef = new System.Windows.Forms.ToolTip(this.components);
            this.FechaHoy = new System.Windows.Forms.Label();
            this.timerUpdateBD = new System.Windows.Forms.Timer(this.components);
            this.HoraInicio = new System.Windows.Forms.Label();
            this.FechaInicio = new System.Windows.Forms.Label();
            this.panelInicial = new System.Windows.Forms.Panel();
            this.pictureLogoInicial = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripNav1.SuspendLayout();
            this.panelAA.SuspendLayout();
            this.groupBoxAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlarmAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAA)).BeginInit();
            this.panelTV.SuspendLayout();
            this.groupBoxTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlarmTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTV)).BeginInit();
            this.toolStripNav2.SuspendLayout();
            this.panelInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripNav1
            // 
            this.toolStripNav1.AutoSize = false;
            this.toolStripNav1.CanOverflow = false;
            this.toolStripNav1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNav1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolStripNav1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnDataAA,
            this.BtnDataTV,
            this.BtnSalir,
            this.BtnLoginSupervisor});
            this.toolStripNav1.Location = new System.Drawing.Point(0, 0);
            this.toolStripNav1.Name = "toolStripNav1";
            this.toolStripNav1.Size = new System.Drawing.Size(1366, 80);
            this.toolStripNav1.TabIndex = 0;
            this.toolStripNav1.Text = "toolStrip1";
            // 
            // BtnDataAA
            // 
            this.BtnDataAA.AutoSize = false;
            this.BtnDataAA.BackColor = System.Drawing.Color.Silver;
            this.BtnDataAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDataAA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDataAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.BtnDataAA.Image = global::TouchUP.Properties.Resources.AAIconVHide;
            this.BtnDataAA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDataAA.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.BtnDataAA.Margin = new System.Windows.Forms.Padding(10);
            this.BtnDataAA.Name = "BtnDataAA";
            this.BtnDataAA.Padding = new System.Windows.Forms.Padding(20);
            this.BtnDataAA.Size = new System.Drawing.Size(100, 85);
            this.BtnDataAA.Text = "AA";
            this.BtnDataAA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDataAA.ToolTipText = "Registro de Fallas - Puesto AA";
            this.BtnDataAA.Click += new System.EventHandler(this.BtnDataAA_Click);
            this.BtnDataAA.MouseLeave += new System.EventHandler(this.BtnDataAA_MouseLeave);
            this.BtnDataAA.MouseHover += new System.EventHandler(this.BtnDataAA_MouseHover);
            // 
            // BtnDataTV
            // 
            this.BtnDataTV.AutoSize = false;
            this.BtnDataTV.BackColor = System.Drawing.Color.Silver;
            this.BtnDataTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDataTV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDataTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.BtnDataTV.Image = global::TouchUP.Properties.Resources.TVIconVHide;
            this.BtnDataTV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDataTV.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.BtnDataTV.Margin = new System.Windows.Forms.Padding(10);
            this.BtnDataTV.Name = "BtnDataTV";
            this.BtnDataTV.Padding = new System.Windows.Forms.Padding(20);
            this.BtnDataTV.Size = new System.Drawing.Size(100, 85);
            this.BtnDataTV.Text = "TV";
            this.BtnDataTV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDataTV.ToolTipText = "Registro de Fallas - Puesto TV";
            this.BtnDataTV.Click += new System.EventHandler(this.BtnDataTV_Click);
            this.BtnDataTV.MouseLeave += new System.EventHandler(this.BtnDataTV_MouseLeave);
            this.BtnDataTV.MouseHover += new System.EventHandler(this.BtnDataTV_MouseHover);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir.AutoSize = false;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(36)))), ((int)(((byte)(102)))));
            this.BtnSalir.Image = global::TouchUP.Properties.Resources.iconSalir;
            this.BtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(10);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Padding = new System.Windows.Forms.Padding(20);
            this.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSalir.Size = new System.Drawing.Size(100, 85);
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.ToolTipText = "Cerrar Registro de Fallas";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            this.BtnSalir.MouseHover += new System.EventHandler(this.BtnSalir_MouseHover);
            // 
            // BtnLoginSupervisor
            // 
            this.BtnLoginSupervisor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnLoginSupervisor.AutoSize = false;
            this.BtnLoginSupervisor.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginSupervisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLoginSupervisor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginSupervisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLoginSupervisor.Image = global::TouchUP.Properties.Resources.iconSupervisorEnable;
            this.BtnLoginSupervisor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnLoginSupervisor.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.BtnLoginSupervisor.Margin = new System.Windows.Forms.Padding(10);
            this.BtnLoginSupervisor.Name = "BtnLoginSupervisor";
            this.BtnLoginSupervisor.Padding = new System.Windows.Forms.Padding(20);
            this.BtnLoginSupervisor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLoginSupervisor.RightToLeftAutoMirrorImage = true;
            this.BtnLoginSupervisor.Size = new System.Drawing.Size(100, 85);
            this.BtnLoginSupervisor.Text = "SUPERVISOR";
            this.BtnLoginSupervisor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLoginSupervisor.ToolTipText = "Desactivar Alarma";
            this.BtnLoginSupervisor.Click += new System.EventHandler(this.BtnLoginSupervisor_Click);
            this.BtnLoginSupervisor.MouseLeave += new System.EventHandler(this.BtnInicio_MouseLeave);
            this.BtnLoginSupervisor.MouseHover += new System.EventHandler(this.BtnInicio_MouseHover);
            // 
            // panelAA
            // 
            this.panelAA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelAA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAA.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelAA.Controls.Add(this.groupBoxAA);
            this.panelAA.Location = new System.Drawing.Point(0, 80);
            this.panelAA.Margin = new System.Windows.Forms.Padding(0);
            this.panelAA.Name = "panelAA";
            this.panelAA.Padding = new System.Windows.Forms.Padding(25);
            this.panelAA.Size = new System.Drawing.Size(683, 588);
            this.panelAA.TabIndex = 1;
            this.panelAA.Visible = false;
            // 
            // groupBoxAA
            // 
            this.groupBoxAA.AutoSize = true;
            this.groupBoxAA.Controls.Add(this.PicAlarmAA);
            this.groupBoxAA.Controls.Add(this.dataGridAA);
            this.groupBoxAA.Controls.Add(this.LblLineaAA);
            this.groupBoxAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAA.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.groupBoxAA.ForeColor = System.Drawing.Color.White;
            this.groupBoxAA.Location = new System.Drawing.Point(25, 25);
            this.groupBoxAA.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxAA.Name = "groupBoxAA";
            this.groupBoxAA.Padding = new System.Windows.Forms.Padding(20, 40, 20, 20);
            this.groupBoxAA.Size = new System.Drawing.Size(633, 538);
            this.groupBoxAA.TabIndex = 0;
            this.groupBoxAA.TabStop = false;
            this.groupBoxAA.Text = "Linea de Aires";
            // 
            // PicAlarmAA
            // 
            this.PicAlarmAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicAlarmAA.Image = global::TouchUP.Properties.Resources.alarm;
            this.PicAlarmAA.Location = new System.Drawing.Point(515, 0);
            this.PicAlarmAA.Name = "PicAlarmAA";
            this.PicAlarmAA.Size = new System.Drawing.Size(105, 88);
            this.PicAlarmAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAlarmAA.TabIndex = 6;
            this.PicAlarmAA.TabStop = false;
            this.PicAlarmAA.Visible = false;
            // 
            // dataGridAA
            // 
            this.dataGridAA.AllowUserToAddRows = false;
            this.dataGridAA.AllowUserToDeleteRows = false;
            this.dataGridAA.AllowUserToResizeColumns = false;
            this.dataGridAA.AllowUserToResizeRows = false;
            this.dataGridAA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAA.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridAA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridAA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Modelo,
            this.Placa,
            this.Componente,
            this.Falla,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAA.EnableHeadersVisualStyles = false;
            this.dataGridAA.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridAA.Location = new System.Drawing.Point(20, 87);
            this.dataGridAA.MultiSelect = false;
            this.dataGridAA.Name = "dataGridAA";
            this.dataGridAA.ReadOnly = true;
            this.dataGridAA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAA.RowHeadersVisible = false;
            this.dataGridAA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridAA.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAA.RowTemplate.Height = 32;
            this.dataGridAA.RowTemplate.ReadOnly = true;
            this.dataGridAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAA.Size = new System.Drawing.Size(593, 431);
            this.dataGridAA.TabIndex = 1;
            this.dataGridAA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridAA_Scroll);
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Componente
            // 
            this.Componente.HeaderText = "Componente";
            this.Componente.Name = "Componente";
            this.Componente.ReadOnly = true;
            // 
            // Falla
            // 
            this.Falla.HeaderText = "Falla";
            this.Falla.Name = "Falla";
            this.Falla.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // LblLineaAA
            // 
            this.LblLineaAA.AutoSize = true;
            this.LblLineaAA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblLineaAA.Location = new System.Drawing.Point(15, 45);
            this.LblLineaAA.Name = "LblLineaAA";
            this.LblLineaAA.Size = new System.Drawing.Size(120, 21);
            this.LblLineaAA.TabIndex = 0;
            this.LblLineaAA.Text = "Top 15 TouchUP";
            // 
            // panelTV
            // 
            this.panelTV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelTV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelTV.Controls.Add(this.groupBoxTV);
            this.panelTV.Location = new System.Drawing.Point(683, 80);
            this.panelTV.Margin = new System.Windows.Forms.Padding(0);
            this.panelTV.Name = "panelTV";
            this.panelTV.Padding = new System.Windows.Forms.Padding(25);
            this.panelTV.Size = new System.Drawing.Size(683, 588);
            this.panelTV.TabIndex = 2;
            this.panelTV.Visible = false;
            // 
            // groupBoxTV
            // 
            this.groupBoxTV.AutoSize = true;
            this.groupBoxTV.Controls.Add(this.PicAlarmTV);
            this.groupBoxTV.Controls.Add(this.dataGridTV);
            this.groupBoxTV.Controls.Add(this.LblLineaTV);
            this.groupBoxTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTV.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.groupBoxTV.ForeColor = System.Drawing.Color.White;
            this.groupBoxTV.Location = new System.Drawing.Point(25, 25);
            this.groupBoxTV.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxTV.Name = "groupBoxTV";
            this.groupBoxTV.Padding = new System.Windows.Forms.Padding(20, 40, 20, 20);
            this.groupBoxTV.Size = new System.Drawing.Size(633, 538);
            this.groupBoxTV.TabIndex = 2;
            this.groupBoxTV.TabStop = false;
            this.groupBoxTV.Text = "Linea de TV";
            // 
            // PicAlarmTV
            // 
            this.PicAlarmTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicAlarmTV.Image = global::TouchUP.Properties.Resources.alarm;
            this.PicAlarmTV.Location = new System.Drawing.Point(515, 0);
            this.PicAlarmTV.Name = "PicAlarmTV";
            this.PicAlarmTV.Size = new System.Drawing.Size(105, 88);
            this.PicAlarmTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAlarmTV.TabIndex = 7;
            this.PicAlarmTV.TabStop = false;
            this.PicAlarmTV.Visible = false;
            // 
            // dataGridTV
            // 
            this.dataGridTV.AllowUserToAddRows = false;
            this.dataGridTV.AllowUserToDeleteRows = false;
            this.dataGridTV.AllowUserToResizeColumns = false;
            this.dataGridTV.AllowUserToResizeRows = false;
            this.dataGridTV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTV.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridTV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridTV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridTV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTV.EnableHeadersVisualStyles = false;
            this.dataGridTV.GridColor = System.Drawing.Color.Aquamarine;
            this.dataGridTV.Location = new System.Drawing.Point(20, 87);
            this.dataGridTV.MultiSelect = false;
            this.dataGridTV.Name = "dataGridTV";
            this.dataGridTV.ReadOnly = true;
            this.dataGridTV.RowHeadersVisible = false;
            this.dataGridTV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridTV.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridTV.RowTemplate.Height = 32;
            this.dataGridTV.RowTemplate.ReadOnly = true;
            this.dataGridTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTV.ShowEditingIcon = false;
            this.dataGridTV.Size = new System.Drawing.Size(593, 431);
            this.dataGridTV.TabIndex = 1;
            this.dataGridTV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridTV_Scroll);
            this.dataGridTV.MouseLeave += new System.EventHandler(this.BtnDataTV_MouseLeave);
            this.dataGridTV.MouseHover += new System.EventHandler(this.BtnDataTV_MouseHover);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Componente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Falla";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // LblLineaTV
            // 
            this.LblLineaTV.AutoSize = true;
            this.LblLineaTV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblLineaTV.Location = new System.Drawing.Point(15, 45);
            this.LblLineaTV.Name = "LblLineaTV";
            this.LblLineaTV.Size = new System.Drawing.Size(120, 21);
            this.LblLineaTV.TabIndex = 0;
            this.LblLineaTV.Text = "Top 15 TouchUP";
            // 
            // toolStripNav2
            // 
            this.toolStripNav2.AutoSize = false;
            this.toolStripNav2.BackColor = System.Drawing.Color.White;
            this.toolStripNav2.CanOverflow = false;
            this.toolStripNav2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripNav2.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripNav2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNav2.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolStripNav2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PicLogo,
            this.Timer});
            this.toolStripNav2.Location = new System.Drawing.Point(0, 80);
            this.toolStripNav2.Name = "toolStripNav2";
            this.toolStripNav2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripNav2.Size = new System.Drawing.Size(1366, 100);
            this.toolStripNav2.TabIndex = 3;
            this.toolStripNav2.Text = "toolStrip1";
            this.toolStripNav2.Visible = false;
            // 
            // PicLogo
            // 
            this.PicLogo.AutoSize = false;
            this.PicLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PicLogo.Image = global::TouchUP.Properties.Resources.TouchUPLogoWXGA;
            this.PicLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(230, 80);
            this.PicLogo.Text = "toolStripLabel1";
            // 
            // Timer
            // 
            this.Timer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Timer.Font = new System.Drawing.Font("Segoe UI", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(391, 97);
            this.Timer.Text = "TimerVisor";
            // 
            // timerVisor
            // 
            this.timerVisor.Enabled = true;
            this.timerVisor.Tick += new System.EventHandler(this.timerVisor_Tick);
            // 
            // toolTipRef
            // 
            this.toolTipRef.OwnerDraw = true;
            // 
            // FechaHoy
            // 
            this.FechaHoy.AutoSize = true;
            this.FechaHoy.BackColor = System.Drawing.Color.White;
            this.FechaHoy.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold);
            this.FechaHoy.ForeColor = System.Drawing.Color.Silver;
            this.FechaHoy.Location = new System.Drawing.Point(535, 88);
            this.FechaHoy.Name = "FechaHoy";
            this.FechaHoy.Size = new System.Drawing.Size(403, 81);
            this.FechaHoy.TabIndex = 5;
            this.FechaHoy.Text = "Fecha de hoy";
            this.FechaHoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FechaHoy.Visible = false;
            // 
            // timerUpdateBD
            // 
            this.timerUpdateBD.Enabled = true;
            this.timerUpdateBD.Interval = 1200;
            this.timerUpdateBD.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // HoraInicio
            // 
            this.HoraInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraInicio.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.HoraInicio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HoraInicio.Location = new System.Drawing.Point(0, 187);
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Size = new System.Drawing.Size(400, 85);
            this.HoraInicio.TabIndex = 2;
            this.HoraInicio.Text = "Hora";
            this.HoraInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FechaInicio
            // 
            this.FechaInicio.Font = new System.Drawing.Font("Noto Sans Cond", 10.5F, System.Drawing.FontStyle.Bold);
            this.FechaInicio.ForeColor = System.Drawing.Color.Black;
            this.FechaInicio.Location = new System.Drawing.Point(83, 146);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(162, 37);
            this.FechaInicio.TabIndex = 1;
            this.FechaInicio.Text = "Fecha";
            this.FechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInicial
            // 
            this.panelInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInicial.Controls.Add(this.FechaInicio);
            this.panelInicial.Controls.Add(this.pictureLogoInicial);
            this.panelInicial.Controls.Add(this.pictureBox1);
            this.panelInicial.Controls.Add(this.HoraInicio);
            this.panelInicial.Location = new System.Drawing.Point(484, 200);
            this.panelInicial.Name = "panelInicial";
            this.panelInicial.Size = new System.Drawing.Size(400, 300);
            this.panelInicial.TabIndex = 7;
            // 
            // pictureLogoInicial
            // 
            this.pictureLogoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogoInicial.Image = global::TouchUP.Properties.Resources.LogoAppLight;
            this.pictureLogoInicial.Location = new System.Drawing.Point(87, 71);
            this.pictureLogoInicial.Name = "pictureLogoInicial";
            this.pictureLogoInicial.Size = new System.Drawing.Size(231, 102);
            this.pictureLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogoInicial.TabIndex = 0;
            this.pictureLogoInicial.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TouchUP.Properties.Resources.LogoSolnikLight;
            this.pictureBox1.Location = new System.Drawing.Point(148, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // VisorTouchWXGA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.toolStripNav1);
            this.Controls.Add(this.panelTV);
            this.Controls.Add(this.panelAA);
            this.Controls.Add(this.panelInicial);
            this.Controls.Add(this.FechaHoy);
            this.Controls.Add(this.toolStripNav2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VisorTouchWXGA";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUP - Registro de Fallas";
            this.Activated += new System.EventHandler(this.VisorTouchWXGA_Activated);
            this.Deactivate += new System.EventHandler(this.VisorTouchWXGA_Deactivate);
            this.toolStripNav1.ResumeLayout(false);
            this.toolStripNav1.PerformLayout();
            this.panelAA.ResumeLayout(false);
            this.panelAA.PerformLayout();
            this.groupBoxAA.ResumeLayout(false);
            this.groupBoxAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlarmAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAA)).EndInit();
            this.panelTV.ResumeLayout(false);
            this.panelTV.PerformLayout();
            this.groupBoxTV.ResumeLayout(false);
            this.groupBoxTV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlarmTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTV)).EndInit();
            this.toolStripNav2.ResumeLayout(false);
            this.toolStripNav2.PerformLayout();
            this.panelInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripNav1;
        private System.Windows.Forms.ToolStripButton BtnDataAA;
        private System.Windows.Forms.ToolStripButton BtnDataTV;
        private System.Windows.Forms.Panel panelAA;
        private System.Windows.Forms.Panel panelTV;
        private System.Windows.Forms.ToolStrip toolStripNav2;
        private System.Windows.Forms.ToolStripLabel PicLogo;
        private System.Windows.Forms.ToolStripLabel Timer;
        private System.Windows.Forms.Timer timerVisor;
        private System.Windows.Forms.ToolTip toolTipRef;
        private System.Windows.Forms.Label FechaHoy;
        private System.Windows.Forms.ToolStripButton BtnLoginSupervisor;
        private System.Windows.Forms.GroupBox groupBoxAA;
        private System.Windows.Forms.DataGridView dataGridAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Componente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Falla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label LblLineaAA;
        private System.Windows.Forms.GroupBox groupBoxTV;
        private System.Windows.Forms.Label LblLineaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton BtnSalir;
        private System.Windows.Forms.PictureBox PicAlarmAA;
        private System.Windows.Forms.PictureBox PicAlarmTV;
        public System.Windows.Forms.DataGridView dataGridTV;
        public System.Windows.Forms.Timer timerUpdateBD;
        private Label HoraInicio;
        private PictureBox pictureBox1;
        private PictureBox pictureLogoInicial;
        private Label FechaInicio;
        private Panel panelInicial;
    }
}