using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            //Application.Run(new frmMenu());
            //Application.Run(new frmSpeedTestABC());
            //Application.Run(new frmFappybird());
            //Application.Run(new frmTypingTest());
            //Application.Run(new frmCharFallOut());
            Application.Run(new frmLogin());

            //frmLogin frm = new frmLogin();
            //if (frm.ShowDialog()==DialogResult.OK)
            //{
            //    Application.Run(new frmGame());
            //}

        }
    }
}
