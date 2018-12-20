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
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }
        int dem = 0;
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;

            if (textBox1.Text == label1.Text)
            {
                dem++;
                label1.Top = 0;
                Random rd = new Random();
                label1.Text = Convert.ToString((char)rd.Next(65, 122));
                txtDiem.Text = "" + dem;
                if (dem % 10 == 0) i++;
                textBox1.Text ="";
            }
    
            if (label1.Top >= max)
            {
                timer1.Stop();
                MessageBox.Show("Game over", "Kết thúc", MessageBoxButtons.OK);
                textBox1.Text = "";
                label1.Visible = false;
                button2.Visible = false;
                button1.Visible = true;
            }
            label1.Top += i;

        }
        int max=287;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            Random rd = new Random();
            label1.Text = Convert.ToString((char)rd.Next(65,122));
            timer1.Interval = 1;
            label1.Visible = true;
            timer1.Start();
  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Focus();
            Random rd = new Random();
            label1.Text = Convert.ToString((char)rd.Next(65, 122));
            label1.Visible = true;
            label1.Top = 0;
            txtDiem.Text = "00";
            timer1.Start();

        }
        
    }
}
