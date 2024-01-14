using System;
using System.Drawing;
using System.Windows.Forms;

namespace TouchUP
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.DateA = new System.Windows.Forms.Timer(this.components);
            this.LblDatosDesarrollador = new System.Windows.Forms.Label();
            this.LblFechaVersion = new System.Windows.Forms.Label();
            this.LblVersionApp = new System.Windows.Forms.Label();
            this.picLogoSolnik = new System.Windows.Forms.PictureBox();
            this.picLogoApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSolnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // DateA
            // 
            this.DateA.Enabled = true;
            // 
            // LblDatosDesarrollador
            // 
            this.LblDatosDesarrollador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDatosDesarrollador.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblDatosDesarrollador.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosDesarrollador.ForeColor = System.Drawing.Color.White;
            this.LblDatosDesarrollador.Location = new System.Drawing.Point(-10, 183);
            this.LblDatosDesarrollador.Name = "LblDatosDesarrollador";
            this.LblDatosDesarrollador.Size = new System.Drawing.Size(400, 16);
            this.LblDatosDesarrollador.TabIndex = 7;
            this.LblDatosDesarrollador.Text = "DatosDesarrollador";
            this.LblDatosDesarrollador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFechaVersion
            // 
            this.LblFechaVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFechaVersion.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblFechaVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaVersion.ForeColor = System.Drawing.Color.White;
            this.LblFechaVersion.Location = new System.Drawing.Point(-10, 163);
            this.LblFechaVersion.Name = "LblFechaVersion";
            this.LblFechaVersion.Size = new System.Drawing.Size(400, 16);
            this.LblFechaVersion.TabIndex = 6;
            this.LblFechaVersion.Text = "FechaVersion";
            this.LblFechaVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVersionApp
            // 
            this.LblVersionApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVersionApp.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblVersionApp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LblVersionApp.ForeColor = System.Drawing.Color.White;
            this.LblVersionApp.Location = new System.Drawing.Point(-10, 125);
            this.LblVersionApp.Name = "LblVersionApp";
            this.LblVersionApp.Size = new System.Drawing.Size(400, 36);
            this.LblVersionApp.TabIndex = 9;
            this.LblVersionApp.Text = "vVersion";
            this.LblVersionApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogoSolnik
            // 
            this.picLogoSolnik.BackColor = System.Drawing.Color.RoyalBlue;
            this.picLogoSolnik.Image = global::TouchUP.Properties.Resources.LogoSolnikDark;
            this.picLogoSolnik.Location = new System.Drawing.Point(100, 79);
            this.picLogoSolnik.Name = "picLogoSolnik";
            this.picLogoSolnik.Size = new System.Drawing.Size(87, 39);
            this.picLogoSolnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoSolnik.TabIndex = 8;
            this.picLogoSolnik.TabStop = false;
            // 
            // picLogoApp
            // 
            this.picLogoApp.BackColor = System.Drawing.Color.RoyalBlue;
            this.picLogoApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogoApp.Image = global::TouchUP.Properties.Resources.LogoAppDark;
            this.picLogoApp.Location = new System.Drawing.Point(100, 25);
            this.picLogoApp.Name = "picLogoApp";
            this.picLogoApp.Size = new System.Drawing.Size(184, 78);
            this.picLogoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoApp.TabIndex = 4;
            this.picLogoApp.TabStop = false;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.LblVersionApp);
            this.Controls.Add(this.picLogoSolnik);
            this.Controls.Add(this.LblDatosDesarrollador);
            this.Controls.Add(this.LblFechaVersion);
            this.Controls.Add(this.picLogoApp);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updater";
            this.Padding = new System.Windows.Forms.Padding(100, 25, 100, 25);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchUP Solnik";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSolnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Timer DateA;
        private PictureBox picLogoApp;
        private Label LblDatosDesarrollador;
        private Label LblFechaVersion;
        private PictureBox picLogoSolnik;
        private Label LblVersionApp;
    }
}

