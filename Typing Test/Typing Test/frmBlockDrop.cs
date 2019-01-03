using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class frmBlockDrop : Form
    {
        Database Db = new Database();
        string UseName = "";
        int ylblMain = 75;
        int xlblMain = 444;
        int Dem = 1;
        int Point = 0;
        int MaxPoint;
        string[] str;
        Random rd = new Random();

        public frmBlockDrop()
        {
            InitializeComponent();
        }

        private void GetDataTbBlockDrop()
        {
            Db.Connection();
            string SQL = "SELECT * FROM TbBlockDrop";
            string strs = "";

            OleDbCommand cmd = new OleDbCommand(SQL, Db.Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                strs = dr["Animal"].ToString();
            }

            str = strs.Split(new char[] { '-' });

        }

        private void SetTextLabelMain()
        {
            lblMain.Text = str[rd.Next(0, str.Length)];
        }

        private void frmBlockDrop_Load(object sender, EventArgs e)
        {
            this.KeyPreview = false;
            GetDataTbBlockDrop();
            SetTextLabelMain();
            Db.Connection();
            UseName = Db.GetAcountUsing(Db.Connec);
            lblUseName.Text = UseName;
            MaxPoint = Db.MaxScoreBlockDrop(Db.Connec, UseName);
            if (MaxPoint >= 10)
            {
                lblMaxPoint.Text = MaxPoint + "";
            }

            else
            {
                lblMaxPoint.Text = "0" + MaxPoint;
            }
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lblMain.Visible = false;
            btnChoi.Visible = true;
            btnChoiLai.Visible = false;
            Db.Connec.Close();
        }

        private void frmBlockDrop_Load1(object sender, EventArgs e)
        {
            lblPoint.Text = "00";
            Db.Connection();

            MaxPoint = Db.MaxScoreBlockDrop(Db.Connec, UseName);
            if (MaxPoint >= 10)
            {
                lblMaxPoint.Text = MaxPoint + "";
            }

            else
            {
                lblMaxPoint.Text = "0" + MaxPoint;
            }

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lblMain.Visible = false;
            btnChoi.Visible = false;
            btnChoiLai.Visible = true;

            Db.Connec.Close();
        }

        private void frmBlockDrop_Load_KePreviewTrue(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmBlockDrop_Load_KePreviewFalse(object sender, EventArgs e)
        {
            this.KeyPreview = false;
        }

        private void btnChoi_Click(object sender, EventArgs e)
        {
            frmBlockDrop_Load_KePreviewTrue(sender, e);
            timer.Start();
            if (strLevel == "Easy")
            {
                timer.Interval = 1000;
            }

            if (strLevel == "Medium")
            {
                timer.Interval = 500;
            }
            if (strLevel == "Hard")
            {
                timer.Interval = 300;
            }
            lblMain.Visible = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
         
            ylblMain += lblMain.Height;

            lblMain.Location = new Point(xlblMain, ylblMain);
            switch (Dem)
            {
                case 1:
                    {
                        if (ylblMain > lbl1.Top)
                        {
                            lbl1.Visible = true;
                            lbl1.Text = lblMain.Text;
                            lblMain.Location = new Point(444, 75);
                            ylblMain = 75;
                            Dem++;
                            SetTextLabelMain();
                        }

                        break;
                    }
                case 2:
                    {

                        if (ylblMain > lbl2.Top)
                        {
                            lbl2.Visible = true;
                            lbl2.Text = lblMain.Text;
                            lblMain.Location = new Point(444, 75);
                            ylblMain = 75;
                            Dem++;
                            SetTextLabelMain();
                        }

                        break;
                    }

                case 3:
                    {
                        if (ylblMain > lbl3.Top)
                        {
                            lbl3.Visible = true;
                            lbl3.Text = lblMain.Text;
                            lblMain.Location = new Point(444, 75);
                            ylblMain = 75;
                            Dem++;
                            SetTextLabelMain();
                        }

                        break;
                    }

                case 4:
                    {
                        if (ylblMain > lbl4.Top)
                        {
                            lbl4.Visible = true;
                            lbl4.Text = lblMain.Text;
                            lblMain.Location = new Point(444, 75);
                            ylblMain = 75;
                            Dem++;
                            SetTextLabelMain();
                        }

                        break;
                    }

                case 5:
                    {
                        if (ylblMain > lbl5.Top)
                        {
                            lbl5.Visible = true;
                            lbl5.Text = lblMain.Text;
                            lblMain.Location = new Point(444, 75);
                            ylblMain = 75;
                            Dem++;
                            SetTextLabelMain();
                        }

                        break;
                    }

                case 6:
                    {
                        if (ylblMain > lbl6.Top)
                        {
                            lbl6.Visible = true;
                            lbl6.Text = lblMain.Text;
                            lblMain.Location = new Point(444, 75);
                            ylblMain = 75;
                            Dem++;
                            SetTextLabelMain();
                        }

                        break;
                    }

                case 7:
                    {
                        if (ylblMain > lbl7.Top)
                        {
                            lbl7.Visible = true;
                            lbl7.Text = lblMain.Text;
                            lblMain.Visible = false;
                            ylblMain = 75;
                            timer.Stop();
                            GameOver(sender, e);
                        }
                        break;

                    }

                default:
                    {
                        MessageBox.Show("Tuấn PenSpinner");
                        break;
                    }
            }
        }

        private void GameOver(object sender, EventArgs e)
        {
            frmBlockDrop_Load_KePreviewFalse(sender, e);
            MessageBox.Show("Bạn nhận được số điểm là: " + lblPoint.Text, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            lblMain.Visible = false;
            btnChoi.Visible = false;
            btnChoiLai.Visible = true;
            ylblMain = 75;
            xlblMain = 444;
            lblMain.Location = new Point(444, 75);

            if (Point > MaxPoint)
            {
                Db.Connection();
                Db.SaveMaxBlockDrop(Db.Connec, UseName, Point);
                Db.Connec.Close();
            }
            Point = 0;
            Dem = 1;

            frmBlockDrop_Load1(sender, e);
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            SetTextLabelMain();
            frmBlockDrop_Load_KePreviewTrue(sender, e);
            timer.Start();
            lblMain.Visible = true;
        }

        private void frmBlockDrop_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] c = lblMain.Text.ToCharArray();
            if (e.KeyChar == c[0])
            {
                string s = lblMain.Text;
                s = s.Substring(1, s.Length - 1);
                lblMain.Text = s;
                if (lblMain.Text == "")
                {
                    lblMain.Text = "Press Space!";

                }
            }
            else if (e.KeyChar == ' ' && lblMain.Text != "Press Space!")
            {
                switch (Dem)
                {
                    case 1:
                        {

                            lbl1.Visible = true;
                            lbl1.Text = lblMain.Text;
                            lblMain.Location = new Point(444, 75);
                            ylblMain = 75;
                            Dem++;
                            SetTextLabelMain();
                            break;
                        }
                    case 2:
                        {


                            {
                                lbl2.Visible = true;
                                lbl2.Text = lblMain.Text;
                                lblMain.Location = new Point(444, 75);
                                ylblMain = 75;
                                Dem++;
                                SetTextLabelMain();
                            }

                            break;
                        }

                    case 3:
                        {

                            {
                                lbl3.Visible = true;
                                lbl3.Text = lblMain.Text;
                                lblMain.Location = new Point(444, 75);
                                ylblMain = 75;
                                Dem++;
                                SetTextLabelMain();
                            }

                            break;
                        }

                    case 4:
                        {

                            {
                                lbl4.Visible = true;
                                lbl4.Text = lblMain.Text;
                                lblMain.Location = new Point(444, 75);
                                ylblMain = 75;
                                Dem++;
                                SetTextLabelMain();
                            }

                            break;
                        }

                    case 5:
                        {

                            {
                                lbl5.Visible = true;
                                lbl5.Text = lblMain.Text;
                                lblMain.Location = new Point(444, 75);
                                ylblMain = 75;
                                Dem++;
                                SetTextLabelMain();
                            }

                            break;
                        }

                    case 6:
                        {

                            {
                                lbl6.Visible = true;
                                lbl6.Text = lblMain.Text;
                                lblMain.Location = new Point(444, 75);
                                ylblMain = 75;
                                Dem++;
                                SetTextLabelMain();
                            }

                            break;
                        }

                    case 7:
                        {

                            {
                                lbl7.Visible = true;
                                lbl7.Text = lblMain.Text;
                                lblMain.Visible = false;
                                ylblMain = 75;
                                timer.Stop();
                                GameOver(sender, e);
                            }
                            break;

                        }
                }
            }
            else
            {
                if (e.KeyChar == ' ')
                {
                    Point++;
                    lblMain.Location = new Point(444, 75);
                    ylblMain = 75;
                    if (Point >= 10)
                    {
                        lblPoint.Text = Point + "";
                    }

                    else
                    {
                        lblPoint.Text = "0" + Point;
                    }
                    SetTextLabelMain();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }
    }
}


  