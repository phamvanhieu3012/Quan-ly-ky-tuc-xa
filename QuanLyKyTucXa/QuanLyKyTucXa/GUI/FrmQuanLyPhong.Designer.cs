namespace QuanLyKyTucXa
{
    partial class FrmQuanLyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.txtSosvtoida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSosvhientai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbLoaiphong = new System.Windows.Forms.ComboBox();
            this.cbXeploai = new System.Windows.Forms.ComboBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosvtoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTktheoma = new System.Windows.Forms.RadioButton();
            this.rbTktheoten = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbTkTheoMaday = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số sinh viên tối đa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Xếp loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dãy";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(156, 42);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(129, 20);
            this.txtMaphong.TabIndex = 0;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(156, 86);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(129, 20);
            this.txtTenphong.TabIndex = 1;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Enabled = false;
            this.txtTinhtrang.Location = new System.Drawing.Point(429, 42);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(129, 20);
            this.txtTinhtrang.TabIndex = 4;
            // 
            // txtSosvtoida
            // 
            this.txtSosvtoida.Location = new System.Drawing.Point(156, 174);
            this.txtSosvtoida.Name = "txtSosvtoida";
            this.txtSosvtoida.Size = new System.Drawing.Size(129, 20);
            this.txtSosvtoida.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số sinh viên hiện tại";
            // 
            // txtSosvhientai
            // 
            this.txtSosvhientai.Enabled = false;
            this.txtSosvhientai.Location = new System.Drawing.Point(156, 130);
            this.txtSosvhientai.Name = "txtSosvhientai";
            this.txtSosvhientai.Size = new System.Drawing.Size(129, 20);
            this.txtSosvhientai.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại phòng";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(429, 176);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(129, 21);
            this.cbDay.TabIndex = 7;
            // 
            // cbLoaiphong
            // 
            this.cbLoaiphong.FormattingEnabled = true;
            this.cbLoaiphong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbLoaiphong.Location = new System.Drawing.Point(429, 84);
            this.cbLoaiphong.Name = "cbLoaiphong";
            this.cbLoaiphong.Size = new System.Drawing.Size(129, 21);
            this.cbLoaiphong.TabIndex = 5;
            // 
            // cbXeploai
            // 
            this.cbXeploai.FormattingEnabled = true;
            this.cbXeploai.Items.AddRange(new object[] {
            "Vip",
            "Thường"});
            this.cbXeploai.Location = new System.Drawing.Point(429, 129);
            this.cbXeploai.Name = "cbXeploai";
            this.cbXeploai.Size = new System.Drawing.Size(129, 21);
            this.cbXeploai.TabIndex = 6;
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.tenphong,
            this.sosv,
            this.sosvtoida,
            this.tinhtrang,
            this.loaiphong,
            this.xeploai,
            this.day});
            this.dgvPhong.Location = new System.Drawing.Point(36, 298);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.RowTemplate.Height = 28;
            this.dgvPhong.Size = new System.Drawing.Size(735, 212);
            this.dgvPhong.TabIndex = 13;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            this.dgvPhong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellDoubleClick);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 8;
            this.maphong.Name = "maphong";
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.MinimumWidth = 8;
            this.tenphong.Name = "tenphong";
            // 
            // sosv
            // 
            this.sosv.DataPropertyName = "sosv";
            this.sosv.HeaderText = "Số sinh viên hiện tại";
            this.sosv.MinimumWidth = 8;
            this.sosv.Name = "sosv";
            // 
            // sosvtoida
            // 
            this.sosvtoida.DataPropertyName = "sosvtoida";
            this.sosvtoida.HeaderText = "Số sinh viên tối đa";
            this.sosvtoida.MinimumWidth = 8;
            this.sosvtoida.Name = "sosvtoida";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 8;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 150;
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "loaiphong";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.MinimumWidth = 8;
            this.loaiphong.Name = "loaiphong";
            // 
            // xeploai
            // 
            this.xeploai.DataPropertyName = "xeploai";
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.MinimumWidth = 8;
            this.xeploai.Name = "xeploai";
            // 
            // day
            // 
            this.day.DataPropertyName = "day";
            this.day.HeaderText = "Dãy";
            this.day.MinimumWidth = 8;
            this.day.Name = "day";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbTktheoma);
            this.groupBox1.Controls.Add(this.rbTkTheoMaday);
            this.groupBox1.Controls.Add(this.rbTktheoten);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(613, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 193);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rbTktheoma
            // 
            this.rbTktheoma.AutoSize = true;
            this.rbTktheoma.Location = new System.Drawing.Point(11, 14);
            this.rbTktheoma.Name = "rbTktheoma";
            this.rbTktheoma.Size = new System.Drawing.Size(108, 17);
            this.rbTktheoma.TabIndex = 0;
            this.rbTktheoma.TabStop = true;
            this.rbTktheoma.Text = "Tìm kiếm theo mã";
            this.rbTktheoma.UseVisualStyleBackColor = true;
            // 
            // rbTktheoten
            // 
            this.rbTktheoten.AutoSize = true;
            this.rbTktheoten.Location = new System.Drawing.Point(12, 37);
            this.rbTktheoten.Name = "rbTktheoten";
            this.rbTktheoten.Size = new System.Drawing.Size(109, 17);
            this.rbTktheoten.TabIndex = 1;
            this.rbTktheoten.TabStop = true;
            this.rbTktheoten.Text = "Tìm kiếm theo tên";
            this.rbTktheoten.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.Image = global::QuanLyKyTucXa.Properties.Resources.search;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(11, 137);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(130, 37);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nhập thông tin tìm kiếm:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(11, 104);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(130, 21);
            this.txtTimkiem.TabIndex = 2;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.Image = global::QuanLyKyTucXa.Properties.Resources.reload;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(496, 209);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCapnhat.Size = new System.Drawing.Size(60, 60);
            this.btnCapnhat.TabIndex = 11;
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
            this.btnXoa.Location = new System.Drawing.Point(347, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 10;
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
            this.btnSua.Location = new System.Drawing.Point(198, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSua.Size = new System.Drawing.Size(60, 60);
            this.btnSua.TabIndex = 9;
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
            this.btnThem.Location = new System.Drawing.Point(49, 209);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(633, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Danh sách phòng trống";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbTkTheoMaday
            // 
            this.rbTkTheoMaday.AutoSize = true;
            this.rbTkTheoMaday.Location = new System.Drawing.Point(12, 60);
            this.rbTkTheoMaday.Name = "rbTkTheoMaday";
            this.rbTkTheoMaday.Size = new System.Drawing.Size(128, 17);
            this.rbTkTheoMaday.TabIndex = 1;
            this.rbTkTheoMaday.TabStop = true;
            this.rbTkTheoMaday.Text = "Tìm kiếm theo mã dãy";
            this.rbTkTheoMaday.UseVisualStyleBackColor = true;
            // 
            // FrmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 530);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbXeploai);
            this.Controls.Add(this.cbLoaiphong);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.txtSosvtoida);
            this.Controls.Add(this.txtTinhtrang);
            this.Controls.Add(this.txtSosvhientai);
            this.Controls.Add(this.txtTenphong);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.FrmQuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.TextBox txtSosvtoida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSosvhientai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbLoaiphong;
        private System.Windows.Forms.ComboBox cbXeploai;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTktheoma;
        private System.Windows.Forms.RadioButton rbTktheoten;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosvtoida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbTkTheoMaday;
    }
}