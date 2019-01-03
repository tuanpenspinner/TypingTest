using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class frmTypingTest : Form
    {
        int second;
        int minute;
        int Word_Right = 0;
        string strFather;
        string[] strSon;
        int number = 0;
        string UseName = "";
        int FastestSpeed = 0;
        Database Db = new Database();

        public frmTypingTest()
        {
            InitializeComponent();
        }

        public void closeForm()
        {
            this.Dispose();
        }

        private void frmTypingTest_Load_KePreviewTrue(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmTypingTest_Load_KePreviewFalse(object sender, EventArgs e)
        {
            this.KeyPreview = false;
        }

        private void frmTypingTest_Load(object sender, EventArgs e)
        {
            Db.Connection();

            if (strTime == "1 minute")
            {
                minute = 1;
                second = 0;
            }
            if (strTime == "5 minute")
            {
                minute = 5;
                second = 0;
            }

            if (strTime == "10 minute")
            {
                minute = 10;
                second = 0;
            }
            if (minute >= 10)
            {
                lblMinute.Text = minute + "";
            }
            else
            {
                lblMinute.Text = "0" + minute;
            }

            Db.Connection();
            UseName = Db.GetAcountUsing(Db.Connec);
            lblUseName.Text = UseName;

            FastestSpeed = Db.MaxScoreTypingTest(Db.Connec, UseName);
            if (FastestSpeed >= 10)
            {
                lblFastestSpeed.Text = FastestSpeed + "";
            }
            else
            {
                lblFastestSpeed.Text = "0" + FastestSpeed;
            }

            frmTypingTest_Load_KePreviewFalse(sender, e);
            txtTypingTest.Focus();
            txtTypingTest.Clear();
            txtTypingTest.Enabled = false;
            btnChoiLai.Visible = false;

            string SQL = "SELECT NameSong FROM TbTypingTest";
            OleDbCommand cmd = new OleDbCommand(SQL, Db.Connec);
            OleDbDataAdapter da = new OleDbDataAdapter(SQL, Db.Connec);
            DataSet ds = new DataSet();
          
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            cmdTypingTest.DisplayMember = ds.Tables[0].Columns[0].ToString();
            cmdTypingTest.DataSource = ds.Tables[0];
            
            Db.Connec.Close();
        }

        private void frmTypingTest_Load_PlayAgaint(object sender, EventArgs e)
        {
            Db.Connection();
            FastestSpeed = Db.MaxScoreTypingTest(Db.Connec, UseName);
            if (FastestSpeed >= 10)
            {
                lblFastestSpeed.Text = FastestSpeed + "";
            }
            else
            {
                lblFastestSpeed.Text = "0" + FastestSpeed;
            }

            txtTypingTest.Enabled = false;
            txtTypingTest.Clear();
            lblTypingTest.Text = strSon[0];
            btnStart.Visible = false;
            btnChoiLai.Visible = true;
            number = 0;
            Word_Right = 0;
            if (strTime == "1 minute")
            {
                minute = 1;
                second = 0;
            }
            if (strTime == "5 minute")
            {
                minute = 5;
                second = 0;
            }

            if (strTime == "10 minute")
            {
                minute = 10;
                second = 0;
            }
            if (minute >= 10)
            {
                lblMinute.Text = minute + "";
            }
            else
            {
                lblMinute.Text = "0" + minute;
            }

            if (second >= 10)
            {
                lblSecond.Text = second + "";
            }
            else
            {
                lblSecond.Text = "0" + second;
            }


            Db.Connec.Close();
        }

        private void frmTypingTest_Load_Text(object sender, EventArgs e)
        {
            string[] Text = txtTypingTest.Text.Trim().Split(' ');
            string[] Label = lblTypingTest.Text.Split(' ');
            for (int i = 0; i < Text.Count(); i++)
            {
                if (Text[i] == Label[i]) Word_Right++;
            }
        }

        private void frmTypingTest_Load_Label(object sender, EventArgs e)
        {
            string[] Text = txtTypingTest.Text.Trim().Split(' ');
            string[] Label = lblTypingTest.Text.Split(' ');
            for (int i = 0; i < Text.Count(); i++)
            {
                if (Text[i] == Label[i]) Word_Right++;
            }
            frmTypingTest_Load_KePreviewTrue(sender, e);
            txtTypingTest.Clear();
            number++;
            lblTypingTest.Text = strSon[number];
        }

        private void GameOver(object sender, EventArgs e)
        {
            frmTypingTest_Load_Text(sender, e);
            Db.Connection();
 
            if (strTime == "5 minute")
            {
                Word_Right /= 5;
                Word_Right++;
            }

            if (strTime == "10 minute")
            {
                Word_Right /= 10;
                Word_Right++;
            }
            if (FastestSpeed < Word_Right)
            {
                Db.SaveMaxSpeedTypingTest(Db.Connec, UseName, Word_Right);
            }
            btnChoiLai.Visible = true;
            MessageBox.Show("Tốc độ gõ của bạn là " + Word_Right +" từ trên 1 phút " ,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            frmTypingTest_Load_PlayAgaint(sender, e);

            Db.Connec.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtTypingTest.Enabled = true;
            frmTypingTest_Load_KePreviewTrue(sender, e);
            txtTypingTest.Focus();
            btnStart.Visible = false;
            btnChoiLai.Visible = true;
            TimerStart.Start();
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            txtTypingTest.Enabled = true;
            txtTypingTest.Focus();
            TimerStart.Start();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            TimerStart.Interval = 100;

            if (second == 0 && minute >= 1)
            {
                minute--;
                second = 60;

            }
            if(second==0&&minute==0)
            {
                TimerStart.Stop();
                GameOver(sender, e);
                return;
            }
            second--;
            if(minute>=10)
            {
                lblMinute.Text = "" + minute;
            }
            else
            {
                lblMinute.Text = "0" + minute;
            }
           
            if(second>=10)
            {
                lblSecond.Text = "" + second;
            }
            else
            {
                lblSecond.Text = "0" + second;
            }
            
        }

        private void frmTypingTest_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                frmTypingTest_Load_Label(sender, e);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Db.Connection();
            string SQL = "SELECT * FROM TbTypingTest WHERE NameSong= '" + cmdTypingTest.Text + "' ";
            OleDbCommand cmd = new OleDbCommand(SQL, Db.Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                strFather = dr["Lyrics"].ToString();
            }
            strSon = strFather.Split('\n');
            lblTypingTest.Text = strSon[number];

            Db.Connec.Close();
           
        }
    }
}
