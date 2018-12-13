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
    public partial class frmLogin : Form
    {
        Database Db = new Database();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            frmDangki frm = new frmDangki();
            frm.ShowDialog();
        }
      
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text =="") lblPassWordNull.Visible = true;
            else lblPassWordNull.Visible = false;

            if (txtUsename.Text == "") lblUseNameNull.Visible = true;
            else lblUseNameNull.Visible = false;

          
            Db.Connection();
            
            string SQL = "SELECT UseName,PassWord FROM TbDataAccount WHERE UseName='" + txtUsename.Text + "' AND '" + txtPassword.Text + "'";
            string SQLRemmemberPassWord = "INSERT INTO TbRemmemberPassWord VALUES('" + txtUsename.Text + "' ,'" + txtPassword.Text + "')";
            string SQLUser = "INSERT INTO TbUser VALUES('" + txtUsename.Text + "' ,'" + txtPassword.Text + "')";
            string SQLREMOVEALL = "DELETE FROM TbRemmemberPassWord";
            string SQLREMOVEALLUser = "DELETE FROM TbUser";
            OleDbCommand Cmd = new OleDbCommand(SQL, Db.Connec);
            OleDbCommand Cmd1 = new OleDbCommand(SQLRemmemberPassWord, Db.Connec);
            OleDbCommand Cmd2 = new OleDbCommand(SQLREMOVEALL, Db.Connec);
            OleDbDataReader ReadDb = Cmd.ExecuteReader();
            if(ReadDb.Read())
            {
                Cmd2.ExecuteNonQuery();
                if (chkRememberPass.Checked)
                {
                    Cmd1.ExecuteNonQuery();

                }
                Cmd1 = new OleDbCommand(SQLUser, Db.Connec);
                Cmd2 = new OleDbCommand(SQLREMOVEALLUser, Db.Connec);
                Cmd1.ExecuteNonQuery();
                Cmd2.ExecuteNonQuery();

                Db.Connec.Close();
                lblFaillLogin.Visible = false;
                frmMenu frm = new frmMenu();
                frm.ShowDialog();
                this.Dispose();
            }
            else
            {
                lblFaillLogin.Visible = true;
            }

           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Db.Connection();
            string KT = "SELECT *FROM TbRemmemberPassWord";
            OleDbCommand cmd = new OleDbCommand(KT,Db.Connec);
            OleDbDataReader ReadDb = cmd.ExecuteReader();
            if(ReadDb.Read())
            {
                chkRememberPass.Checked = true;
                txtUsename.Text = (ReadDb["UseName"].ToString());
                txtPassword.Text = (ReadDb["PassWord"].ToString());
            }
            lblPassWordNull.Visible = false;
            lblUseNameNull.Visible = false;
            lblFaillLogin.Visible = false;
            Db.Connec.Close();

        }

   
    }
}
