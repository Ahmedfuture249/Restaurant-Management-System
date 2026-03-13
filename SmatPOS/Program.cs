using Microsoft.Identity.Client;
using SmatPOS.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmatPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
       
            
            
            adoClass.SetConnection();
            Application.SetCompatibleTextRenderingDefault(false);
            FormSatrtUp frmSetUp = new FormSatrtUp();
            if (frmSetUp.ShowDialog() == DialogResult.OK)
            {

                FormLogin frmlogin = new FormLogin();
                if (frmlogin.ShowDialog() == DialogResult.OK)
                {

                    Application.EnableVisualStyles();

                    
                     Application.Run(new MainForm());
                }
            }
        }
    }
}
