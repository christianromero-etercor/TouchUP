using System.Windows.Forms;

namespace TouchUP.Visores
{
    partial class DisplaySupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySupervisor));
            this.toolStripNav2 = new System.Windows.Forms.ToolStrip();
            this.PicLogo = new System.Windows.Forms.ToolStripLabel();
            this.Timer = new System.Windows.Forms.ToolStripLabel();
            this.timerVisor = new System.Windows.Forms.Timer(this.components);
            this.toolTipRef = new System.Windows.Forms.ToolTip(this.components);
            this.timerUpdateBD = new System.Windows.Forms.Timer(this.components);
            this.listBoxFallasAA = new System.Windows.Forms.ListBox();
            this.listBoxFallasTV = new System.Windows.Forms.ListBox();
            this.groupBoxRegistros = new System.Windows.Forms.GroupBox();
            this.LblNoRegAA = new System.Windows.Forms.Label();
            this.LblNoRegTV = new System.Windows.Forms.Label();
            this.panelHeaderTV = new System.Windows.Forms.Panel();
            this.LblHeaderTV = new System.Windows.Forms.Label();
            this.panelHeaderAA = new System.Windows.Forms.Panel();
            this.LblHeaderAA = new System.Windows.Forms.Label();
            this.groupBoxStatusAlarm = new System.Windows.Forms.GroupBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblStatusAlarm = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.BtnCerrarSesion = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnVisorFallas = new System.Windows.Forms.ToolStripDropDownButton();
            this.fullHDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnHistoricoFallas = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripNav2.SuspendLayout();
            this.groupBoxRegistros.SuspendLayout();
            this.panelHeaderTV.SuspendLayout();
            this.panelHeaderAA.SuspendLayout();
            this.groupBoxStatusAlarm.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // toolTipRef
            // 
            this.toolTipRef.OwnerDraw = true;
            // 
            // timerUpdateBD
            // 
            this.timerUpdateBD.Enabled = true;
            this.timerUpdateBD.Interval = 1200;
            this.timerUpdateBD.Tick += new System.EventHandler(this.timerUpdateBD_Tick);
            // 
            // listBoxFallasAA
            // 
            this.listBoxFallasAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFallasAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.listBoxFallasAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFallasAA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxFallasAA.ForeColor = System.Drawing.Color.White;
            this.listBoxFallasAA.FormattingEnabled = true;
            this.listBoxFallasAA.ItemHeight = 21;
            this.listBoxFallasAA.Location = new System.Drawing.Point(13, 96);
            this.listBoxFallasAA.Name = "listBoxFallasAA";
            this.listBoxFallasAA.Size = new System.Drawing.Size(456, 231);
            this.listBoxFallasAA.TabIndex = 9;
            this.listBoxFallasAA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFallas_MouseDoubleClick);
            this.listBoxFallasAA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFallas_MouseDoubleClick);
            // 
            // listBoxFallasTV
            // 
            this.listBoxFallasTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFallasTV.BackColor = System.Drawing.Color.MediumTurquoise;
            this.listBoxFallasTV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFallasTV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxFallasTV.ForeColor = System.Drawing.Color.White;
            this.listBoxFallasTV.FormattingEnabled = true;
            this.listBoxFallasTV.ItemHeight = 21;
            this.listBoxFallasTV.Location = new System.Drawing.Point(491, 96);
            this.listBoxFallasTV.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxFallasTV.Name = "listBoxFallasTV";
            this.listBoxFallasTV.Size = new System.Drawing.Size(456, 231);
            this.listBoxFallasTV.TabIndex = 10;
            this.listBoxFallasTV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFallas_MouseDoubleClick);
            this.listBoxFallasTV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFallas_MouseDoubleClick);
            // 
            // groupBoxRegistros
            // 
            this.groupBoxRegistros.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRegistros.Controls.Add(this.LblNoRegAA);
            this.groupBoxRegistros.Controls.Add(this.LblNoRegTV);
            this.groupBoxRegistros.Controls.Add(this.listBoxFallasTV);
            this.groupBoxRegistros.Controls.Add(this.listBoxFallasAA);
            this.groupBoxRegistros.Controls.Add(this.panelHeaderTV);
            this.groupBoxRegistros.Controls.Add(this.panelHeaderAA);
            this.groupBoxRegistros.Controls.Add(this.groupBoxStatusAlarm);
            this.groupBoxRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRegistros.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistros.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBoxRegistros.Location = new System.Drawing.Point(20, 87);
            this.groupBoxRegistros.Name = "groupBoxRegistros";
            this.groupBoxRegistros.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxRegistros.Size = new System.Drawing.Size(960, 443);
            this.groupBoxRegistros.TabIndex = 9;
            this.groupBoxRegistros.TabStop = false;
            this.groupBoxRegistros.Text = "Registros de Fallas - Selección para acción correctiva";
            // 
            // LblNoRegAA
            // 
            this.LblNoRegAA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNoRegAA.AutoSize = true;
            this.LblNoRegAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.LblNoRegAA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LblNoRegAA.ForeColor = System.Drawing.Color.White;
            this.LblNoRegAA.Location = new System.Drawing.Point(82, 181);
            this.LblNoRegAA.Name = "LblNoRegAA";
            this.LblNoRegAA.Size = new System.Drawing.Size(313, 25);
            this.LblNoRegAA.TabIndex = 15;
            this.LblNoRegAA.Text = "No hay alertas del TouchUP de AA";
            // 
            // LblNoRegTV
            // 
            this.LblNoRegTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNoRegTV.AutoSize = true;
            this.LblNoRegTV.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LblNoRegTV.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LblNoRegTV.ForeColor = System.Drawing.Color.White;
            this.LblNoRegTV.Location = new System.Drawing.Point(563, 181);
            this.LblNoRegTV.Name = "LblNoRegTV";
            this.LblNoRegTV.Size = new System.Drawing.Size(312, 25);
            this.LblNoRegTV.TabIndex = 14;
            this.LblNoRegTV.Text = "No hay alertas del TouchUP de TV";
            // 
            // panelHeaderTV
            // 
            this.panelHeaderTV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHeaderTV.Controls.Add(this.LblHeaderTV);
            this.panelHeaderTV.ForeColor = System.Drawing.Color.White;
            this.panelHeaderTV.Location = new System.Drawing.Point(491, 26);
            this.panelHeaderTV.Name = "panelHeaderTV";
            this.panelHeaderTV.Size = new System.Drawing.Size(456, 70);
            this.panelHeaderTV.TabIndex = 17;
            // 
            // LblHeaderTV
            // 
            this.LblHeaderTV.BackColor = System.Drawing.Color.Turquoise;
            this.LblHeaderTV.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderTV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblHeaderTV.ForeColor = System.Drawing.Color.White;
            this.LblHeaderTV.Image = global::TouchUP.Properties.Resources.TVIconW2;
            this.LblHeaderTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblHeaderTV.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderTV.Name = "LblHeaderTV";
            this.LblHeaderTV.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.LblHeaderTV.Size = new System.Drawing.Size(456, 70);
            this.LblHeaderTV.TabIndex = 17;
            this.LblHeaderTV.Text = "Puesto de TV (Alarmas activas: 0)";
            this.LblHeaderTV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeaderAA
            // 
            this.panelHeaderAA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHeaderAA.Controls.Add(this.LblHeaderAA);
            this.panelHeaderAA.ForeColor = System.Drawing.Color.White;
            this.panelHeaderAA.Location = new System.Drawing.Point(13, 26);
            this.panelHeaderAA.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeaderAA.Name = "panelHeaderAA";
            this.panelHeaderAA.Size = new System.Drawing.Size(456, 70);
            this.panelHeaderAA.TabIndex = 16;
            // 
            // LblHeaderAA
            // 
            this.LblHeaderAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.LblHeaderAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderAA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblHeaderAA.ForeColor = System.Drawing.Color.White;
            this.LblHeaderAA.Image = global::TouchUP.Properties.Resources.AAIconW2;
            this.LblHeaderAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblHeaderAA.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderAA.Name = "LblHeaderAA";
            this.LblHeaderAA.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.LblHeaderAA.Size = new System.Drawing.Size(456, 70);
            this.LblHeaderAA.TabIndex = 17;
            this.LblHeaderAA.Text = "Puesto de AA (Alarmas activas: 0)";
            this.LblHeaderAA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxStatusAlarm
            // 
            this.groupBoxStatusAlarm.Controls.Add(this.LblUsuario);
            this.groupBoxStatusAlarm.Controls.Add(this.lblStatusAlarm);
            this.groupBoxStatusAlarm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxStatusAlarm.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBoxStatusAlarm.Location = new System.Drawing.Point(10, 335);
            this.groupBoxStatusAlarm.Name = "groupBoxStatusAlarm";
            this.groupBoxStatusAlarm.Size = new System.Drawing.Size(940, 98);
            this.groupBoxStatusAlarm.TabIndex = 11;
            this.groupBoxStatusAlarm.TabStop = false;
            this.groupBoxStatusAlarm.Text = "Estado de la alarma";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(874, 80);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(63, 15);
            this.LblUsuario.TabIndex = 84;
            this.LblUsuario.Text = "LblUsuario";
            this.LblUsuario.Visible = false;
            // 
            // lblStatusAlarm
            // 
            this.lblStatusAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusAlarm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatusAlarm.ForeColor = System.Drawing.Color.Silver;
            this.lblStatusAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusAlarm.Location = new System.Drawing.Point(3, 19);
            this.lblStatusAlarm.Name = "lblStatusAlarm";
            this.lblStatusAlarm.Size = new System.Drawing.Size(934, 76);
            this.lblStatusAlarm.TabIndex = 0;
            this.lblStatusAlarm.Text = "La alarma se encuentra apagada";
            this.lblStatusAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.toolStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrarSesion,
            this.toolStripSeparator1,
            this.BtnVisorFallas,
            this.BtnHistoricoFallas});
            this.toolStripMenu.Location = new System.Drawing.Point(20, 20);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 11, 40);
            this.toolStripMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenu.Size = new System.Drawing.Size(960, 67);
            this.toolStripMenu.Stretch = true;
            this.toolStripMenu.TabIndex = 82;
            this.toolStripMenu.Text = "toolStripNav";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Image = global::TouchUP.Properties.Resources.IconExitFlat;
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCerrarSesion.Size = new System.Drawing.Size(96, 24);
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.BackColor = System.Drawing.Color.DimGray;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(1, 27);
            // 
            // BtnVisorFallas
            // 
            this.BtnVisorFallas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullHDToolStripMenuItem,
            this.wXToolStripMenuItem});
            this.BtnVisorFallas.Image = global::TouchUP.Properties.Resources.IconVer;
            this.BtnVisorFallas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVisorFallas.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
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
            // BtnHistoricoFallas
            // 
            this.BtnHistoricoFallas.Image = global::TouchUP.Properties.Resources.IconSeguridad;
            this.BtnHistoricoFallas.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.BtnHistoricoFallas.Name = "BtnHistoricoFallas";
            this.BtnHistoricoFallas.Size = new System.Drawing.Size(140, 24);
            this.BtnHistoricoFallas.Text = "Histórico de acciones";
            this.BtnHistoricoFallas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnHistoricoFallas.Click += new System.EventHandler(this.BtnHistoricoFallas_Click);
            this.BtnHistoricoFallas.MouseLeave += new System.EventHandler(this.BtnInicio_MouseLeave);
            this.BtnHistoricoFallas.MouseHover += new System.EventHandler(this.BtnInicio_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TouchUP.Properties.Resources.TouchUPLogoWXGA;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // DisplaySupervisor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxRegistros);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.toolStripNav2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DisplaySupervisor";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUP - Registro de Fallas";
            this.toolStripNav2.ResumeLayout(false);
            this.toolStripNav2.PerformLayout();
            this.groupBoxRegistros.ResumeLayout(false);
            this.groupBoxRegistros.PerformLayout();
            this.panelHeaderTV.ResumeLayout(false);
            this.panelHeaderAA.ResumeLayout(false);
            this.groupBoxStatusAlarm.ResumeLayout(false);
            this.groupBoxStatusAlarm.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripNav2;
        private System.Windows.Forms.ToolStripLabel PicLogo;
        private System.Windows.Forms.ToolStripLabel Timer;
        private System.Windows.Forms.Timer timerVisor;
        private System.Windows.Forms.ToolTip toolTipRef;
        public System.Windows.Forms.Timer timerUpdateBD;
        public ListBox listBoxFallasAA;
        public ListBox listBoxFallasTV;
        private GroupBox groupBoxRegistros;
        private ToolStrip toolStripMenu;
        private ToolStripDropDownButton BtnVisorFallas;
        private ToolStripMenuItem fullHDToolStripMenuItem;
        private ToolStripMenuItem wXToolStripMenuItem;
        private PictureBox pictureBox1;
        private GroupBox groupBoxStatusAlarm;
        private Label lblStatusAlarm;
        private Label LblNoRegTV;
        private Panel panelHeaderAA;
        private Label LblNoRegAA;
        private Label LblHeaderAA;
        private Panel panelHeaderTV;
        private Label LblHeaderTV;
        private ToolStripLabel BtnCerrarSesion;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel BtnHistoricoFallas;
        private Label LblUsuario;
    }
}