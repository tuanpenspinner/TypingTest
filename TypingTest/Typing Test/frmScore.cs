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
            Database Db = new Database();
            Db.Connection();
            string UseName;
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
           

            lblUseName.Text = Db.GetAcountUsing(Db.Connec);

            Db.Connec.Close();
        }
    }
}
