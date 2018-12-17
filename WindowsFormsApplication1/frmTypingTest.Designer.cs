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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUseName = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtTyping = new System.Windows.Forms.TextBox();
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.txtTest = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblUseName);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnChoiLai);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.lblSecond);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblMinute);
            this.panel2.Controls.Add(this.txtTyping);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(467, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 434);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "UseName:";
            // 
            // lblUseName
            // 
            this.lblUseName.AutoSize = true;
            this.lblUseName.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUseName.Location = new System.Drawing.Point(141, 396);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(216, 29);
            this.lblUseName.TabIndex = 23;
            this.lblUseName.Text = "TuanPenSpinner";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::WindowsFormsApplication1.Properties.Resources.Hopstarter_Soft_Scraps_Button_Close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(406, 372);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 49);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoiLai.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.Location = new System.Drawing.Point(387, 10);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(159, 71);
            this.btnChoiLai.TabIndex = 4;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Visible = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Lime;
            this.btnStart.Image = global::WindowsFormsApplication1.Properties.Resources.Play;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 78);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSecond.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Red;
            this.lblSecond.Location = new System.Drawing.Point(287, 19);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(70, 46);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "00";
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(263, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMinute.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMinute.Location = new System.Drawing.Point(198, 19);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(59, 46);
            this.lblMinute.TabIndex = 2;
            this.lblMinute.Text = "01";
            this.lblMinute.Click += new System.EventHandler(this.lblMinute_Click);
            // 
            // txtTyping
            // 
            this.txtTyping.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTyping.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTyping.Enabled = false;
            this.txtTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyping.Location = new System.Drawing.Point(0, 87);
            this.txtTyping.Multiline = true;
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(534, 247);
            this.txtTyping.TabIndex = 0;
            // 
            // TimerStart
            // 
            this.TimerStart.Interval = 1000;
            this.TimerStart.Tick += new System.EventHandler(this.TimerStart_Tick);
            // 
            // txtTest
            // 
            this.txtTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTest.BackColor = System.Drawing.SystemColors.Control;
            this.txtTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(12, 6);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtTest.Size = new System.Drawing.Size(449, 428);
            this.txtTest.TabIndex = 0;
            // 
            // frmTypingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 434);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "frmTypingTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed Typing Test";
            this.Load += new System.EventHandler(this.frmTypingTest_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Timer TimerStart;
        private System.Windows.Forms.TextBox txtTyping;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUseName;
        private System.Windows.Forms.TextBox txtTest;
    }
}