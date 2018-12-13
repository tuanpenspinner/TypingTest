namespace WindowsFormsApplication1
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSpeedTest = new System.Windows.Forms.Button();
            this.btnTyPingGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTestABC = new System.Windows.Forms.Button();
            this.btnTextPractice = new System.Windows.Forms.Button();
            this.btnFlappyBird = new System.Windows.Forms.Button();
            this.btnCharFallOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnEggDrop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUseName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpeedTest
            // 
            this.btnSpeedTest.AutoSize = true;
            this.btnSpeedTest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpeedTest.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Speed;
            this.btnSpeedTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeedTest.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedTest.ForeColor = System.Drawing.Color.Black;
            this.btnSpeedTest.Location = new System.Drawing.Point(25, 108);
            this.btnSpeedTest.Name = "btnSpeedTest";
            this.btnSpeedTest.Size = new System.Drawing.Size(284, 130);
            this.btnSpeedTest.TabIndex = 1;
            this.btnSpeedTest.Text = "Speed Test";
            this.btnSpeedTest.UseVisualStyleBackColor = false;
            this.btnSpeedTest.Click += new System.EventHandler(this.btnSpeedTest_Click);
            // 
            // btnTyPingGame
            // 
            this.btnTyPingGame.AutoSize = true;
            this.btnTyPingGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTyPingGame.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Keyboard;
            this.btnTyPingGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTyPingGame.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyPingGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnTyPingGame.Location = new System.Drawing.Point(25, 261);
            this.btnTyPingGame.Name = "btnTyPingGame";
            this.btnTyPingGame.Size = new System.Drawing.Size(284, 120);
            this.btnTyPingGame.TabIndex = 2;
            this.btnTyPingGame.Text = "Typing Game";
            this.btnTyPingGame.UseVisualStyleBackColor = false;
            this.btnTyPingGame.Click += new System.EventHandler(this.btnTyPingGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu lựa chọn";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Navy;
            this.btnDangXuat.Image = global::WindowsFormsApplication1.Properties.Resources.Hopstarter_Soft_Scraps_Button_Close;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(912, 481);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(204, 54);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTestABC
            // 
            this.btnTestABC.AutoSize = true;
            this.btnTestABC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTestABC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTestABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestABC.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTestABC.Image = global::WindowsFormsApplication1.Properties.Resources.Roundicons_100_Free_Solid_Alphabet_blocks1;
            this.btnTestABC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestABC.Location = new System.Drawing.Point(340, 118);
            this.btnTestABC.Name = "btnTestABC";
            this.btnTestABC.Size = new System.Drawing.Size(167, 46);
            this.btnTestABC.TabIndex = 4;
            this.btnTestABC.Text = "TestABC";
            this.btnTestABC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestABC.UseVisualStyleBackColor = false;
            this.btnTestABC.Click += new System.EventHandler(this.btnTestABC_Click);
            // 
            // btnTextPractice
            // 
            this.btnTextPractice.AutoSize = true;
            this.btnTextPractice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTextPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextPractice.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTextPractice.Image = global::WindowsFormsApplication1.Properties.Resources.Wwalczyszyn_Android_Style_Honeycomb_Books;
            this.btnTextPractice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextPractice.Location = new System.Drawing.Point(340, 191);
            this.btnTextPractice.Name = "btnTextPractice";
            this.btnTextPractice.Size = new System.Drawing.Size(225, 47);
            this.btnTextPractice.TabIndex = 5;
            this.btnTextPractice.Text = "Text Practice";
            this.btnTextPractice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTextPractice.UseVisualStyleBackColor = false;
            this.btnTextPractice.Click += new System.EventHandler(this.btnTextPractice_Click);
            // 
            // btnFlappyBird
            // 
            this.btnFlappyBird.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFlappyBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlappyBird.Image = global::WindowsFormsApplication1.Properties.Resources.Femfoyou_Angry_Birds_Angry_bird;
            this.btnFlappyBird.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlappyBird.Location = new System.Drawing.Point(340, 269);
            this.btnFlappyBird.Name = "btnFlappyBird";
            this.btnFlappyBird.Size = new System.Drawing.Size(167, 47);
            this.btnFlappyBird.TabIndex = 6;
            this.btnFlappyBird.Text = "FlappyBird";
            this.btnFlappyBird.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlappyBird.UseVisualStyleBackColor = false;
            this.btnFlappyBird.Click += new System.EventHandler(this.btnFlappyBird_Click);
            // 
            // btnCharFallOut
            // 
            this.btnCharFallOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCharFallOut.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnCharFallOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharFallOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCharFallOut.Image = global::WindowsFormsApplication1.Properties.Resources.Google_Noto_Emoji_Travel_Places_42462_mountain;
            this.btnCharFallOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCharFallOut.Location = new System.Drawing.Point(340, 334);
            this.btnCharFallOut.Name = "btnCharFallOut";
            this.btnCharFallOut.Size = new System.Drawing.Size(167, 47);
            this.btnCharFallOut.TabIndex = 7;
            this.btnCharFallOut.Text = "CharFallOut";
            this.btnCharFallOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCharFallOut.UseVisualStyleBackColor = false;
            this.btnCharFallOut.Click += new System.EventHandler(this.btnCharFallOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Games_icon;
            this.pictureBox1.Location = new System.Drawing.Point(712, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.smile;
            this.pictureBox2.Location = new System.Drawing.Point(848, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnScore
            // 
            this.btnScore.AutoSize = true;
            this.btnScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScore.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.award;
            this.btnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScore.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.Black;
            this.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.Location = new System.Drawing.Point(25, 388);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(447, 127);
            this.btnScore.TabIndex = 10;
            this.btnScore.Text = "Thành tích bản thân";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEggDrop
            // 
            this.btnEggDrop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEggDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEggDrop.Image = global::WindowsFormsApplication1.Properties.Resources.Egg1;
            this.btnEggDrop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEggDrop.Location = new System.Drawing.Point(527, 269);
            this.btnEggDrop.Name = "btnEggDrop";
            this.btnEggDrop.Size = new System.Drawing.Size(145, 47);
            this.btnEggDrop.TabIndex = 11;
            this.btnEggDrop.Text = "EggDrop";
            this.btnEggDrop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEggDrop.UseVisualStyleBackColor = false;
            this.btnEggDrop.Click += new System.EventHandler(this.btnEggDrop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(698, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "UseName:";
            // 
            // lblUseName
            // 
            this.lblUseName.AutoSize = true;
            this.lblUseName.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUseName.Location = new System.Drawing.Point(859, 404);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(271, 36);
            this.lblUseName.TabIndex = 13;
            this.lblUseName.Text = "TuanPenSpinner";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1128, 547);
            this.Controls.Add(this.lblUseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEggDrop);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCharFallOut);
            this.Controls.Add(this.btnFlappyBird);
            this.Controls.Add(this.btnTextPractice);
            this.Controls.Add(this.btnTestABC);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTyPingGame);
            this.Controls.Add(this.btnSpeedTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Chính";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeedTest;
        private System.Windows.Forms.Button btnTyPingGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTestABC;
        private System.Windows.Forms.Button btnTextPractice;
        private System.Windows.Forms.Button btnFlappyBird;
        private System.Windows.Forms.Button btnCharFallOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnEggDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUseName;
    }
}