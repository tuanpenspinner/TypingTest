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
    public partial class frmScore : Form
    {
        Database Db = new Database();
        string UseName;
        public frmScore()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            
            Db.Connection();
           
            UseName = Db.GetAcountUsing(Db.Connec);
          
            lblUseName.Text = Db.GetAcountUsing(Db.Connec);

            if(Db.MaxScoreCharFallOut(Db.Connec, UseName)>=10)
            {
                lblMaxPointCharFallOut.Text = Db.MaxScoreCharFallOut(Db.Connec, UseName).ToString();
            }
            else
            {
                lblMaxPointCharFallOut.Text = "0"+Db.MaxScoreCharFallOut(Db.Connec, UseName).ToString();
            }

            if(Db.MaxScoreEggDrop(Db.Connec, UseName)>=10)
            {
                lblMaxPointEggDrop.Text = Db.MaxScoreEggDrop(Db.Connec, UseName).ToString();
            }
            else
            {
                lblMaxPointEggDrop.Text = "0"+Db.MaxScoreEggDrop(Db.Connec, UseName).ToString();
            }
          
            if(Db.MaxScoreFlappyBird(Db.Connec, UseName)>=10)
            {
                lblMaxPointFlappyBird.Text = Db.MaxScoreFlappyBird(Db.Connec, UseName).ToString();
            }

            else
            {
                lblMaxPointFlappyBird.Text = "0"+Db.MaxScoreFlappyBird(Db.Connec, UseName).ToString();
            }

            if (Db.MaxScoreBlockDrop(Db.Connec, UseName) >= 10)
            {
                lblMaxPointBlockDrop.Text = Db.MaxScoreBlockDrop(Db.Connec, UseName).ToString();
            }

            else
            {
                lblMaxPointBlockDrop.Text = "0" + Db.MaxScoreBlockDrop(Db.Connec, UseName).ToString();
            }

            if (Db.MaxScoreTypingTest(Db.Connec, UseName) >= 10)
            {
                lblFastestSpeedTestPractice.Text = Db.MaxScoreTypingTest(Db.Connec, UseName).ToString();
            }

            else
            {
                lblFastestSpeedTestPractice.Text = "0" + Db.MaxScoreTypingTest(Db.Connec, UseName).ToString();
            }

            int MaxSpeed = Db.MaxScoreSpeedTestABC(Db.Connec, UseName);
            if (MaxSpeed >= 60)
            {
                lblMaxMinuteTestABC.Text = "0" + (MaxSpeed / 60);
                if (MaxSpeed % 60 >= 10)
                {
                    lblMaxSecondTestABC.Text = (MaxSpeed % 60).ToString();
                }

                else
                {
                    lblMaxSecondTestABC.Text = (MaxSpeed % 60) + "0";
                }

            }

            else
            {
                lblMaxMinuteTestABC.Text = "00";
                if (MaxSpeed >= 10)
                {
                    lblMaxSecondTestABC.Text = MaxSpeed.ToString();
                }

                else
                {
                    lblMaxSecondTestABC.Text = MaxSpeed + "0";
                }
            }

            Db.Connec.Close();
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            Db.Connection();
            Db.ResetScore(Db.Connec, UseName);
            frmScore_Load(sender, e);
            Db.Connec.Close();
        }

        private void btnRankTestABC_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmRank frm = new frmRank();
            frm.strName = "PointTestABC";
            frm.ShowDialog();
        }

        private void btnRankTestPractive_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmRank frm = new frmRank();
            frm.strName = "PointTypingTest";
            frm.ShowDialog();
        }

        private void btnRankCharFallOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmRank frm = new frmRank();
            frm.strName = "PointCharFallOut";
            frm.ShowDialog();
        }

        private void btnRankFlappyBird_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmRank frm = new frmRank();
            frm.strName = "PointFlappyBird";
            frm.ShowDialog();
        }

        private void btnRankEggDrop_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmRank frm = new frmRank();
            frm.strName = "PointEggDrop";
            frm.ShowDialog();
        }

        private void btnRankBlockDrop_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmRank frm = new frmRank();
            frm.strName = "PointBlockDrop";
            frm.ShowDialog();
        }
    }
}
