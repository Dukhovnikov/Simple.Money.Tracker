using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMoneyTracker.WinForms.Implementation;
using Simple_money_tracker_Core;

namespace SimpleMoneyTracker.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new AppLogic().Run(new RegistryWinForms());

            //Application.Run();
        }
    }
}
