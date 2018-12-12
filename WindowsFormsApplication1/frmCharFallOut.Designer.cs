namespace WindowsFormsApplication1
{
    partial class frmCharFallOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCharFallOut));
            this.lblText = new System.Windows.Forms.Label();
            this.btnChoi = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lblChar = new System.Windows.Forms.Label();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMaxPoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(139, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 0;
            // 
            // btnChoi
            // 
            this.btnChoi.AutoSize = true;
            this.btnChoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoi.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoi.Image = global::WindowsFormsApplication1.Properties.Resources.Play;
            this.btnChoi.Location = new System.Drawing.Point(35, 374);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(105, 78);
            this.btnChoi.TabIndex = 1;
            this.btnChoi.Text = "Chơi";
            this.btnChoi.UseVisualStyleBackColor = false;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Thac_Nước_Naruto;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lblChar);
            this.panel.Controls.Add(this.lblText);
            this.panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel.Location = new System.Drawing.Point(98, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(550, 338);
            this.panel.TabIndex = 2;
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.Image = global::WindowsFormsApplication1.Properties.Resources.Kunai_icon;
            this.lblChar.Location = new System.Drawing.Point(259, 8);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(0, 55);
            this.lblChar.TabIndex = 1;
            this.lblChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.AutoSize = true;
            this.btnChoiLai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoiLai.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.Image = global::WindowsFormsApplication1.Properties.Resources.Play_agian;
            this.btnChoiLai.Location = new System.Drawing.Point(173, 374);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(113, 78);
            this.btnChoiLai.TabIndex = 3;
            this.btnChoiLai.Text = "Chơi lại";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(670, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiem.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.ForeColor = System.Drawing.Color.Maroon;
            this.lblDiem.Location = new System.Drawing.Point(804, 68);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(58, 51);
            this.lblDiem.TabIndex = 5;
            this.lblDiem.Text = "00";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::WindowsFormsApplication1.Properties.Resources.Hopstarter_Soft_Scraps_Button_Close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(538, 383);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 49);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(372, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 49);
            this.textBox1.TabIndex = 7;
            // 
            // lblMaxPoint
            // 
            this.lblMaxPoint.AutoSize = true;
            this.lblMaxPoint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMaxPoint.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPoint.ForeColor = System.Drawing.Color.Black;
            this.lblMaxPoint.Location = new System.Drawing.Point(802, 9);
            this.lblMaxPoint.Name = "lblMaxPoint";
            this.lblMaxPoint.Size = new System.Drawing.Size(51, 43);
            this.lblMaxPoint.TabIndex = 9;
            this.lblMaxPoint.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(654, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "MaxScore:";
            // 
            // frmCharFallOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(874, 464);
            this.Controls.Add(this.lblMaxPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnChoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmCharFallOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharFallOut";
            this.Load += new System.EventHandler(this.frmTextFallOut_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnChoi;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaxPoint;
        private System.Windows.Forms.Label label3;
    }
}