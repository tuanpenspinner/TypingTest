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
        Random rd = new Random();
        private void frmSpeedTestABC_Load(object sender, EventArgs e)
        {
            if(strcmbTestABC=="A->Z")
            {
                frmSpeedTestABC_Load_ABC(sender, e);
            }

            if (strcmbTestABC == "0->9")
            {
                frmSpeedTestABC_Load_09(sender, e);
            }

            if(strcmbTestABC== "Random(~!@#$)")
            {
                frmSpeedTestABC_Load_Random(sender, e);
                
            }

            this.KeyPreview = false;
            btnChoiLai.Visible = false;

        }

        private void ChangeColorLabel()
        {
            if (label1.Visible == false)
            {
                label2.ForeColor = Color.Red;
            }
            if (label2.Visible == false)
            {
                label3.ForeColor = Color.Red;
            }
            if (label3.Visible == false)
            {
                label4.ForeColor = Color.Red;
            }
            if (label4.Visible == false)
            {
                label5.ForeColor = Color.Red;
            }
            if (label5.Visible == false)
            {
                label6.ForeColor = Color.Red;
            }
            if (label6.Visible == false)
            {
                label7.ForeColor = Color.Red;
            }
            if (label7.Visible == false)
            {
                label8.ForeColor = Color.Red;
            }
            if (label8.Visible == false)
            {
                label9.ForeColor = Color.Red;
            }
            if (label9.Visible == false)
            {
                label10.ForeColor = Color.Red;
            }
            if (label10.Visible == false)
            {
                label11.ForeColor = Color.Red;
            }
            if (label11.Visible == false)
            {
                label12.ForeColor = Color.Red;
            }
            if (label12.Visible == false)
            {
                label13.ForeColor = Color.Red;
            }
            if (label13.Visible == false)
            {
                label14.ForeColor = Color.Red;
            }
            if (label14.Visible == false)
            {
                label15.ForeColor = Color.Red;
            }
            if (label15.Visible == false)
            {
                label16.ForeColor = Color.Red;
            }
            if (label16.Visible == false)
            {
                label17.ForeColor = Color.Red;
            }
            if (label17.Visible == false)
            {
                label18.ForeColor = Color.Red;
            }
            if (label18.Visible == false)
            {
                label19.ForeColor = Color.Red;
            }
            if (label19.Visible == false)
            {
                label20.ForeColor = Color.Red;
            }
            if (label20.Visible == false)
            {
                label21.ForeColor = Color.Red;
            }
            if (label21.Visible == false)
            {
                label22.ForeColor = Color.Red;
            }
            if (label22.Visible == false)
            {
                label23.ForeColor = Color.Red;
            }
            if (label23.Visible == false)
            {
                label24.ForeColor = Color.Red;
            }
            if (label24.Visible == false)
            {
                label25.ForeColor = Color.Red;
            }
            if (label25.Visible == false)
            {
                label26.ForeColor = Color.Red;
            }
        }

        private void frmSpeedTestABC_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (strcmbTestABC == "A->Z")
            {
                if (e.KeyChar == 'a')
                {
                    label1.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'b' && (label1.Visible == false))
                {
                    label2.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'c' && (label2.Visible == false))
                {
                    label3.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'd' && (label3.Visible == false))
                {
                    label4.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'e' && (label4.Visible == false))
                {
                    label5.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'f' && (label5.Visible == false))
                {
                    label6.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'g' && (label6.Visible == false))
                {
                    label7.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'h' && (label7.Visible == false))
                {
                    label8.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'i' && (label8.Visible == false))
                {
                    label9.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'j' && (label9.Visible == false))
                {
                    label10.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'k' && (label10.Visible == false))
                {
                    label11.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'l' && (label11.Visible == false))
                {
                    label12.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'm' && (label12.Visible == false))
                {
                    label13.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'n' && (label13.Visible == false))
                {
                    label14.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'o' && (label14.Visible == false))
                {
                    label15.Visible = false;
                    ChangeColorLabel();
                }

                if (e.KeyChar == 'p' && (label15.Visible == false))
                {
                    label16.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'q' && (label16.Visible == false))
                {
                    label17.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'r' && (label17.Visible == false))
                {
                    label18.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 's' && (label18.Visible == false))
                {
                    label19.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 't' && (label19.Visible == false))
                {
                    label20.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'u' && (label20.Visible == false))
                {
                    label21.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'v' && (label21.Visible == false))
                {
                    label22.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'w' && (label22.Visible == false))
                {
                    label23.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'x' && (label23.Visible == false))
                {
                    label24.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'y' && (label24.Visible == false))
                {
                    label25.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == 'z' && (label25.Visible == false))
                {
                    label26.Visible = false;
                    timer1.Stop();
                    GameOver();
                    btnChoiLai.Visible = true;
                    frmSpeedTestABC_Load_Begin(sender, e);

                }
            }

            if (strcmbTestABC == "0->9"|| strcmbTestABC== "Random(~!@#$)")
            {
                if (e.KeyChar == Convert.ToChar( label1.Text))
                {
                    label1.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label2.Text) && (label1.Visible == false))
                {
                    label2.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label3.Text) && (label2.Visible == false))
                {
                    label3.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label4.Text) && (label3.Visible == false))
                {
                    label4.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label5.Text) && (label4.Visible == false))
                {
                    label5.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label6.Text) && (label5.Visible == false))
                {
                    label6.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label7.Text) && (label6.Visible == false))
                {
                    label7.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label8.Text) && (label7.Visible == false))
                {
                    label8.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label9.Text) && (label8.Visible == false))
                {
                    label9.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label10.Text) && (label9.Visible == false))
                {
                    label10.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label11.Text) && (label10.Visible == false))
                {
                    label11.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label12.Text) && (label11.Visible == false))
                {
                    label12.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label13.Text) && (label12.Visible == false))
                {
                    label13.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label14.Text) && (label13.Visible == false))
                {
                    label14.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label15.Text) && (label14.Visible == false))
                {
                    label15.Visible = false;
                    ChangeColorLabel();
                }

                if (e.KeyChar == Convert.ToChar(label16.Text) && (label15.Visible == false))
                {
                    label16.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label17.Text) && (label16.Visible == false))
                {
                    label17.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label18.Text) && (label17.Visible == false))
                {
                    label18.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label19.Text) && (label18.Visible == false))
                {
                    label19.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label20.Text) && (label19.Visible == false))
                {
                    label20.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label21.Text) && (label20.Visible == false))
                {
                    label21.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label22.Text) && (label21.Visible == false))
                {
                    label22.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label23.Text) && (label22.Visible == false))
                {
                    label23.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label24.Text) && (label23.Visible == false))
                {
                    label24.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label25.Text) && (label24.Visible == false))
                {
                    label25.Visible = false;
                    ChangeColorLabel();
                }
                if (e.KeyChar == Convert.ToChar(label26.Text) && (label25.Visible == false))
                {
                    label26.Visible = false;
                    timer1.Stop();
                    GameOver();
                    btnChoiLai.Visible = true;
                    frmSpeedTestABC_Load_Begin(sender, e);
                }

            }

        }

        private void frmSpeedTestABC_Load_ABC(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label1.Text = "a";
            label2.Text = "b";
            label3.Text = "c";
            label4.Text = "d";
            label5.Text = "e";
            label6.Text = "f";
            label7.Text = "g";
            label8.Text = "h";
            label9.Text = "i";
            label10.Text = "j";
            label11.Text = "k";
            label12.Text = "l";
            label13.Text = "m";
            label14.Text = "n";
            label15.Text = "o";
            label16.Text = "p";
            label17.Text = "q";
            label18.Text = "r";
            label19.Text = "s";
            label20.Text = "t";
            label21.Text = "u";
            label22.Text = "v";
            label23.Text = "w";
            label24.Text = "x";
            label25.Text = "y";
            label26.Text = "z";
        }

        private void frmSpeedTestABC_Load_Random(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label1.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label2.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label3.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label4.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label5.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label6.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label7.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label8.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label9.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label10.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label11.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label13.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label12.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label14.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label15.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label16.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label17.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label18.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label19.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label20.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label21.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label22.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label23.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label24.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label25.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
            label26.Text = Convert.ToChar(rd.Next(34, 47)).ToString();
           
        }

        private void frmSpeedTestABC_Load_09(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label1.Text = rd.Next(0, 9).ToString();
            label2.Text = rd.Next(0, 9).ToString();
            label3.Text = rd.Next(0, 9).ToString();
            label4.Text = rd.Next(0, 9).ToString();
            label5.Text = rd.Next(0, 9).ToString();
            label6.Text = rd.Next(0, 9).ToString();
            label7.Text = rd.Next(0, 9).ToString();
            label8.Text = rd.Next(0, 9).ToString();
            label9.Text = rd.Next(0, 9).ToString();
            label10.Text = rd.Next(0, 9).ToString();
            label11.Text = rd.Next(0, 9).ToString();
            label12.Text = rd.Next(0, 9).ToString();
            label13.Text = rd.Next(0, 9).ToString();
            label14.Text = rd.Next(0, 9).ToString();
            label15.Text = rd.Next(0, 9).ToString();
            label16.Text = rd.Next(0, 9).ToString();
            label17.Text = rd.Next(0, 9).ToString();
            label18.Text = rd.Next(0, 9).ToString();
            label19.Text = rd.Next(0, 9).ToString();
            label20.Text = rd.Next(0, 9).ToString();
            label21.Text = rd.Next(0, 9).ToString();
            label22.Text = rd.Next(0, 9).ToString();
            label23.Text = rd.Next(0, 9).ToString();
            label24.Text = rd.Next(0, 9).ToString();
            label25.Text = rd.Next(0, 9).ToString();
            label26.Text = rd.Next(0, 9).ToString();
        }

        private void frmSpeedTestABC_Load_Start(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmSpeedTestABC_Load_Begin(object sender, EventArgs e)
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

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            label19.ForeColor = Color.Black;
            label20.ForeColor = Color.Black;
            label21.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            label23.ForeColor = Color.Black;
            label24.ForeColor = Color.Black;
            label25.ForeColor = Color.Black;
            label26.ForeColor = Color.Black;

        }

        private void GameOver()
        {
            if(strcmbTestABC=="A->Z")
            {
                if (minutes == 0)
                {
                    MessageBox.Show("Thời gian bạn đánh hết chữ cái trên bàn phím từ a->z là " + lblSenconds.Text + " giây", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Thời gian bạn đánh hết chữ cái trên bàn phím từ a->z là " + lblMinute.Text + " phút " + lblSenconds.Text + "giây", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            if (strcmbTestABC == "0->9")
            {
                if (minutes == 0)
                {
                    MessageBox.Show("Thời gian bạn đánh hết chữ cái trên bàn phím từ 0->9 là " + lblSenconds.Text + " giây", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Thời gian bạn đánh hết chữ cái trên bàn phím từ 0->9 là " + lblMinute.Text + " phút " + lblSenconds.Text + "giây", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000;
            seconds++;
            if (seconds <= 59)
            {
                if (seconds <= 9)
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
                if (minutes <= 9)
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
            this.Focus();
            frmSpeedTestABC_Load_Start(sender, e);
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

        private void btnChoi_Click(object sender, EventArgs e)
        {
            timer1.Start();
            frmSpeedTestABC_Load_Start(sender, e);
            btnChoi.Visible = false;
        }

    }
}
