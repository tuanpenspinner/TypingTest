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

    public partial class frmMenu : Form
    {
        Database Db = new Database();

        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnTestABC_Click(object sender, EventArgs e)
        {
            if (cmbTestABC.Text != "")
            {
                this.Dispose();
                frmIntroduce frm = new frmIntroduce();
                frm.strcmbTestABC = cmbTestABC.SelectedItem.ToString();
                frm.IDGame = 1;
                frm.ShowDialog();
            }
            btnTextPractice.Visible = false;
            cmbTestABC.Visible = true;
            cmbTextPractice.Visible = false;
        }

        private void btnTextPractice_Click(object sender, EventArgs e)
        {

            cmbTextPractice.Visible = true;

            if (cmbTextPractice.Text != "")
            {
                this.Dispose();
                frmIntroduce frm = new frmIntroduce();
                frm.strTime = cmbTextPractice.SelectedItem.ToString();
                frm.IDGame = 2;
                frm.ShowDialog();
            }
        }

        private void btnFlappyBird_Click(object sender, EventArgs e)
        {
            if (cmbGame.Text != "")
            {
                this.Dispose();
                frmIntroduce frm = new frmIntroduce();
                frm.strLevel = cmbGame.SelectedItem.ToString();
                frm.IDGame = 3;
                frm.ShowDialog();
            }
        }

        private void btnEggDrop_Click(object sender, EventArgs e)
        {
            if (cmbGame.Text != "")
            {
                frmIntroduce frm = new frmIntroduce();
                frm.strLevel = cmbGame.SelectedItem.ToString();
                this.Dispose();
                frm.IDGame = 4;
                frm.ShowDialog();
            }

        }

        private void btnCharFallOut_Click(object sender, EventArgs e)
        {
            if (cmbGame.Text != "")
            {
                this.Dispose();
                frmIntroduce frm = new frmIntroduce();
                frm.strLevel = cmbGame.SelectedItem.ToString();
                frm.IDGame = 5;
                frm.ShowDialog();
            }

        }

        private void btnBlockDrop_Click(object sender, EventArgs e)
        {
            if (cmbGame.Text != "")
            {
                this.Dispose();
                frmIntroduce frm = new frmIntroduce();
                frm.strLevel = cmbGame.SelectedItem.ToString();
                frm.IDGame = 6;
                frm.ShowDialog();
            }

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            Database Db = new Database();
            Db.Connection();
            cmbGame.SelectedIndex = 0;
          
            lblUseName.Text = Db.GetAcountUsing(Db.Connec);
            lblLevel.Visible = false;
            btnCharFallOut.Visible = false;
            btnFlappyBird.Visible = false;
            btnEggDrop.Visible = false;
            btnTestABC.Visible = false;
            cmbGame.Visible = false;
            btnTextPractice.Visible = false;
            btnBlockDrop.Visible = false;
            cmbTestABC.Visible = false;
            cmbTextPractice.Visible = false;

            Db.Connec.Close();
        }

        private void btnSpeedTest_Click(object sender, EventArgs e)
        {
            cmbTestABC.Visible = false;
            btnTestABC.Visible = true;
            btnTextPractice.Visible = true;
            cmbTextPractice.Visible = false;

            lblLevel.Visible = false;
            cmbGame.Visible = false;
            btnBlockDrop.Visible = false;
            btnEggDrop.Visible = false;
            btnCharFallOut.Visible = false;
            btnFlappyBird.Visible = false;

        }

        private void btnTyPingGame_Click(object sender, EventArgs e)
        {
            cmbTestABC.Visible = false;
            btnTestABC.Visible = false;
            btnTextPractice.Visible = false;
            cmbTextPractice.Visible = false;

            lblLevel.Visible = true;
            cmbGame.Visible = true;
            btnBlockDrop.Visible = true;
            btnEggDrop.Visible = true;
            btnCharFallOut.Visible = true;
            btnFlappyBird.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmScore frm = new frmScore();
            frm.ShowDialog();
        }



   

    }

}
