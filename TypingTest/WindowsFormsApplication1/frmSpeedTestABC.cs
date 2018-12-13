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
    public partial class frmSpeedTestABC : Form
    {
        public frmSpeedTestABC()
        {
            InitializeComponent();
        }
        int seconds = 0;
        int minutes = 0;
        private void frmSpeedTestABC_Load(object sender, EventArgs e)
        {
            this.KeyPreview = false;
            btnChoiLai.Visible = false;
        }
        private void frmSpeedTestABC_Load1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void frmSpeedTestABC_Load2(object sender, EventArgs e)
        {
            this.KeyPreview = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;

            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;

            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;

            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;

            label26.Visible = true;

        }

        private void GameOver()
        {
            if(minutes==0)
            {
                MessageBox.Show("Thời gian bạn đánh hết chữ cái trên bàn phím từ a->z là " + lblSenconds.Text+" giây", "GameOver",  MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Thời gian bạn đánh hết chữ cái trên bàn phím từ a->z là " +lblMinute.Text+" phút " +lblSenconds.Text+ "giây", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmSpeedTestABC_KeyPress(object sender, KeyPressEventArgs e)
        {
      
           if (e.KeyChar == 'a')
            {
                label1.Visible = false;
            }
            if (e.KeyChar == 'b'&&(label1.Visible==false))
            {
                label2.Visible = false;
            }
            if (e.KeyChar == 'c' && (label2.Visible == false))
            {
                label3.Visible = false;
            }
            if (e.KeyChar == 'd'&&(label3.Visible==false))
            {
                label4.Visible = false;
            }
            if (e.KeyChar == 'e' && (label4.Visible == false))
            {
                label5.Visible = false;
            }
            if (e.KeyChar == 'f' && (label5.Visible == false))
            {
                label6.Visible = false;
            }
            if (e.KeyChar == 'g' && (label6.Visible == false))
            {
                label7.Visible = false;
            }
            if (e.KeyChar == 'h' && (label7.Visible == false))
            {
                label8.Visible = false;
            }
            if (e.KeyChar == 'i' && (label8.Visible == false))
            {
                label9.Visible = false;
            }
            if (e.KeyChar == 'j' && (label9.Visible == false))
            {
                label10.Visible = false;
            }
            if (e.KeyChar == 'k' && (label10.Visible == false))
            {
                label11.Visible = false;
            }
            if (e.KeyChar == 'l' && (label11.Visible == false))
            {
                label12.Visible = false;
            }
            if (e.KeyChar == 'm' && (label12.Visible == false))
            {
                label13.Visible = false;
            }
            if (e.KeyChar == 'n' && (label13.Visible == false))
            {
                label14.Visible = false;
            }
            if (e.KeyChar == 'o' && (label14.Visible == false))
            {
                label15.Visible = false;
            }

            if (e.KeyChar == 'p' && (label15.Visible == false))
            {
                label16.Visible = false;
            }
            if (e.KeyChar == 'q' && (label16.Visible == false))
            {
                label17.Visible = false;
            }
            if (e.KeyChar == 'r' && (label17.Visible == false))
            {
                label18.Visible = false;
            }
            if (e.KeyChar == 's' && (label18.Visible == false))
            {
                label19.Visible = false;
            }
            if (e.KeyChar == 't' && (label19.Visible == false))
            {
                label20.Visible = false;
            }
            if (e.KeyChar == 'u' && (label20.Visible == false))
            {
                label21.Visible = false;
            }
            if (e.KeyChar == 'v' && (label21.Visible == false))
            {
                label22.Visible = false;
            }
            if (e.KeyChar == 'w' && (label22.Visible == false))
            {
                label23.Visible = false;
            }
            if (e.KeyChar == 'x' && (label23.Visible == false))
            {
                label24.Visible = false;
            }
            if (e.KeyChar == 'y' && (label24.Visible == false))
            {
                label25.Visible = false;
            }
            if (e.KeyChar == 'z' && (label25.Visible == false))
            {
                label26.Visible = false;
                btnChoiLai.Visible = true;
                timer1.Stop();
                GameOver();
                frmSpeedTestABC_Load2(sender, e);
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            frmSpeedTestABC_Load1(sender, e);
            btnChoi.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            seconds++;
            if(seconds<=59)
            {
                if(seconds<=9)
                {
                    lblSenconds.Text = "0" + seconds;
                }
                else
                {
                    lblSenconds.Text = seconds + "";
                }  
            }
            else
            {
                seconds = 0;
                lblSenconds.Text = "00";
                minutes++;
                if(minutes<=9)
                {
                    lblMinute.Text = "0" + minutes;
                }
                else
                {
                    lblMinute.Text = minutes + "";
                }
            }

        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            frmSpeedTestABC_Load1(sender, e);
            btnChoiLai.Visible = false;
            timer1.Start();
            seconds = 0;
            minutes = 0;
            lblMinute.Text = "00";
            lblSenconds.Text = "00";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
