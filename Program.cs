using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TouchUP
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Abrir LoginForm.cs una sola vez el programa

            if (IsAlreadyRunning())
            {
                MessageBox.Show("La aplicación ya se encuentra ejecutándose.", "TouchUP - Solnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                OpenLoginForm();
            }
        }

        // Cerrar todos los forms abiertos

        public static void CloseAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private static void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        // Evitar abrir más de una vez el programa
        private static bool IsAlreadyRunning()
        {
            string strLoc = System.Reflection.Assembly.GetExecutingAssembly().Location;
            FileSystemInfo fileInfo = new System.IO.FileInfo(strLoc);
            string sExeName = fileInfo.Name;
            bool bCreatedNew;

            Mutex mutex = new Mutex(true, "Global\\" + sExeName, out bCreatedNew);
            if (bCreatedNew)
                mutex.ReleaseMutex();

            return !bCreatedNew;
        }

    }
}
