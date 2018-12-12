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
    public partial class frmDangki : Form
    {
        Database Db = new Database();
        public frmDangki()
        {
            InitializeComponent();
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            Db.Connection();
            bool KT=true ;
            if (txtPassword.Text == "")
            {
                lblPassWordNull.Visible = true;
                KT = false;
            }
            else
            {
                lblPassWordNull.Visible = false;
              
            }

            if (txtUsename.Text == "")
            {
                lblUseNameNull.Visible = true;
                KT = false;
            }
            else
            {
                lblUseNameNull.Visible = false;
           
            }

            if (txtPassword.Text != txtPasswordagaint.Text)
            {
                lblPassWordCompare.Visible = true;
                KT = false;
            }
            else
            {
                lblPassWordCompare.Visible = false;
             
            }

            if (KT)
            {
           
                string SQL1 = "INSERT INTO TbDataAccount VALUES('" + txtUsename.Text + "' ,'" + txtPassword.Text + "')";
                string SQL2 = "SELECT *FROM TbDataAccount WHERE UseName='" + txtUsename.Text + "'";
                OleDbCommand Cmd1 = new OleDbCommand(SQL2, Db.Connec);
                OleDbDataReader ReadDb = Cmd1.ExecuteReader();
                if(ReadDb.Read())
                {
                    lblUseNameInvalid.Visible = true;
                }
                else
                {
                    OleDbCommand Cmd2= new OleDbCommand(SQL1, Db.Connec);
                    Cmd2.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblUseNameInvalid.Visible = false;
                }  
                Db.Connec.Close();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmDangki_Load(object sender, EventArgs e)
        {
            lblPassWordNull.Visible = false;
            lblUseNameNull.Visible = false;
            lblPassWordCompare.Visible = false;
            lblUseNameInvalid.Visible = false;
        }
    }
}