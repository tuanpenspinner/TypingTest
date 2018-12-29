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
    public partial class frmRank : Form
    {
        Database Db = new Database();
        public frmRank()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmScore frm = new frmScore();
            frm.ShowDialog();
        }

        private void frmRank_Load(object sender, EventArgs e)
        {
            Db.Connection();
            lblUseName.Text = Db.GetAcountUsing(Db.Connec);
            string sql = "SELECT UseName , " + strName + " FROM TbDataAccount ORDER BY " + strName + " DESC ";
        
            OleDbDataAdapter da = new OleDbDataAdapter(sql, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            dgvRank.DataSource = dt;

            for (int i = 0; i < dgvRank.Rows.Count; i++)
            {
                dgvRank.Rows[i].Cells[0].Value = i + 1;
            }

            Db.Connec.Close();
        }
    }
}
