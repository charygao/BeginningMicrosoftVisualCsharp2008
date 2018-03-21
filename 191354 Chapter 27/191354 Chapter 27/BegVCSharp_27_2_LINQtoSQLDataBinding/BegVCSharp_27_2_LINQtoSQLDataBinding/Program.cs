using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BegVCSharp_27_2_LINQtoSQLDataBinding
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
            Application.Run(new Form1());
        }
    }
}
