using System.Windows.Forms;

namespace TouchUP.Visores
{
    partial class HistoricoRegistroFallas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoRegistroFallas));
            this.timerVisor = new System.Windows.Forms.Timer(this.components);
            this.toolTipRef = new System.Windows.Forms.ToolTip(this.components);
            this.timerUpdateBD = new System.Windows.Forms.Timer(this.components);
            this.picLogoSolnik = new System.Windows.Forms.PictureBox();
            this.picLogoApp = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.groupBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.dataGridHistoricosRegistrosFallas = new System.Windows.Forms.DataGridView();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSolnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoApp)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.groupBoxDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoricosRegistrosFallas)).BeginInit();
            this.SuspendLayout();
            // 
            // timerVisor
            // 
            this.timerVisor.Enabled = true;
            // 
            // toolTipRef
            // 
            this.toolTipRef.OwnerDraw = true;
            // 
            // timerUpdateBD
            // 
            this.timerUpdateBD.Enabled = true;
            this.timerUpdateBD.Interval = 1200;
            // 
            // picLogoSolnik
            // 
            this.picLogoSolnik.Image = global::TouchUP.Properties.Resources.LogoSolnikDark;
            this.picLogoSolnik.Location = new System.Drawing.Point(12, 45);
            this.picLogoSolnik.Name = "picLogoSolnik";
            this.picLogoSolnik.Size = new System.Drawing.Size(66, 25);
            this.picLogoSolnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoSolnik.TabIndex = 19;
            this.picLogoSolnik.TabStop = false;
            // 
            // picLogoApp
            // 
            this.picLogoApp.Image = global::TouchUP.Properties.Resources.LogoAppDark;
            this.picLogoApp.Location = new System.Drawing.Point(12, 12);
            this.picLogoApp.Name = "picLogoApp";
            this.picLogoApp.Size = new System.Drawing.Size(123, 50);
            this.picLogoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoApp.TabIndex = 18;
            this.picLogoApp.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.BtnExportar);
            this.panelHeader.Controls.Add(this.picLogoSolnik);
            this.panelHeader.Controls.Add(this.picLogoApp);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(884, 82);
            this.panelHeader.TabIndex = 20;
            // 
            // BtnExportar
            // 
            this.BtnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.Image = global::TouchUP.Properties.Resources.IconExcelSaveAs;
            this.BtnExportar.Location = new System.Drawing.Point(726, 22);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnExportar.Size = new System.Drawing.Size(146, 40);
            this.BtnExportar.TabIndex = 21;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            this.BtnExportar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.BtnExportar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // groupBoxDataGrid
            // 
            this.groupBoxDataGrid.Controls.Add(this.dataGridHistoricosRegistrosFallas);
            this.groupBoxDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataGrid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataGrid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxDataGrid.Location = new System.Drawing.Point(0, 82);
            this.groupBoxDataGrid.Name = "groupBoxDataGrid";
            this.groupBoxDataGrid.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxDataGrid.Size = new System.Drawing.Size(884, 629);
            this.groupBoxDataGrid.TabIndex = 21;
            this.groupBoxDataGrid.TabStop = false;
            this.groupBoxDataGrid.Text = "Acciones Correctivas";
            // 
            // dataGridHistoricosRegistrosFallas
            // 
            this.dataGridHistoricosRegistrosFallas.AllowUserToAddRows = false;
            this.dataGridHistoricosRegistrosFallas.AllowUserToDeleteRows = false;
            this.dataGridHistoricosRegistrosFallas.AllowUserToResizeColumns = false;
            this.dataGridHistoricosRegistrosFallas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridHistoricosRegistrosFallas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHistoricosRegistrosFallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistoricosRegistrosFallas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridHistoricosRegistrosFallas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHistoricosRegistrosFallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridHistoricosRegistrosFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistoricosRegistrosFallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaHora,
            this.Modelo,
            this.Placa,
            this.Componente,
            this.Cantidad,
            this.Falla,
            this.Comentarios,
            this.Usuario});
            this.dataGridHistoricosRegistrosFallas.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHistoricosRegistrosFallas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridHistoricosRegistrosFallas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHistoricosRegistrosFallas.EnableHeadersVisualStyles = false;
            this.dataGridHistoricosRegistrosFallas.Location = new System.Drawing.Point(10, 28);
            this.dataGridHistoricosRegistrosFallas.Name = "dataGridHistoricosRegistrosFallas";
            this.dataGridHistoricosRegistrosFallas.ReadOnly = true;
            this.dataGridHistoricosRegistrosFallas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridHistoricosRegistrosFallas.RowHeadersVisible = false;
            this.dataGridHistoricosRegistrosFallas.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridHistoricosRegistrosFallas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridHistoricosRegistrosFallas.RowTemplate.Height = 100;
            this.dataGridHistoricosRegistrosFallas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHistoricosRegistrosFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHistoricosRegistrosFallas.ShowEditingIcon = false;
            this.dataGridHistoricosRegistrosFallas.Size = new System.Drawing.Size(864, 591);
            this.dataGridHistoricosRegistrosFallas.TabIndex = 14;
            // 
            // FechaHora
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaHora.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Falla
            // 
            this.Falla.HeaderText = "Falla";
            this.Falla.Name = "Falla";
            this.Falla.ReadOnly = true;
            // 
            // Comentarios
            // 
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // HistoricoRegistroFallas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.groupBoxDataGrid);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoricoRegistroFallas";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUP - Eliminar Registro de Fallas";
            this.MaximumSizeChanged += new System.EventHandler(this.HistoricoRegistroFallas_MaximumSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSolnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoApp)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.groupBoxDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoricosRegistrosFallas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerVisor;
        private System.Windows.Forms.ToolTip toolTipRef;
        public System.Windows.Forms.Timer timerUpdateBD;
        private PictureBox picLogoSolnik;
        private PictureBox picLogoApp;
        private Panel panelHeader;
        private GroupBox groupBoxDataGrid;
        private DataGridView dataGridHistoricosRegistrosFallas;
        private DataGridViewTextBoxColumn FechaHora;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn Componente;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Falla;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn Usuario;
        private Button BtnExportar;
    }
}