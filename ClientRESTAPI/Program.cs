using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRESTAPI
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
            Botones.prog1 = ConfigurationManager.AppSettings["prog1"];
            Botones.path1 = ConfigurationManager.AppSettings["path1"];
            Botones.prog2 = ConfigurationManager.AppSettings["prog2"];
            Botones.path2 = ConfigurationManager.AppSettings["path2"];
            Botones.prog3 = ConfigurationManager.AppSettings["prog3"];
            Botones.path3 = ConfigurationManager.AppSettings["path3"];
            Application.Run(new InicioSesionForm());
        }
    }
}
