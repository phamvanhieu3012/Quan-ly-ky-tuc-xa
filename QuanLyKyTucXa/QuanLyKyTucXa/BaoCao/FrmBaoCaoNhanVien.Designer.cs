namespace QuanLyKyTucXa.BaoCao
{
    partial class FrmBaoCaoNhanVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.gioitinh,
            this.ngaysinh,
            this.diachi,
            this.sodienthoai,
            this.hesoluong});
            this.dgvNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanvien.Location = new System.Drawing.Point(0, 24);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.Size = new System.Drawing.Size(724, 337);
            this.dgvNhanvien.TabIndex = 13;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // hesoluong
            // 
            this.hesoluong.DataPropertyName = "hesoluong";
            this.hesoluong.HeaderText = "Hệ số lương";
            this.hesoluong.Name = "hesoluong";
            // 
            // FrmBaoCaoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 361);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmBaoCaoNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhân viên";
            this.Load += new System.EventHandler(this.FrmBaoCaoNhanVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluong;
    }
}