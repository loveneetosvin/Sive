using System;
using System.Linq;
using System.Windows.Forms;
//using ridDatagridView;

namespace Siidform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new facturaborrador());
            
            //Application.Run(new Splash());
          // Application.Run(new MenuEmpresa(""));
            //Application.Run(new RadForm1());
            //Application.Run(new Form());
            
        }
    }
}