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
    public partial class frmEggDrop : Form
    {

        Database Db = new Database();
        int maxPoint = 0;
        string UseName;

        public frmEggDrop()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        int xEgg1, xEgg2, xEgg3, xEgg4, xEgg5;
        int yEgg1, yEgg2, yEgg3, yEgg4, yEgg5;
        int xBasket = 359;
        int yBasket = 429;
        int Score = 0;
        int Heart = 3;
        int Egg1;

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            frmEggDrop_Load2(sender, e);
            frmEggDrop_Load1(sender, e);
            btnBatDau.Visible = false;
            Egg1 = SelectEggRandom(Egg1);
            timer.Start();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void frmEggDrop_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] l = lblLeft.Text.ToCharArray();
            char[] r = lblRight.Text.ToCharArray();
            if (e.KeyChar == l[0])
            {
                if(xBasket>=0)
                {
                    xBasket -= 40;
                }

                picBasket.Location = new Point(xBasket, yBasket);
                lblLeft.Text = Convert.ToString((char)rd.Next(98, 122));
                while (lblLeft.Text == lblRight.Text)
                {
                    lblLeft.Text = Convert.ToString((char)rd.Next(98, 122));
                }
            }
            else if (e.KeyChar == r[0])
            {
                if(xBasket<=panel.Width-picBasket.Width-20)
                {
                    xBasket += 40;
                }
              
                picBasket.Location = new Point(xBasket, yBasket);
                lblRight.Text = Convert.ToString((char)rd.Next(98, 122));
                while (lblLeft.Text == lblRight.Text)
                {
                    lblRight.Text = Convert.ToString((char)rd.Next(98, 122));
                }
            }
        }

        private void frmEggDrop_Load(object sender, EventArgs e)
        {
            Database Db = new Database();
            Db.Connection();
            lblUseName.Text = Db.GetAcountUsing(Db.Connec);

            frmEggDrop_Load2(sender, e);
            Score = 0;
            Heart = 3;
            xBasket = 359;
            yBasket = 429;
            picBasket.Location = new Point(xBasket, yBasket);
            lblScore.Text = "00";
            picHeart1.Visible = true;
            picHeart2.Visible = true;
            picHeart3.Visible = true;

            this.KeyPreview = false;
            btnChoiLai.Visible = false;

            xEgg1 = 20;
            xEgg2 = 210;
            xEgg3 = 400;
            xEgg4 = 590;
            xEgg5 = 780;

            yEgg1 = yEgg2 = yEgg3 = yEgg4 = yEgg5 = 0 - picEgg1.Height;
            picEgg1.Location = new Point(xEgg1, yEgg1);
            picEgg2.Location = new Point(xEgg2, yEgg2);
            picEgg3.Location = new Point(xEgg3, yEgg3);
            picEgg4.Location = new Point(xEgg4, yEgg4);
            picEgg5.Location = new Point(xEgg5, yEgg5);

            lblLeft.Text = Convert.ToString((char)rd.Next(98, 122));
            lblRight.Text = Convert.ToString((char)rd.Next(98, 122));
            while (lblLeft.Text == lblRight.Text)
            {
                lblRight.Text = Convert.ToString((char)rd.Next(98, 122));
            }
        }

        private void frmEggDrop_Load1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmEggDrop_Load2(object sender, EventArgs e)
        {
            Db.Connection();
            UseName = Db.GetAcountUsing(Db.Connec);

            maxPoint = Db.MaxScoreEggDrop(Db.Connec, UseName);
            if (maxPoint >= 10)
            {
                lblMaxPoint.Text = maxPoint + "";
            }
            else
            {
                lblMaxPoint.Text = "0" + maxPoint;
            }

            Db.Connec.Close();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            frmEggDrop_Load1(sender, e);
            btnBatDau.Visible = false;
            Egg1 = SelectEggRandom(Egg1);
            timer.Start();
        }
      
        private int SelectEggRandom(int Egg)
        {
            Egg = rd.Next(1, 6);
            return Egg;
        }

        private void GameOver()
        {
            MessageBox.Show("Bạn được số điểm là " + Score + " điểm","Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (Score > maxPoint)
            {
                Db.Connection();
                Db.SaveMaxEggDrop(Db.Connec, UseName, Score);
                Score = 0;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1;
            switch (Egg1)
            {
                case 1:
                    {
                        yEgg1 += 1;
                        picEgg1.Location = new Point(xEgg1, yEgg1);
                        if (yEgg1 + picEgg1.Height >= yBasket)
                        {
                            if (xEgg1+50>= xBasket && xEgg1+10<= (xBasket + picBasket.Width))
                            {
                                Score++;
                                Egg1 = SelectEggRandom(Egg1);
                                yEgg1 = 0 - picEgg1.Height;
                                picEgg1.Location = new Point(xEgg1, yEgg1);
                                break;

                            }
                        }
                         
                        if(yEgg1+picEgg1.Height>=panel.Height)
                        {
                            Egg1 = SelectEggRandom(Egg1);
                            yEgg1 = 0 - picEgg1.Height;
                            picEgg1.Location = new Point(xEgg1, yEgg1);
                            Heart--;
                            if(Heart==2)
                            {
                                picHeart1.Visible = false;
                            }
                            if(Heart==1)
                            {
                                picHeart2.Visible = false;
                            }
                            if(Heart==0)
                            {
                                picHeart3.Visible = false;
                                timer.Stop();
                                GameOver();
                                btnChoiLai.Visible = true;
                                frmEggDrop_Load(sender, e);
                                btnChoiLai.Visible = true;
                            }
                            break;
                        }
                        break;
                    }
                case 2:
                    {
                        yEgg2 += 1;
                        picEgg2.Location = new Point(xEgg2, yEgg2);
                        if (yEgg2 + picEgg2.Height>= yBasket)
                        {
                            if (xEgg2+50 >= xBasket && xEgg2+10 <= (xBasket + picBasket.Width))
                            {
                                Score++;
                                Egg1 = SelectEggRandom(Egg1);
                                yEgg2 = 0 - picEgg2.Height;
                                picEgg2.Location = new Point(xEgg2, yEgg2);
                                break;

                            }
                        }
                        if (yEgg2 + picEgg2.Height >= panel.Height)
                        {
                            Egg1 = SelectEggRandom(Egg1);
                            yEgg2 = 0 - picEgg2.Height;
                            picEgg2.Location = new Point(xEgg2, yEgg2);
                            Heart--;
                            if (Heart == 2)
                            {
                                picHeart1.Visible = false;
                            }
                            if (Heart == 1)
                            {
                                picHeart2.Visible = false;
                            }
                            if (Heart == 0)
                            {
                                picHeart3.Visible = false;
                                timer.Stop();
                                GameOver();
                                frmEggDrop_Load(sender, e);
                                btnChoiLai.Visible = true;
                            }
                            break;
                        }
                        break;
                    }
                case 3:
                    {
                        yEgg3 += 1;
                        picEgg3.Location = new Point(xEgg3, yEgg3);
                        if (yEgg3 + picEgg3.Height >= yBasket)
                        {
                            if (xEgg3+50 >= xBasket &&xEgg3+10 <= (xBasket + picBasket.Width))
                            {
                                Score++;
                                Egg1 = SelectEggRandom(Egg1);
                                yEgg3 = 0 - picEgg3.Height;
                                picEgg3.Location = new Point(xEgg3, yEgg3);
                                break;

                            }
                        }
                        if (yEgg3 + picEgg3.Height >= panel.Height)
                        {
                            Egg1 = SelectEggRandom(Egg1);
                            yEgg3 = 0 - picEgg3.Height;
                            picEgg3.Location = new Point(xEgg3, yEgg3);
                            Heart--;
                            if (Heart == 2)
                            {
                                picHeart1.Visible = false;
                            }
                            if (Heart == 1)
                            {
                                picHeart2.Visible = false;
                            }
                            if (Heart == 0)
                            {
                                picHeart3.Visible = false;
                                timer.Stop();
                                GameOver();
                                frmEggDrop_Load(sender, e);
                                btnChoiLai.Visible = true;
                            }
                            break;

                        }
                        break;
                    }
                case 4:
                    {
                        yEgg4 += 1;
                        picEgg4.Location = new Point(xEgg4, yEgg4);
                        if (yEgg4 + picEgg4.Height >= yBasket)
                        {
                            if (xEgg4 +50 >= xBasket &&xEgg4+10<= (xBasket + picBasket.Width))
                            {
                                Score++;
                                Egg1 = SelectEggRandom(Egg1);
                                yEgg4 = 0 - picEgg4.Height;
                                picEgg4.Location = new Point(xEgg4, yEgg4);
                                break;

                            }
                        }
                        if (yEgg4 + picEgg4.Height >= panel.Height)
                        {
                            Egg1 = SelectEggRandom(Egg1);
                            yEgg4 = 0 - picEgg4.Height;
                            picEgg4.Location = new Point(xEgg4, yEgg4);
                            Heart--;
                            if (Heart == 2)
                            {
                                picHeart1.Visible = false;
                            }
                            if (Heart == 1)
                            {
                                picHeart2.Visible = false;
                            }
                            if (Heart == 0)
                            {
                                picHeart3.Visible = false;
                                timer.Stop();
                                GameOver();
                                frmEggDrop_Load(sender, e);
                                btnChoiLai.Visible = true;
                            }
                            break;

                        }
                        break;
                    }
                case 5:
                    {
                        yEgg5 += 1;
                        picEgg5.Location = new Point(xEgg5, yEgg5);
                        if (yEgg5 + picEgg5.Height >= yBasket)
                        {
                            if (xEgg5 +50 >= xBasket && xEgg5+10 <= (xBasket + picBasket.Width))
                            {
                                Score++;
                                Egg1 = SelectEggRandom(Egg1);
                                yEgg5 = 0 - picEgg5.Height;
                                picEgg5.Location = new Point(xEgg5, yEgg5);
                                break;

                            }
                        }
                        if (yEgg5 + picEgg5.Height >= panel.Height)
                        {
                            Egg1 = SelectEggRandom(Egg1);
                            yEgg5 = 0 - picEgg5.Height;
                            picEgg5.Location = new Point(xEgg5, yEgg5);
                            Heart--;
                            if (Heart == 2)
                            {
                                picHeart1.Visible = false;
                            }
                            if (Heart == 1)
                            {
                                picHeart2.Visible = false;
                            }
                            if (Heart == 0)
                            {
                                picHeart3.Visible = false;
                                timer.Stop();
                                GameOver();  
                                frmEggDrop_Load(sender, e);
                                btnChoiLai.Visible = true;
                            }
                            break;

                        }
                        break;

                    }
                default:
                    {
                        break;
                    }
            }
            if(Score<10)
            {
                lblScore.Text = "0" + Score;
            }
            else
            {
                lblScore.Text = Score + "";
            }

        }

    }
}
