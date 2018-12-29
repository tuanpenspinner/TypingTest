﻿using System;
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
        int second = 60;
        int dem = 0;
        int length = 0;
        Database Db = new Database();

        public frmTypingTest()
        {
            InitializeComponent();
        }

        public void closeForm()
        {
            this.Dispose();
        }

        private void frmTypingTest_Load(object sender, EventArgs e)
        {
            Db.Connection();
            btnChoiLai.Visible = false;
            txtTyping.Enabled = false;
            string SQL="SELECT * FROM TbTypingTest WHERE NameSong='Thằng điên'";
            OleDbCommand cmd = new OleDbCommand(SQL, Db.Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtTest.Text = dr["Lyrics"].ToString();
            }
   
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnChoiLai.Visible = true;
            txtTyping.Enabled = true;
            txtTyping.Focus();
            TimerStart.Start();
        }
       
        private void TimerStart_Tick(object sender, EventArgs e)
        {
            TimerStart.Interval = 1000;
            lblMinute.Text = "00";
            second--;
            lblSecond.Text = "" + second;
            if(second==0)
            {
                 TimerStart.Stop();
                btnChoiLai.Visible = true;
                
                string[] Test = txtTest.Text.Trim().Split(' ');
                string[] Typing = txtTyping.Text.Split(' ');
                string s = txtTyping.Text;
                foreach (char c in s) if (c == ' ') length++;
              
                for(int i=0;i<=length;i++)
                {
                    if (Test[i]==Typing[i])dem++;

                }
                MessageBox.Show("Bạn đã đúng số câu là "+dem,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btnStart.Visible = false;
                txtTyping.Enabled = false;
                btnChoiLai.Visible = true;
                txtTyping.Text = "";

                second = 60;
                length = 0;
                dem = 0;
                lblMinute.Text = "01";
                lblSecond.Text = "00";
            }
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            second = 60;
            length = 0;
            dem = 0;
            lblMinute.Text = "01";
            lblSecond.Text = "00";
            txtTyping.Text = "";
            txtTyping.Enabled = true;
            txtTyping.Focus();
            TimerStart.Start();
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void lblMinute_Click(object sender, EventArgs e)
        {

        }
    }
}
