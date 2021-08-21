using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SyncfusionWinFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDc3ODU3QDMxMzkyZTMyMmUzMFZBS2l3VHBISFAxUDR0ZW96N25oeWFyTE43b0tNRG5ubXRoTXo4bVpWaVU9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
