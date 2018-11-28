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
    public partial class frmCharFallOut : Form
    {
        int dem = 0;
        int i = 1;
        int max;
        Random rd = new Random();

        public frmCharFallOut()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;

            if (textBox1.Text == lblChar.Text)
            {
                dem++;
                lblChar.Top = 0;
                Random rd = new Random();
                lblChar.Text = Convert.ToString((char)rd.Next(65, 122));
                lblDiem.Text = "" + dem;
                if (dem % 10 == 0) i++;
                textBox1.Text = "";
            }

            if (lblChar.Top >= max)
            {
                timer1.Stop();
                MessageBox.Show("Game over", "Kết thúc", MessageBoxButtons.OK);
                textBox1.Text = "";
                lblChar.Visible = false;
                btnChoi.Visible = false;
                btnChoiLai.Visible = true;
                btnChoiLai.Focus();
            }
            lblChar.Top += i;
        }

        private void btnChoi_Click(object sender, EventArgs e)
        {
            max = panel.Height - lblChar.Height;
            btnChoi.Visible = false;
            textBox1.Focus();
            lblChar.Text = Convert.ToString((char)rd.Next(65, 122));
            timer1.Interval = 1;
            lblChar.Visible = true;
            timer1.Start();
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            btnChoiLai.Visible = false;
            textBox1.Focus();
          
            lblChar.Text = Convert.ToString((char)rd.Next(65, 122));
            lblChar.Visible = true;
            lblChar.Top = 0;
            dem = 0;
            lblDiem.Text = "00";
            timer1.Start();

        }

        private void frmTextFallOut_Load(object sender, EventArgs e)
        {
            lblChar.Text = "";
            btnChoiLai.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
