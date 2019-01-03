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
    public partial class frmIntroduce : Form
    {
        public frmIntroduce()
        {
            InitializeComponent();
        }
        Database Db = new Database();
        private void frmIntroduce_Load(object sender, EventArgs e)
        {
            Db.Connection();
            string introduce = Db.Introduce(Db.Connec, IDGame);
            lblHuongDan.Visible = true;
            lblHuongDan.Text = introduce;

            Db.Connec.Close();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            switch (IDGame)
            {
                case 1:
                    {
                        this.Dispose();
                        frmSpeedTestABC frm = new frmSpeedTestABC();
                        frm.strcmbTestABC = strcmbTestABC;
                        frm.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        this.Dispose();
                        frmTypingTest frm = new frmTypingTest();
                        frm.strTime = strTime;
                        frm.ShowDialog();
                        break;
                    }
                case 3:
                    {
                        this.Dispose();
                        frmFlappyBird frm = new frmFlappyBird();
                        frm.strLevel = strLevel;
                        frm.ShowDialog();
                        break;

                    }
                case 4:
                    {
                        this.Dispose();
                        frmEggDrop frm = new frmEggDrop();
                        frm.strLevel = strLevel;
                        frm.ShowDialog();
                        break;
                    }
                case 5:
                    {
                        this.Dispose();
                        frmCharFallOut frm = new frmCharFallOut();
                        frm.strLevel = strLevel;
                        frm.ShowDialog();
                        break;
                    }

                case 6:
                    {
                        this.Dispose();
                        frmBlockDrop frm = new frmBlockDrop();
                        frm.strLevel = strLevel;
                        frm.ShowDialog();
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
    }
}
