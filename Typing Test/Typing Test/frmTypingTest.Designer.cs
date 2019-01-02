namespace WindowsFormsApplication1
{
    partial class frmTypingTest
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
        public string strTime;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblFastestSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypingTest = new System.Windows.Forms.TextBox();
            this.lblTypingTest = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblUseName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerStart
            // 
            this.TimerStart.Tick += new System.EventHandler(this.TimerStart_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(935, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 40;
            this.label5.Text = "w/m";
            // 
            // lblFastestSpeed
            // 
            this.lblFastestSpeed.AutoSize = true;
            this.lblFastestSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastestSpeed.ForeColor = System.Drawing.Color.Red;
            this.lblFastestSpeed.Location = new System.Drawing.Point(829, 25);
            this.lblFastestSpeed.Name = "lblFastestSpeed";
            this.lblFastestSpeed.Size = new System.Drawing.Size(106, 31);
            this.lblFastestSpeed.TabIndex = 39;
            this.lblFastestSpeed.Text = "Word/s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(716, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 38;
            this.label3.Text = "Faster:";
            // 
            // txtTypingTest
            // 
            this.txtTypingTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypingTest.Location = new System.Drawing.Point(215, 239);
            this.txtTypingTest.Name = "txtTypingTest";
            this.txtTypingTest.Size = new System.Drawing.Size(935, 40);
            this.txtTypingTest.TabIndex = 29;
            this.txtTypingTest.Text = "Gõ vào đây";
            // 
            // lblTypingTest
            // 
            this.lblTypingTest.AllowDrop = true;
            this.lblTypingTest.BackColor = System.Drawing.Color.Silver;
            this.lblTypingTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypingTest.Location = new System.Drawing.Point(209, 170);
            this.lblTypingTest.Name = "lblTypingTest";
            this.lblTypingTest.Size = new System.Drawing.Size(941, 36);
            this.lblTypingTest.TabIndex = 33;
            this.lblTypingTest.Text = "Gõ vào đây";
            this.lblTypingTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::WindowsFormsApplication1.Properties.Resources.Hopstarter_Soft_Scraps_Button_Close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(983, 360);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 49);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblUseName
            // 
            this.lblUseName.AutoSize = true;
            this.lblUseName.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUseName.Location = new System.Drawing.Point(182, 380);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(216, 29);
            this.lblUseName.TabIndex = 28;
            this.lblUseName.Text = "TuanPenSpinner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "UseName:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Image = global::WindowsFormsApplication1.Properties.Resources.Play;
            this.btnStart.Location = new System.Drawing.Point(12, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 78);
            this.btnStart.TabIndex = 35;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMinute.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMinute.Location = new System.Drawing.Point(507, 77);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(59, 46);
            this.lblMinute.TabIndex = 30;
            this.lblMinute.Text = "01";
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoiLai.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.ForeColor = System.Drawing.Color.Red;
            this.btnChoiLai.Image = global::WindowsFormsApplication1.Properties.Resources.Play_agian;
            this.btnChoiLai.Location = new System.Drawing.Point(12, 239);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(159, 71);
            this.btnChoiLai.TabIndex = 36;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Visible = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSecond.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Red;
            this.lblSecond.Location = new System.Drawing.Point(642, 77);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(70, 46);
            this.lblSecond.TabIndex = 31;
            this.lblSecond.Text = "00";
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(592, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 45);
            this.label2.TabIndex = 32;
            this.label2.Text = ":";
            // 
            // frmTypingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 434);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFastestSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTypingTest);
            this.Controls.Add(this.lblTypingTest);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblUseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmTypingTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed Typing Test";
            this.Load += new System.EventHandler(this.frmTypingTest_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmTypingTest_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFastestSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypingTest;
        private System.Windows.Forms.Label lblTypingTest;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblUseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label label2;
    }
}