using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmKeyBoard : Form
    {
        public frmKeyBoard()
        {
            InitializeComponent();
        }

        private void frmKeyBoard_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.A)
            {
                //picA.Visible = false;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
