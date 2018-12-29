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
    public partial class frmFlappyBird : Form
    {
        Database Db = new Database();
        int maxPoint=0;
        string UseName;
        int xCot1, xCot2, xCot3;
        int yCotTren1, yCotTren2, yCotTren3;
        int yCotDuoi1, yCotDuoi2, yCotDuoi3;
        int KhoangCach2Thanh=250;
        int KhoangCach2Cot=200;
        int yBird = 200;
        int xBird = 400;
        int Point = 0;

        public frmFlappyBird()
        {
            InitializeComponent();
        }

        private void frmFlappyBird_KeyPress(object sender, KeyPressEventArgs e)
        {

            char[] c = lblBird.Text.ToCharArray();
            if (e.KeyChar == c[0])
            {
                yBird -= 30;
                lblBird.Location = new Point(400, yBird);
                char[] c1 = txtTu.Text.ToCharArray();
                char[] c2 = txtDen.Text.ToCharArray();
                Random rd = new Random();
                int a = Convert.ToInt32(c1[0]);
                int b = Convert.ToInt32(c2[0]);

                lblBird.Text = Convert.ToString((char)rd.Next(a, b+1));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            yBird++;
            lblBird.Location = new Point(400, yBird);
        }
    
        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            frmFlappyBird_Load(sender, e);
            frmFlappyBird_Load_2(sender, e);
            if (txtTu.Text != "" && txtDen.Text != "")
            {

                btnChoiLai.Visible = false;
                char[] c1 = txtTu.Text.ToCharArray();
                char[] c2 = txtDen.Text.ToCharArray();
                Random rd1 = new Random();
                int a = Convert.ToInt32(c1[0]);
                int b = Convert.ToInt32(c2[0]);
                lblBird.Text = Convert.ToString((char)rd1.Next(a, b+1));
                lblBird.Focus();
                timer1.Start();
                timer.Start();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ từ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblBird.Focus();
            }

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            frmFlappyBird_Load_2(sender, e);
            frmFlappyBird_Load(sender, e);
            Random rd1 = new Random();
            int a = 0;
            int b = 0;
            char[] c1 = txtTu.Text.ToCharArray();
            char[] c2 = txtDen.Text.ToCharArray();
            a = Convert.ToInt32(c1[0]);
            b = Convert.ToInt32(c2[0]);

            if (txtTu.Text == "" || txtDen.Text == ""||txtDen.Text.Length>=2||txtTu.Text.Length>=2||a>b)
            {
                MessageBox.Show("Lỗi nhập từ khi chơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblBird.Focus();
            }

            else
            {
                btnBatDau.Visible = false;
                btnChoiLai.Visible = false;
                btnBatDau.Enabled = false;

                lblBird.Text = Convert.ToString((char)rd1.Next(a, b + 1));
                lblBird.Focus();
                timer1.Start();
                timer.Start();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void frmFlappyBird_Load(object sender, EventArgs e)
        {
            if (strLevel == "Easy")
            {
                KhoangCach2Thanh =450;
                KhoangCach2Cot = 210;
            }

            if (strLevel == "Medium")
            {
                KhoangCach2Thanh = 350;
                KhoangCach2Cot = 210;
            }
            if (strLevel == "Hard")
            {
                KhoangCach2Thanh = 250;
                KhoangCach2Cot = 200;
            }

            Db.Connection();

            UseName = Db.GetAcountUsing(Db.Connec);

            maxPoint = Db.MaxScoreFlappyBird(Db.Connec, UseName);
            if (maxPoint >= 10)
            {
                lblMaxPoint.Text = maxPoint + "";
            }
            else
            {
                lblMaxPoint.Text = "0" + maxPoint;
            }

            Db.Connec.Close();
        }

        private void frmFlappyBird_Load_1(object sender, EventArgs e)
        {
            Database Db = new Database();
            Db.Connection();
            lblUseName.Text = Db.GetAcountUsing(Db.Connec);

            frmFlappyBird_Load(sender, e);
            yBird = 200;
            xBird = 400;

            this.KeyPreview = false;
            char[] c1 = txtTu.Text.ToCharArray();
            char[] c2 = txtDen.Text.ToCharArray();
            Random rd1 = new Random();
            int a = Convert.ToInt32(c1[0]);
            int b = Convert.ToInt32(c2[0]);
            lblBird.Text = Convert.ToString((char)rd1.Next(100, 100));
            lblBird.Location = new Point(xBird, yBird);

            xCot1 = 900;
            xCot2 = xCot1 + lblCotTren1.Width + KhoangCach2Thanh;
            xCot3 = xCot2 + lblCotTren1.Width + KhoangCach2Thanh;

            Random rd = new Random();
            yCotTren1 = rd.Next(-lblCotTren1.Height + KhoangCach2Cot + 10, 0);
            yCotTren2 = rd.Next(-lblCotTren1.Height + KhoangCach2Cot + 10, 0);
            yCotTren3 = rd.Next(-lblCotTren1.Height + KhoangCach2Cot + 10, 0);

            yCotDuoi1 = lblCotDuoi1.Height + KhoangCach2Cot + yCotTren1;
            yCotDuoi2 = lblCotDuoi1.Height + KhoangCach2Cot + yCotTren2;
            yCotDuoi3 = lblCotDuoi1.Height + KhoangCach2Cot + yCotTren3;
            //Cột 1
            lblCotTren1.Location = new Point(xCot1, yCotTren1);
            lblCotDuoi1.Location = new Point(xCot1, yCotDuoi1);
            //Cột 2
            lblCotTren2.Location = new Point(xCot2, yCotTren2);
            lblCotDuoi2.Location = new Point(xCot2, yCotDuoi2);
            //Cột 3
            lblCotTren3.Location = new Point(xCot3, yCotTren3);
            lblCotDuoi3.Location = new Point(xCot3, yCotDuoi3);
        }

        private void frmFlappyBird_Load_2(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }
  
        private void GameOver()
        {
            MessageBox.Show("Bạn được số điểm là " + lblPoint.Text + " điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (Point > maxPoint)
            {
                Db.Connection();
                Db.SaveMaxFlappyBird(Db.Connec, UseName, Point);
                Point = 0;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1;
            this.KeyPreview = true;
            xCot1 -= 1;
            xCot2 -= 1;
            xCot3 -= 1;
            //Cột 1
            lblCotTren1.Location = new Point(xCot1, yCotTren1);
            lblCotDuoi1.Location = new Point(xCot1, yCotDuoi1);
            //Cột 2
            lblCotTren2.Location = new Point(xCot2, yCotTren2);
            lblCotDuoi2.Location = new Point(xCot2, yCotDuoi2);
            //Cột 3
            lblCotTren3.Location = new Point(xCot3, yCotTren3);
            lblCotDuoi3.Location = new Point(xCot3, yCotDuoi3);

            if (xCot1 <= 0 - lblCotTren1.Width)
            {
                Random rd1 = new Random();
                yCotTren1 = rd1.Next(-lblCotTren1.Height+40, 0);
                yCotDuoi1 = lblCotDuoi1.Height + KhoangCach2Cot + yCotTren1;

                xCot1 = xCot3 + KhoangCach2Thanh + lblCotTren1.Width;

                lblCotTren1.Location = new Point(xCot1, yCotTren1);
                lblCotDuoi1.Location = new Point(xCot1, yCotDuoi1);

            }
            if (xCot2 <= 0 - lblCotTren1.Width)
            {
                Random rd1 = new Random();
                yCotTren2 = rd1.Next(-lblCotTren1.Height + 40, 0);
                yCotDuoi2 = lblCotDuoi2.Height + KhoangCach2Cot + yCotTren2;

                xCot2 = xCot1 + KhoangCach2Thanh + lblCotTren1.Width;

                lblCotTren2.Location = new Point(xCot2, yCotTren2);
                lblCotDuoi2.Location = new Point(xCot2, yCotDuoi2);

            }
            if (xCot3 <= 0 - lblCotTren1.Width)
            {
                Random rd1 = new Random();
                yCotTren3 = rd1.Next(-lblCotTren1.Height + 40, 0);
                yCotDuoi3 = lblCotDuoi1.Height + KhoangCach2Cot + yCotTren3;

                xCot3 = xCot2 + KhoangCach2Thanh + lblCotTren1.Width;
                lblCotTren3.Location = new Point(xCot1, yCotTren3);
                lblCotDuoi3.Location = new Point(xCot1, yCotDuoi3);

            }
            if (yBird + lblBird.Height >= 455)
            {
                timer1.Stop();
                timer.Stop();
                GameOver();
                frmFlappyBird_Load_1(sender, e);
                btnChoiLai.Visible = true;
                lblPoint.Text = "00";
            }
            if (xCot1 <= xBird + lblBird.Width && (xCot1 + lblCotTren1.Width) >= xBird)
            {
                if (yBird <= (lblCotTren1.Height + yCotTren1) || yBird + lblBird.Height >= yCotDuoi1)
                {
                    timer.Stop();
                    timer1.Stop();
                    GameOver();
                    frmFlappyBird_Load_1(sender, e);
                    btnChoiLai.Visible = true;
                    lblPoint.Text = "00";
                }
            }
            if (xCot3 <= xBird + lblBird.Width && (xCot3 + lblCotTren3.Width) >= xBird)
            {
                if (yBird <= (lblCotTren3.Height + yCotTren3) || yBird + lblBird.Height >= yCotDuoi3)
                {
                    timer.Stop();
                    timer1.Stop();
                    GameOver();
                    frmFlappyBird_Load_1(sender, e);
                    btnChoiLai.Visible = true;
                    lblPoint.Text = "00";
                }
            }
            if (xCot2 <= xBird + lblBird.Width && (xCot2 + lblCotTren2.Width) >= xBird)
            {
                if (yBird <= (lblCotTren2.Height + yCotTren2) || yBird + lblBird.Height >= yCotDuoi2)
                {
                    timer1.Stop();
                    timer.Stop();
                    GameOver();
                    frmFlappyBird_Load_1(sender, e);
                    btnChoiLai.Visible = true;
                    lblPoint.Text = "00";
                }
            }


            if (yBird <=0)
            {
                timer1.Stop();
                timer.Stop();
                GameOver();
                frmFlappyBird_Load_1(sender, e);
                btnChoiLai.Visible = true;
                lblPoint.Text = "00";
            }

            if (xBird==xCot1||xBird==xCot2||xBird==xCot3)
            {
              
                Point++;
                if (Point < 10)
                {
                    lblPoint.Text = "0"+Point;
                }
                else
                {
                    lblPoint.Text = "" + Point;
                }
            }

        }
    }
}
