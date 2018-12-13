namespace WindowsFormsApplication1
{
    partial class frmDangki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangki));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPasswordagaint = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblUseNameInvalid = new System.Windows.Forms.Label();
            this.lblPassWordCompare = new System.Windows.Forms.Label();
            this.lblPassWordNull = new System.Windows.Forms.Label();
            this.lblUseNameNull = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsename = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txtPasswordagaint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsename);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUsename);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng kí";
            // 
            // txtPasswordagaint
            // 
            this.txtPasswordagaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordagaint.Location = new System.Drawing.Point(188, 145);
            this.txtPasswordagaint.Name = "txtPasswordagaint";
            this.txtPasswordagaint.PasswordChar = '*';
            this.txtPasswordagaint.Size = new System.Drawing.Size(213, 29);
            this.txtPasswordagaint.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(188, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(213, 29);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsename
            // 
            this.txtUsename.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsename.Location = new System.Drawing.Point(188, 44);
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.Size = new System.Drawing.Size(213, 29);
            this.txtUsename.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(546, 319);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 44);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblUseNameInvalid
            // 
            this.lblUseNameInvalid.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseNameInvalid.ForeColor = System.Drawing.Color.Lime;
            this.lblUseNameInvalid.Image = ((System.Drawing.Image)(resources.GetObject("lblUseNameInvalid.Image")));
            this.lblUseNameInvalid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUseNameInvalid.Location = new System.Drawing.Point(490, 110);
            this.lblUseNameInvalid.Name = "lblUseNameInvalid";
            this.lblUseNameInvalid.Size = new System.Drawing.Size(178, 18);
            this.lblUseNameInvalid.TabIndex = 22;
            this.lblUseNameInvalid.Text = "UseName đã tồn tại";
            this.lblUseNameInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassWordCompare
            // 
            this.lblPassWordCompare.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWordCompare.ForeColor = System.Drawing.Color.Lime;
            this.lblPassWordCompare.Image = ((System.Drawing.Image)(resources.GetObject("lblPassWordCompare.Image")));
            this.lblPassWordCompare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassWordCompare.Location = new System.Drawing.Point(490, 209);
            this.lblPassWordCompare.Name = "lblPassWordCompare";
            this.lblPassWordCompare.Size = new System.Drawing.Size(193, 18);
            this.lblPassWordCompare.TabIndex = 21;
            this.lblPassWordCompare.Text = "Mật khẩu không trùng khớp";
            this.lblPassWordCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassWordNull
            // 
            this.lblPassWordNull.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWordNull.ForeColor = System.Drawing.Color.Lime;
            this.lblPassWordNull.Image = ((System.Drawing.Image)(resources.GetObject("lblPassWordNull.Image")));
            this.lblPassWordNull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassWordNull.Location = new System.Drawing.Point(490, 156);
            this.lblPassWordNull.Name = "lblPassWordNull";
            this.lblPassWordNull.Size = new System.Drawing.Size(185, 18);
            this.lblPassWordNull.TabIndex = 20;
            this.lblPassWordNull.Text = "Chưa nhập PassWord";
            this.lblPassWordNull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUseNameNull
            // 
            this.lblUseNameNull.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseNameNull.ForeColor = System.Drawing.Color.Lime;
            this.lblUseNameNull.Image = ((System.Drawing.Image)(resources.GetObject("lblUseNameNull.Image")));
            this.lblUseNameNull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUseNameNull.Location = new System.Drawing.Point(490, 107);
            this.lblUseNameNull.Name = "lblUseNameNull";
            this.lblUseNameNull.Size = new System.Drawing.Size(178, 18);
            this.lblUseNameNull.TabIndex = 19;
            this.lblUseNameNull.Text = "Chưa nhập UseName";
            this.lblUseNameNull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Register;
            this.pictureBox1.Location = new System.Drawing.Point(185, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangki
            // 
            this.btnDangki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDangki.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangki.ForeColor = System.Drawing.Color.Black;
            this.btnDangki.Image = ((System.Drawing.Image)(resources.GetObject("btnDangki.Image")));
            this.btnDangki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangki.Location = new System.Drawing.Point(313, 319);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(154, 44);
            this.btnDangki.TabIndex = 5;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangki.UseVisualStyleBackColor = true;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(21, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập lại Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsename
            // 
            this.lblUsename.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblUsename.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsename.Image = ((System.Drawing.Image)(resources.GetObject("lblUsename.Image")));
            this.lblUsename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsename.Location = new System.Drawing.Point(21, 44);
            this.lblUsename.Name = "lblUsename";
            this.lblUsename.Size = new System.Drawing.Size(161, 35);
            this.lblUsename.TabIndex = 1;
            this.lblUsename.Text = "UseName";
            this.lblUsename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(695, 375);
            this.Controls.Add(this.lblUseNameInvalid);
            this.Controls.Add(this.lblPassWordCompare);
            this.Controls.Add(this.lblPassWordNull);
            this.Controls.Add(this.lblUseNameNull);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng kí";
            this.Load += new System.EventHandler(this.frmDangki_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsename;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.TextBox txtPasswordagaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPassWordNull;
        private System.Windows.Forms.Label lblUseNameNull;
        private System.Windows.Forms.Label lblPassWordCompare;
        private System.Windows.Forms.Label lblUseNameInvalid;
    }
}