using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Based_DC_Machinery_Laboratory
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///public MainForm mform;// = new MainForm();
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mform = new MainForm();
            Application.Run(mform);
        }

    }
}
