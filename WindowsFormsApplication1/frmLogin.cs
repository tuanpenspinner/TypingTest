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

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader read = new StreamReader("RememberPass.txt");
            string ID = read.ReadLine();
            if (ID != null)
            {
                string[] id = ID.Split('-');
                txtPassword.Text = id[1];
                txtUsename.Text = id[0];
                read.Close();
                chkRememberPass.Checked = true;
            }
            read.Close();
        }

        private void btlDangNhap_Click(object sender, EventArgs e)
        {
           
            List<Account> Accounts = new List<Account>();
            StreamReader read = new StreamReader("Account.txt");
            String s; 

   
            while ((s = read.ReadLine()) != null)
            {
                string[] line = s.Split('-');
                if(s!="")
                {
                    Account account = new Account();
                    account.UseName = line[0];
                    account.PassWord = line[1];
                    Accounts.Add(account);
                }
 
            }
            bool Pass = false;
            for(int i=0;i<Accounts.Count;i++)
            {
                if(txtUsename.Text==Accounts[i].UseName &&
                    txtPassword.Text== Accounts[i].PassWord
                    )
                {
                   
                    Pass = true;
                }
                
            } 
       
            if(Pass)
            {

                if(chkRememberPass.Checked)
                {
                    StreamWriter write = new StreamWriter("RememberPass.txt");
                    write.Write(txtUsename.Text + "-" + txtPassword.Text);
                    write.Close();
                }
                else
                {
                    StreamWriter write = new StreamWriter("RememberPass.txt");
                    write.Write("");
                    write.Close();
                }
                this.Visible=false;
                frmMenu frm = new frmMenu();
                frm.ShowDialog();

            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác","Lỗi đăng nhập",MessageBoxButtons.OK,MessageBoxIcon.Error);
            read.Close();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            frmDangki frm = new frmDangki();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
