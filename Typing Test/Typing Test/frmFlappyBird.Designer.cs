namespace WindowsFormsApplication1
{
    partial class frmFlappyBird
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public string strLevel;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlappyBird));
            this.lblBird = new System.Windows.Forms.Label();
            this.lblCotTren1 = new System.Windows.Forms.Label();
            this.lblCotDuoi1 = new System.Windows.Forms.Label();
            this.lblCotDuoi2 = new System.Windows.Forms.Label();
            this.lblCotTren2 = new System.Windows.Forms.Label();
            this.lblCotTren3 = new System.Windows.Forms.Label();
            this.lblCotDuoi3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.lblMaxPoint = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBird
            // 
            this.lblBird.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBird.ForeColor = System.Drawing.Color.Red;
            this.lblBird.Image = global::WindowsFormsApplication1.Properties.Resources.FlappyBird1;
            this.lblBird.Location = new System.Drawing.Point(403, 172);
            this.lblBird.Name = "lblBird";
            this.lblBird.Size = new System.Drawing.Size(83, 70);
            this.lblBird.TabIndex = 0;
            this.lblBird.Text = "f";
            this.lblBird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCotTren1
            // 
            this.lblCotTren1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotTren1.Image = global::WindowsFormsApplication1.Properties.Resources.Pipe_flappybird;
            this.lblCotTren1.Location = new System.Drawing.Point(312, -91);
            this.lblCotTren1.Name = "lblCotTren1";
            this.lblCotTren1.Size = new System.Drawing.Size(40, 250);
            this.lblCotTren1.TabIndex = 1;
            // 
            // lblCotDuoi1
            // 
            this.lblCotDuoi1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotDuoi1.Image = ((System.Drawing.Image)(resources.GetObject("lblCotDuoi1.Image")));
            this.lblCotDuoi1.Location = new System.Drawing.Point(312, 298);
            this.lblCotDuoi1.Name = "lblCotDuoi1";
            this.lblCotDuoi1.Size = new System.Drawing.Size(40, 250);
            this.lblCotDuoi1.TabIndex = 2;
            // 
            // lblCotDuoi2
            // 
            this.lblCotDuoi2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotDuoi2.Image = ((System.Drawing.Image)(resources.GetObject("lblCotDuoi2.Image")));
            this.lblCotDuoi2.Location = new System.Drawing.Point(497, 298);
            this.lblCotDuoi2.Name = "lblCotDuoi2";
            this.lblCotDuoi2.Size = new System.Drawing.Size(40, 250);
            this.lblCotDuoi2.TabIndex = 4;
            // 
            // lblCotTren2
            // 
            this.lblCotTren2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotTren2.Image = ((System.Drawing.Image)(resources.GetObject("lblCotTren2.Image")));
            this.lblCotTren2.Location = new System.Drawing.Point(497, -91);
            this.lblCotTren2.Name = "lblCotTren2";
            this.lblCotTren2.Size = new System.Drawing.Size(40, 250);
            this.lblCotTren2.TabIndex = 3;
            // 
            // lblCotTren3
            // 
            this.lblCotTren3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotTren3.Image = ((System.Drawing.Image)(resources.GetObject("lblCotTren3.Image")));
            this.lblCotTren3.Location = new System.Drawing.Point(687, -91);
            this.lblCotTren3.Name = "lblCotTren3";
            this.lblCotTren3.Size = new System.Drawing.Size(40, 250);
            this.lblCotTren3.TabIndex = 3;
            // 
            // lblCotDuoi3
            // 
            this.lblCotDuoi3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotDuoi3.Image = ((System.Drawing.Image)(resources.GetObject("lblCotDuoi3.Image")));
            this.lblCotDuoi3.Location = new System.Drawing.Point(687, 298);
            this.lblCotDuoi3.Name = "lblCotDuoi3";
            this.lblCotDuoi3.Size = new System.Drawing.Size(40, 250);
            this.lblCotDuoi3.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kí tự";
            // 
            // txtTu
            // 
            this.txtTu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTu.ForeColor = System.Drawing.Color.Lime;
            this.txtTu.Location = new System.Drawing.Point(89, 8);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(41, 40);
            this.txtTu.TabIndex = 0;
            this.txtTu.Text = "a";
            // 
            // txtDen
            // 
            this.txtDen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDen.Location = new System.Drawing.Point(209, 10);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(43, 40);
            this.txtDen.TabIndex = 1;
            this.txtDen.Text = "z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(83, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(188, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(42, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Score:";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPoint.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.Red;
            this.lblPoint.Location = new System.Drawing.Point(163, 172);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(54, 45);
            this.lblPoint.TabIndex = 14;
            this.lblPoint.Text = "00";
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoiLai.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChoiLai.Image = global::WindowsFormsApplication1.Properties.Resources.Play_agian;
            this.btnChoiLai.Location = new System.Drawing.Point(4, 393);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(150, 75);
            this.btnChoiLai.TabIndex = 15;
            this.btnChoiLai.Text = "Chơi lại";
            this.btnChoiLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Visible = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::WindowsFormsApplication1.Properties.Resources.Hopstarter_Soft_Scraps_Button_Close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(733, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 46);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBatDau.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBatDau.Image = global::WindowsFormsApplication1.Properties.Resources.Play;
            this.btnBatDau.Location = new System.Drawing.Point(17, 298);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(104, 83);
            this.btnBatDau.TabIndex = 5;
            this.btnBatDau.Text = "Chơi";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // lblMaxPoint
            // 
            this.lblMaxPoint.AutoSize = true;
            this.lblMaxPoint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMaxPoint.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPoint.ForeColor = System.Drawing.Color.Black;
            this.lblMaxPoint.Location = new System.Drawing.Point(163, 107);
            this.lblMaxPoint.Name = "lblMaxPoint";
            this.lblMaxPoint.Size = new System.Drawing.Size(51, 43);
            this.lblMaxPoint.TabIndex = 18;
            this.lblMaxPoint.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-4, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 43);
            this.label7.TabIndex = 17;
            this.label7.Text = "MaxScore:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(0, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "UseName:";
            // 
            // lblUseName
            // 
            this.lblUseName.AutoSize = true;
            this.lblUseName.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUseName.Location = new System.Drawing.Point(123, 239);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(216, 29);
            this.lblUseName.TabIndex = 23;
            this.lblUseName.Text = "TuanPenSpinner";
            // 
            // frmFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.BackGroundFlappyBird;
            this.ClientSize = new System.Drawing.Size(902, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUseName);
            this.Controls.Add(this.lblMaxPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.lblCotDuoi3);
            this.Controls.Add(this.lblCotDuoi2);
            this.Controls.Add(this.lblCotTren3);
            this.Controls.Add(this.lblCotTren2);
            this.Controls.Add(this.lblCotDuoi1);
            this.Controls.Add(this.lblCotTren1);
            this.Controls.Add(this.lblBird);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.frmFlappyBird_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFlappyBird_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBird;
        private System.Windows.Forms.Label lblCotTren1;
        private System.Windows.Forms.Label lblCotDuoi1;
        private System.Windows.Forms.Label lblCotDuoi2;
        private System.Windows.Forms.Label lblCotTren2;
        private System.Windows.Forms.Label lblCotTren3;
        private System.Windows.Forms.Label lblCotDuoi3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label lblMaxPoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUseName;
    }
}