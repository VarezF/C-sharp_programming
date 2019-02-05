/**
 * Author: Freya Varez
 * Date: 2/4/2019
 * Details: Finds the number of distinct integers in a list using 3 unique methods
 * Outputs results, as well as compexities of the 3 methods to Win Form via textbox
 **/
namespace HW2
{
    using System;
    using System.Windows.Forms;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
