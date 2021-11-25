namespace QuanLyKyTucXa
{
    partial class FrmBaoCaoSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiuutien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.tensv,
            this.gioitinh,
            this.ngaysinh,
            this.quequan,
            this.khoa,
            this.lop,
            this.maphong,
            this.loaiuutien});
            this.dgvSinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhvien.Location = new System.Drawing.Point(0, 24);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.Size = new System.Drawing.Size(730, 337);
            this.dgvSinhvien.TabIndex = 11;
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã sinh viên";
            this.masv.Name = "masv";
            this.masv.Width = 80;
            // 
            // tensv
            // 
            this.tensv.DataPropertyName = "tensv";
            this.tensv.HeaderText = "Tên sinh viên";
            this.tensv.Name = "tensv";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 80;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            dataGridViewCellStyle1.Format = "MM/dd/yyyy";
            this.ngaysinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 80;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê quán";
            this.quequan.Name = "quequan";
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "khoa";
            this.khoa.HeaderText = "Khóa";
            this.khoa.Name = "khoa";
            this.khoa.Width = 70;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "lop";
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            this.maphong.Width = 80;
            // 
            // loaiuutien
            // 
            this.loaiuutien.DataPropertyName = "loaiuutien";
            this.loaiuutien.HeaderText = "Loại ưu tiên";
            this.loaiuutien.Name = "loaiuutien";
            // 
            // FrmBaoCaoSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 361);
            this.Controls.Add(this.dgvSinhvien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBaoCaoSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sinh viên";
            this.Load += new System.EventHandler(this.FrmBaoCaoSV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiuutien;
    }
}