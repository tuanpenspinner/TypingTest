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

        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnTestABC_Click(object sender, EventArgs e)
        {
            if (cmbTestABC.Text != "")
            {
                this.Dispose();
                frmSpeedTestABC frm = new frmSpeedTestABC();
                frm.strcmbTestABC = cmbTestABC.SelectedItem.ToString();
                frm.ShowDialog();
            }
            btnTextPractice.Visible = false;
            cmbTestABC.Visible = true;
        }

        private void btnTextPractice_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmTypingTest frm = new frmTypingTest();
            frm.ShowDialog();

        }

        private void btnFlappyBird_Click(object sender, EventArgs e)
        {
            if (cmbGame.Text != "")
            {
               
                this.Dispose();
                frmFlappyBird frm = new frmFlappyBird();
                frm.strLevel = cmbGame.SelectedItem.ToString();
                frm.ShowDialog();
            }           
        }

        private void btnCharFallOut_Click(object sender, EventArgs e)
        {
            if (cmbGame.Text != "")
            {
                this.Dispose();
                frmCharFallOut frm = new frmCharFallOut();
                frm.strLevel = cmbGame.SelectedItem.ToString();
                frm.ShowDialog();
            }
           
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Database Db = new Database();
            Db.Connection();
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
        }

        private void btnSpeedTest_Click(object sender, EventArgs e)
        {
            cmbTestABC.Visible = false;
            btnTestABC.Visible = true;
            btnTextPractice.Visible = true;

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

        private void btnEggDrop_Click(object sender, EventArgs e)
        {
            if (cmbGame.Text != "")
            {
                this.Dispose();
                frmEggDrop frm = new frmEggDrop();
                frm.strLevel = cmbGame.SelectedItem.ToString();
                frm.ShowDialog();
            }
          
        }

        private void btnBlockDrop_Click(object sender, EventArgs e)
        {
            if (cmbGame.Text != "")
            {
                this.Dispose();
                frmBlockDrop frm = new frmBlockDrop();
                frm.strLevel = cmbGame.SelectedItem.ToString();
                frm.ShowDialog();
            }
           
        }
    }

}
