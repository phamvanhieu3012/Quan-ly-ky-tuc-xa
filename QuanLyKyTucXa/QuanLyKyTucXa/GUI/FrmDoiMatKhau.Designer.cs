namespace QuanLyKyTucXa
{
    partial class FrmDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhaplai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNhaplai
            // 
            this.txtNhaplai.Location = new System.Drawing.Point(172, 107);
            this.txtNhaplai.Name = "txtNhaplai";
            this.txtNhaplai.PasswordChar = '*';
            this.txtNhaplai.Size = new System.Drawing.Size(148, 20);
            this.txtNhaplai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Location = new System.Drawing.Point(172, 23);
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(148, 20);
            this.txtMatkhaucu.TabIndex = 1;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(172, 65);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.PasswordChar = '*';
            this.txtMatkhaumoi.Size = new System.Drawing.Size(148, 20);
            this.txtMatkhaumoi.TabIndex = 1;
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXacnhan.FlatAppearance.BorderSize = 0;
            this.btnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacnhan.ForeColor = System.Drawing.Color.White;
            this.btnXacnhan.Location = new System.Drawing.Point(81, 151);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(80, 25);
            this.btnXacnhan.TabIndex = 2;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // btnHuybo
            // 
            this.btnHuybo.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuybo.FlatAppearance.BorderSize = 0;
            this.btnHuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuybo.ForeColor = System.Drawing.Color.White;
            this.btnHuybo.Location = new System.Drawing.Point(200, 151);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(80, 25);
            this.btnHuybo.TabIndex = 2;
            this.btnHuybo.Text = "Hủy bỏ";
            this.btnHuybo.UseVisualStyleBackColor = false;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 200);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.txtMatkhaucu);
            this.Controls.Add(this.txtMatkhaumoi);
            this.Controls.Add(this.txtNhaplai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhaplai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatkhaucu;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnHuybo;
    }
}