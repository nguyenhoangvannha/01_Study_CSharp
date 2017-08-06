using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerTool
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
            FormLogin frmLogin = new FormLogin();
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                //Enter to the system
                MessageBox.Show("Login success!");
            }
            
        }
    }
}
