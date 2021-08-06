using CapaNegocio;
using NobisSA.Envios;
using NobisSA.Terminos;
using NobisSA.Tramites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Licencia.CheckLicense();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            
            
        }
    }
}
