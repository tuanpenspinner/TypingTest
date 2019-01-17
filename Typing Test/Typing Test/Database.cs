using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Database
    {
        public OleDbConnection Connec { get; set; }

        public void Connection()
        {
            string appPath = Application.StartupPath;
            string StringConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = "+appPath +"\\DataAccount.mdb";
            Connec = new OleDbConnection(StringConnection);
            if (Connec.State != ConnectionState.Open)
            {
                Connec.Open();
            }

        }
        public string GetAcountUsing(OleDbConnection Connec)
        {
            string UseName = "";
            string sql = "SELECT UseName FROM TbUser";
            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UseName = dr["UseName"].ToString() + "";

            }
            return UseName;
        }
                
        public int MaxScoreCharFallOut(OleDbConnection Connec, string UseName)
        {
            string maxscore = "";
            int max = 0;

            string sql = "SELECT* FROM TbDataAccount WHERE UseName='" + UseName + "'";

            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maxscore = dr["PointCharFallOut"].ToString();
                max = Convert.ToInt32(maxscore);
            }
            return max;
        }

        public void SaveMaxCharFallOut(OleDbConnection Connec, string UseName, int PointMax)
        {
            //string sql = "SELECT* FROM TbDataAccount WHERE UseName='" + UseName + "'";
            string sql = "UPDATE TbDataAccount SET PointCharFallOut= '" + PointMax + "' WHERE UseName='" + UseName + "'";
            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            cmd.ExecuteNonQuery();
        }

        public int MaxScoreFlappyBird(OleDbConnection Connec, string UseName)
        {
            string maxscore = "";
            int max = 0;

            string sql = "SELECT* FROM TbDataAccount WHERE UseName='" + UseName + "'";

            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maxscore = dr["PointFlappyBird"].ToString();
                max = Convert.ToInt32(maxscore);
            }
            return max;
        }

        public void SaveMaxFlappyBird(OleDbConnection Connec, string UseName, int PointMax)
        {
            string sql = "UPDATE TbDataAccount SET PointFlappyBird= '" + PointMax + "' WHERE UseName='" + UseName + "'";
            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            cmd.ExecuteNonQuery();
        }

        public int MaxScoreEggDrop(OleDbConnection Connec, string UseName)
        {
            string maxscore = "";
            int max = 0;

            string sql = "SELECT* FROM TbDataAccount WHERE UseName='" + UseName + "'";

            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maxscore = dr["PointEggDrop"].ToString();
                max = Convert.ToInt32(maxscore);
            }
            return max;
        }

        public void SaveMaxEggDrop(OleDbConnection Connec, string UseName, int PointMax)
        {
            string sql = "UPDATE TbDataAccount SET PointEggDrop= '" + PointMax + "' WHERE UseName='" + UseName + "'";
            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            cmd.ExecuteNonQuery();
        }

        public int MaxScoreBlockDrop(OleDbConnection Connec, string UseName)
        {
            string maxscore = "";
            int max = 0;

            string sql = "SELECT* FROM TbDataAccount WHERE UseName='" + UseName + "'";

            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maxscore = dr["PointBlockDrop"].ToString();
                max = Convert.ToInt32(maxscore);
            }
            return max;
        }

        public void SaveMaxBlockDrop(OleDbConnection Connec, string UseName, int PointMax)
        {
            string sql = "UPDATE TbDataAccount SET PointBlockDrop= '" + PointMax + "' WHERE UseName='" + UseName + "'";
            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            cmd.ExecuteNonQuery();
        }

        public int MaxScoreSpeedTestABC(OleDbConnection Connec, string UseName)
        {
            string maxscore = "";
            int max = 0;

            string sql = "SELECT* FROM TbDataAccount WHERE UseName='" + UseName + "'";

            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maxscore = dr["PointTestABC"].ToString();
                max = Convert.ToInt32(maxscore);
            }
            return max;
        }

        public void SaveMaxSpeedTestABC(OleDbConnection Connec, string UseName, int PointMax)
        {
            string sql = "UPDATE TbDataAccount SET PointTestABC= '" + PointMax + "' WHERE UseName='" + UseName + "'";
            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            cmd.ExecuteNonQuery();
        }

        public int MaxScoreTypingTest(OleDbConnection Connec, string UseName)
        {
            string maxscore = "";
            int max = 0;

            string sql = "SELECT* FROM TbDataAccount WHERE UseName='" + UseName + "'";

            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maxscore = dr["PointTypingTest"].ToString();
                max = Convert.ToInt32(maxscore);
            }
            return max;
        }

        public void SaveMaxSpeedTypingTest(OleDbConnection Connec, string UseName, int PointMax)
        {
            string sql = "UPDATE TbDataAccount SET PointTypingTest= '" + PointMax + "' WHERE UseName='" + UseName + "'";
            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            cmd.ExecuteNonQuery();
        }

        public void ResetScore(OleDbConnection Connec, string UseName)
        {
            int reset = 0;

            string sql = "UPDATE TbDataAccount SET PointTestABC='" + reset + "',PointFlappyBird='" + reset + "',PointEggDrop='" + reset + "' , PointCharFallOut='" + reset + "' , PointTypingTest='" + reset + "' , PointBlockDrop='" + reset + "' WHERE UseName='" + UseName + "'";
            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            cmd.ExecuteNonQuery();
        }

        public string Introduce(OleDbConnection Connec, int ID)
        {
            //Connec.Open();
            string Introduce="";
            string sql="SELECT * FROM TbHuongDan WHERE ID = "+ ID;

            OleDbCommand cmd = new OleDbCommand(sql, Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Introduce = dr["Introduce"].ToString();
            }
            //Connec.Close();
            return Introduce;
       
        }
        
    }
}

