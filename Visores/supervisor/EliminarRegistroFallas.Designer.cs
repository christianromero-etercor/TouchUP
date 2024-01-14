using System.Windows.Forms;

namespace TouchUP.Visores
{
    partial class EliminarRegistroFallas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarRegistroFallas));
            this.timerVisor = new System.Windows.Forms.Timer(this.components);
            this.toolTipRef = new System.Windows.Forms.ToolTip(this.components);
            this.timerUpdateBD = new System.Windows.Forms.Timer(this.components);
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBoxAccion = new System.Windows.Forms.GroupBox();
            this.LblAccionCorrectiva = new System.Windows.Forms.TextBox();
            this.groupBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.dataGridRegistrosSelected = new System.Windows.Forms.DataGridView();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogoApp = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.LblComponente = new System.Windows.Forms.Label();
            this.picLogoSolnik = new System.Windows.Forms.PictureBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.groupBoxAccion.SuspendLayout();
            this.groupBoxDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistrosSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoApp)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSolnik)).BeginInit();
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
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEliminar.Image = global::TouchUP.Properties.Resources.BtnEliminarGrey;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(151, 366);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnEliminar.Size = new System.Drawing.Size(180, 40);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar Registros";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.BtnEliminar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(337, 366);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(180, 40);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.BtnCancelar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // groupBoxAccion
            // 
            this.groupBoxAccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAccion.Controls.Add(this.LblAccionCorrectiva);
            this.groupBoxAccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAccion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxAccion.Location = new System.Drawing.Point(12, 254);
            this.groupBoxAccion.Name = "groupBoxAccion";
            this.groupBoxAccion.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.groupBoxAccion.Size = new System.Drawing.Size(660, 106);
            this.groupBoxAccion.TabIndex = 16;
            this.groupBoxAccion.TabStop = false;
            this.groupBoxAccion.Text = "Acción Correctiva";
            // 
            // LblAccionCorrectiva
            // 
            this.LblAccionCorrectiva.BackColor = System.Drawing.SystemColors.Control;
            this.LblAccionCorrectiva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LblAccionCorrectiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAccionCorrectiva.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Italic);
            this.LblAccionCorrectiva.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblAccionCorrectiva.Location = new System.Drawing.Point(10, 33);
            this.LblAccionCorrectiva.Multiline = true;
            this.LblAccionCorrectiva.Name = "LblAccionCorrectiva";
            this.LblAccionCorrectiva.Size = new System.Drawing.Size(640, 63);
            this.LblAccionCorrectiva.TabIndex = 0;
            this.LblAccionCorrectiva.Click += new System.EventHandler(this.LblAccionCorrectiva_Click);
            this.LblAccionCorrectiva.TextChanged += new System.EventHandler(this.LblAccionCorrectiva_TextChanged);
            // 
            // groupBoxDataGrid
            // 
            this.groupBoxDataGrid.Controls.Add(this.dataGridRegistrosSelected);
            this.groupBoxDataGrid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataGrid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxDataGrid.Location = new System.Drawing.Point(12, 88);
            this.groupBoxDataGrid.Name = "groupBoxDataGrid";
            this.groupBoxDataGrid.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.groupBoxDataGrid.Size = new System.Drawing.Size(660, 160);
            this.groupBoxDataGrid.TabIndex = 17;
            this.groupBoxDataGrid.TabStop = false;
            this.groupBoxDataGrid.Text = "Componente";
            // 
            // dataGridRegistrosSelected
            // 
            this.dataGridRegistrosSelected.AllowUserToAddRows = false;
            this.dataGridRegistrosSelected.AllowUserToDeleteRows = false;
            this.dataGridRegistrosSelected.AllowUserToResizeColumns = false;
            this.dataGridRegistrosSelected.AllowUserToResizeRows = false;
            this.dataGridRegistrosSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRegistrosSelected.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridRegistrosSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(9)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(9)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRegistrosSelected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRegistrosSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistrosSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaHora,
            this.Modelo,
            this.Placa,
            this.Componente,
            this.Falla});
            this.dataGridRegistrosSelected.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRegistrosSelected.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRegistrosSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRegistrosSelected.EnableHeadersVisualStyles = false;
            this.dataGridRegistrosSelected.Location = new System.Drawing.Point(10, 33);
            this.dataGridRegistrosSelected.Name = "dataGridRegistrosSelected";
            this.dataGridRegistrosSelected.ReadOnly = true;
            this.dataGridRegistrosSelected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridRegistrosSelected.RowHeadersVisible = false;
            this.dataGridRegistrosSelected.RowHeadersWidth = 50;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridRegistrosSelected.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridRegistrosSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRegistrosSelected.ShowEditingIcon = false;
            this.dataGridRegistrosSelected.Size = new System.Drawing.Size(640, 117);
            this.dataGridRegistrosSelected.TabIndex = 14;
            // 
            // FechaHora
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaHora.DefaultCellStyle = dataGridViewCellStyle2;
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
            // Falla
            // 
            this.Falla.HeaderText = "Falla";
            this.Falla.Name = "Falla";
            this.Falla.ReadOnly = true;
            // 
            // picLogoApp
            // 
            this.picLogoApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoApp.Image = global::TouchUP.Properties.Resources.LogoAppDark;
            this.picLogoApp.Location = new System.Drawing.Point(22, 11);
            this.picLogoApp.Name = "picLogoApp";
            this.picLogoApp.Size = new System.Drawing.Size(111, 50);
            this.picLogoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoApp.TabIndex = 18;
            this.picLogoApp.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(9)))), ((int)(((byte)(39)))));
            this.panelHeader.Controls.Add(this.LblComponente);
            this.panelHeader.Controls.Add(this.picLogoSolnik);
            this.panelHeader.Controls.Add(this.picLogoApp);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(684, 82);
            this.panelHeader.TabIndex = 19;
            // 
            // LblComponente
            // 
            this.LblComponente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblComponente.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LblComponente.ForeColor = System.Drawing.Color.White;
            this.LblComponente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblComponente.Location = new System.Drawing.Point(139, 16);
            this.LblComponente.Name = "LblComponente";
            this.LblComponente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblComponente.Size = new System.Drawing.Size(542, 45);
            this.LblComponente.TabIndex = 20;
            this.LblComponente.Text = "Componente";
            this.LblComponente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLogoSolnik
            // 
            this.picLogoSolnik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoSolnik.Image = global::TouchUP.Properties.Resources.LogoSolnikDark;
            this.picLogoSolnik.Location = new System.Drawing.Point(22, 44);
            this.picLogoSolnik.Name = "picLogoSolnik";
            this.picLogoSolnik.Size = new System.Drawing.Size(54, 25);
            this.picLogoSolnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoSolnik.TabIndex = 19;
            this.picLogoSolnik.TabStop = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(614, 361);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 13);
            this.LblUsuario.TabIndex = 85;
            this.LblUsuario.Text = "LblUsuario";
            this.LblUsuario.Visible = false;
            // 
            // EliminarRegistroFallas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 421);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.groupBoxAccion);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.groupBoxDataGrid);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EliminarRegistroFallas";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUP - Eliminar Registro de Fallas";
            this.groupBoxAccion.ResumeLayout(false);
            this.groupBoxAccion.PerformLayout();
            this.groupBoxDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistrosSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoApp)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSolnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerVisor;
        private System.Windows.Forms.ToolTip toolTipRef;
        public System.Windows.Forms.Timer timerUpdateBD;
        private Button BtnEliminar;
        private Button BtnCancelar;
        private GroupBox groupBoxAccion;
        private TextBox LblAccionCorrectiva;
        private GroupBox groupBoxDataGrid;
        private DataGridView dataGridRegistrosSelected;
        private DataGridViewTextBoxColumn FechaHora;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn Componente;
        private DataGridViewTextBoxColumn Falla;
        private PictureBox picLogoApp;
        private Panel panelHeader;
        private PictureBox picLogoSolnik;
        private Label LblComponente;
        private Label LblUsuario;
    }
}