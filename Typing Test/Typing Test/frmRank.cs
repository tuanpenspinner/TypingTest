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
            string UseName = Db.GetAcountUsing(Db.Connec);          
            lblUseName.Text = UseName;
            string sql;
            if (strName == "PointTestABC")
            {
                sql = "SELECT UseName , " + strName + " FROM TbDataAccount ORDER BY " + strName + " ASC ";
            }
            else
            {
                sql = "SELECT UseName , " + strName + " FROM TbDataAccount ORDER BY " + strName + " DESC ";
            }

            OleDbDataAdapter da = new OleDbDataAdapter(sql, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            dgvRank.DataSource = dt;

            for (int i = 0; i < dgvRank.Rows.Count; i++)
            {
                dgvRank.Rows[i].Cells[0].Value = i + 1;
            }
            int index = 0;
            for (int i = 0; i < dgvRank.Rows.Count; i++)
            {
                if (dgvRank.Rows[i].Cells[1].Value.ToString() == UseName)
                {
                    index = i; break;
                }
            }
            dgvRank.Rows[index].DefaultCellStyle.BackColor = Color.Yellow; dgvRank.Rows[0].Selected = false;
            Db.Connec.Close();
        }
    }
}
