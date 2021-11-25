namespace QuanLyKyTucXa
{
    partial class DanhSachDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachDangKy));
            this.cbLoaiuutien = new System.Windows.Forms.ComboBox();
            this.cbMaphong = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSvDangKy = new System.Windows.Forms.DataGridView();
            this.masvdky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiuutien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiuutien
            // 
            this.cbLoaiuutien.FormattingEnabled = true;
            this.cbLoaiuutien.Items.AddRange(new object[] {
            "Bình thường",
            "Hộ nghèo",
            "Gia đình thương binh liệt sĩ",
            "Du học sinh"});
            this.cbLoaiuutien.Location = new System.Drawing.Point(443, 114);
            this.cbLoaiuutien.Name = "cbLoaiuutien";
            this.cbLoaiuutien.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiuutien.TabIndex = 8;
            // 
            // cbMaphong
            // 
            this.cbMaphong.FormattingEnabled = true;
            this.cbMaphong.Location = new System.Drawing.Point(443, 82);
            this.cbMaphong.Name = "cbMaphong";
            this.cbMaphong.Size = new System.Drawing.Size(121, 21);
            this.cbMaphong.TabIndex = 7;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "K7",
            "K8",
            "K9",
            "K10",
            "K11",
            "K12",
            "K13",
            "K14",
            "K15",
            "K16"});
            this.cbKhoa.Location = new System.Drawing.Point(443, 19);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbKhoa.TabIndex = 5;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(125, 111);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(120, 20);
            this.dtpNgaysinh.TabIndex = 3;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(125, 77);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(120, 21);
            this.cbGioitinh.TabIndex = 2;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(125, 144);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(120, 20);
            this.txtQuequan.TabIndex = 4;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(443, 51);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(121, 20);
            this.txtLop.TabIndex = 6;
            // 
            // txtTensv
            // 
            this.txtTensv.Location = new System.Drawing.Point(125, 45);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(120, 20);
            this.txtTensv.TabIndex = 1;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(125, 12);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(120, 20);
            this.txtMasv.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Loại ưu tiên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên sv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã sv";
            // 
            // dgvSvDangKy
            // 
            this.dgvSvDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSvDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvdky,
            this.tensv,
            this.gioitinh,
            this.ngaysinh,
            this.quequan,
            this.khoa,
            this.lop,
            this.maphong,
            this.loaiuutien});
            this.dgvSvDangKy.Location = new System.Drawing.Point(33, 250);
            this.dgvSvDangKy.Name = "dgvSvDangKy";
            this.dgvSvDangKy.Size = new System.Drawing.Size(598, 238);
            this.dgvSvDangKy.TabIndex = 13;
            this.dgvSvDangKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSvDangKy_CellClick);
            // 
            // masvdky
            // 
            this.masvdky.DataPropertyName = "masvdky";
            this.masvdky.HeaderText = "Mã sinh viên";
            this.masvdky.Name = "masvdky";
            this.masvdky.Width = 80;
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
            // btnCapnhat
            // 
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.Image = global::QuanLyKyTucXa.Properties.Resources.reload;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(503, 174);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCapnhat.Size = new System.Drawing.Size(60, 60);
            this.btnCapnhat.TabIndex = 12;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = global::QuanLyKyTucXa.Properties.Resources.close;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(346, 174);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = global::QuanLyKyTucXa.Properties.Resources.clipboard;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(189, 174);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSua.Size = new System.Drawing.Size(60, 60);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(32, 174);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DanhSachDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 510);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSvDangKy);
            this.Controls.Add(this.cbLoaiuutien);
            this.Controls.Add(this.cbMaphong);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.cbGioitinh);
            this.Controls.Add(this.txtQuequan);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtTensv);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachDangKy";
            this.Text = "Danh sách đăng ký";
            this.Load += new System.EventHandler(this.DanhSachDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLoaiuutien;
        private System.Windows.Forms.ComboBox cbMaphong;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSvDangKy;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvdky;
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