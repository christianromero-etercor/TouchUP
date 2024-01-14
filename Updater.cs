using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TouchUP.Visores.operario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics.Eventing.Reader;
using TouchUP.Visores;
using TouchUP.Visores.admin;
using MySql.Data.MySqlClient;
using System.CodeDom;
using TouchUP.Placas.AA;
using TouchUP.Visores.supervisor;
using System.Diagnostics;
using System.IO;
using System.Threading;
using DocumentFormat.OpenXml.Bibliography;

namespace TouchUP
{
    public partial class Updater : Form
    {

        public Updater()
        {
            InitializeComponent();

            // Version

            LblVersionApp.Text = "Versión " + Application.ProductVersion.Substring(0, 3);
            LblFechaVersion.Text = "Última actualización: " + File.GetLastWriteTime(Application.ExecutablePath).ToString("dd/MM/yyyy");
            LblDatosDesarrollador.Text = "Desarrollado por: " + "Proyectos y Tecnología - SOLNIK SA";

        }

        private void BtnActualizarVersionApp_Click(object sender, EventArgs e)
        {
            // Check for updates

            try
            {
                // Check for updates

                string version = FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion;
                string version2 = FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion;

                if (version != version2)
                {
                    MessageBox.Show("Hay una nueva versión disponible. Se procederá a actualizar la aplicación.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("Updater.exe");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("No hay actualizaciones disponibles.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la aplicación. " + ex.Message, "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
