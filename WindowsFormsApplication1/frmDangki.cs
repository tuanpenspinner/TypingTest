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
    public partial class frmDangki : Form
    {
        public frmDangki()
        {
            InitializeComponent();
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            List<Account> Accounts = new List<Account>();
            StreamReader read = new StreamReader("Account.txt");
           
            String s;

            while ((s = read.ReadLine()) != null)
            {
                string[] line = s.Split('-');
               
                if (s != "")
                {
                    Account account = new Account();
                    account.UseName = line[0];
                    account.PassWord = line[1];
                    Accounts.Add(account);
                }
                
            }
            bool kt = true;

            for (int i = 0; i < Accounts.Count; i++)
            {
                if (txtUsename.Text == Accounts[i].UseName)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại,nhập tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kt = false;
                    txtUsename.Focus();
                    read.Close();
                    return;
                }
            }
            read.Close();
 
            if (kt)
            {
                if (txtPassword.Text != txtPasswordagaint.Text)
                {
                    MessageBox.Show("Pass word không khớp vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    kt = false;
                    read.Close();
                    return;
                }
            }
            StreamWriter write = new StreamWriter("Account.txt", true);

            write.WriteLine(txtUsename.Text+'-'+txtPassword.Text+'\n');
            MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUsename.Text = "";
            txtPassword.Text= "";
            txtPasswordagaint.Text = "";
            txtUsename.Focus();

            write.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}