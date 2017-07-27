using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_AKUH_TB.Deshboard;
using View_AKUH_TB.ComboBoxForms;
using View_AKUH_TB.Login;

namespace View_AKUH_TB
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
            Application.Run(new frm_AdminMain());
        }
    }
}
